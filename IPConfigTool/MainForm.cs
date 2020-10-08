using Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPSettingsTool
{
    public partial class MainForm : Form
    {
        public Dictionary<string, IPInterfaceProperties> AdapterIPProperties;

        public MainForm()
        {
            InitializeComponent();

            IPOptionsPanel.AddCheckEventListeners();

            AdapterIPProperties = new Dictionary<string, IPInterfaceProperties>();

            RefreshInterfaces();
        }

        public string SelectedInterface => (string) networkInterfacesListBox.SelectedItem;
        public IPInterfaceProperties SelectedInterfaceProperties => AdapterIPProperties[SelectedInterface];
        public IPAddress SelectedIPAddress => AdapterIPProperties[SelectedInterface].UnicastAddresses.FirstOrDefault(a => a.Address.AddressFamily == AddressFamily.InterNetwork).Address;
        public IPAddress SelectedSubnetMask => SelectedInterfaceProperties.UnicastAddresses.FirstOrDefault(a => a.Address.AddressFamily == AddressFamily.InterNetwork).IPv4Mask;
        public IPAddress SelectedGatewayAddress => AdapterIPProperties[SelectedInterface].GatewayAddresses.FirstOrDefault(a => a.Address.AddressFamily == AddressFamily.InterNetwork)?.Address;

        public bool DhcpSelected => dynamicIPOption.Checked;

        private void RefreshInterfaces()
        {
            AdapterIPProperties.Clear();
            networkInterfacesListBox.Items.Clear();

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var adapter in interfaces)
            {
                var ipProps = adapter.GetIPProperties();
                foreach (var ip in ipProps.UnicastAddresses)
                {
                    if ((adapter.OperationalStatus == OperationalStatus.Up)
                    && (ip.Address.AddressFamily == AddressFamily.InterNetwork))
                    {
                        Console.Out.WriteLine(ip.Address.ToString() + "|" + adapter.Description.ToString());
                        networkInterfacesListBox.Items.Add(adapter.Name);
                        AdapterIPProperties.Add(adapter.Name, ipProps);
                    }
                }
            }

            networkInterfacesListBox.SelectedIndex = 0;
            networkInterfacesListBox.SelectedIndexChanged += NetworkInterfacesListBox_SelectedIndexChanged;
            NetworkInterfacesListBox_SelectedIndexChanged(this, null);
        }

        private void NetworkInterfacesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ipAddressField.SetAddressBytes(SelectedIPAddress.GetAddressBytes());

            subnetMaskField.SetAddressBytes(SelectedSubnetMask.GetAddressBytes());

            if (SelectedGatewayAddress != null)
            {
                defaultGatewayField.SetAddressBytes(SelectedGatewayAddress.GetAddressBytes());
            }

            if (AdapterIPProperties[SelectedInterface].GetIPv4Properties().IsDhcpEnabled)
            {
                dynamicIPOption.Checked = true;
            }
            else
            {
                staticIPOptionGroup.Checked = true;
            }
        }

        private void applySettingsButton_Click(object sender, EventArgs e)
        {
            string args = "interface ip set address \"";
            args += SelectedInterface + "\" ";
            if (DhcpSelected)
            {
                args += "dhcp";
            }
            else
            {
                args += "static ";
                args += ipAddressField.ToString() + " " + subnetMaskField.ToString() + " " + defaultGatewayField.ToString();
            }

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("netsh.exe", args);
            p.StartInfo.Verb = "runas";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
        }

        private void refreshInterfacesButton_Click(object sender, EventArgs e)
        {
            RefreshInterfaces();
        }
    }
}
