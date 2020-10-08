namespace IPSettingsTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.networkInterfacesListBox = new System.Windows.Forms.ListBox();
            this.IPOptionsPanel = new UIToolbox.RadioButtonPanel();
            this.staticIPOptionGroup = new UIToolbox.RadioGroupBox();
            this.defaultGatewayField = new IPAddressControlLib.IPAddressControl();
            this.subnetMaskField = new IPAddressControlLib.IPAddressControl();
            this.ipAddressField = new IPAddressControlLib.IPAddressControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dynamicIPOption = new System.Windows.Forms.RadioButton();
            this.applySettingsButton = new System.Windows.Forms.Button();
            this.refreshInterfacesButton = new System.Windows.Forms.Button();
            this.IPOptionsPanel.SuspendLayout();
            this.staticIPOptionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // networkInterfacesListBox
            // 
            this.networkInterfacesListBox.FormattingEnabled = true;
            this.networkInterfacesListBox.Location = new System.Drawing.Point(13, 13);
            this.networkInterfacesListBox.Name = "networkInterfacesListBox";
            this.networkInterfacesListBox.Size = new System.Drawing.Size(202, 173);
            this.networkInterfacesListBox.TabIndex = 0;
            // 
            // IPOptionsPanel
            // 
            this.IPOptionsPanel.Controls.Add(this.staticIPOptionGroup);
            this.IPOptionsPanel.Controls.Add(this.dynamicIPOption);
            this.IPOptionsPanel.Location = new System.Drawing.Point(221, 12);
            this.IPOptionsPanel.Name = "IPOptionsPanel";
            this.IPOptionsPanel.Size = new System.Drawing.Size(268, 137);
            this.IPOptionsPanel.TabIndex = 7;
            // 
            // staticIPOptionGroup
            // 
            this.staticIPOptionGroup.Controls.Add(this.defaultGatewayField);
            this.staticIPOptionGroup.Controls.Add(this.subnetMaskField);
            this.staticIPOptionGroup.Controls.Add(this.ipAddressField);
            this.staticIPOptionGroup.Controls.Add(this.label1);
            this.staticIPOptionGroup.Controls.Add(this.label2);
            this.staticIPOptionGroup.Controls.Add(this.label3);
            this.staticIPOptionGroup.DisableChildrenIfUnchecked = true;
            this.staticIPOptionGroup.Location = new System.Drawing.Point(9, 26);
            this.staticIPOptionGroup.Name = "staticIPOptionGroup";
            this.staticIPOptionGroup.Size = new System.Drawing.Size(252, 106);
            this.staticIPOptionGroup.TabIndex = 1;
            this.staticIPOptionGroup.TabStop = false;
            this.staticIPOptionGroup.Text = "Use the following IP address:";
            // 
            // defaultGatewayField
            // 
            this.defaultGatewayField.AllowInternalTab = false;
            this.defaultGatewayField.AutoHeight = true;
            this.defaultGatewayField.BackColor = System.Drawing.SystemColors.Window;
            this.defaultGatewayField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.defaultGatewayField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.defaultGatewayField.Location = new System.Drawing.Point(128, 74);
            this.defaultGatewayField.MinimumSize = new System.Drawing.Size(87, 20);
            this.defaultGatewayField.Name = "defaultGatewayField";
            this.defaultGatewayField.ReadOnly = false;
            this.defaultGatewayField.Size = new System.Drawing.Size(112, 20);
            this.defaultGatewayField.TabIndex = 9;
            this.defaultGatewayField.Text = "...";
            // 
            // subnetMaskField
            // 
            this.subnetMaskField.AllowInternalTab = false;
            this.subnetMaskField.AutoHeight = true;
            this.subnetMaskField.BackColor = System.Drawing.SystemColors.Window;
            this.subnetMaskField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subnetMaskField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subnetMaskField.Location = new System.Drawing.Point(128, 48);
            this.subnetMaskField.MinimumSize = new System.Drawing.Size(87, 20);
            this.subnetMaskField.Name = "subnetMaskField";
            this.subnetMaskField.ReadOnly = false;
            this.subnetMaskField.Size = new System.Drawing.Size(112, 20);
            this.subnetMaskField.TabIndex = 8;
            this.subnetMaskField.Text = "...";
            // 
            // ipAddressField
            // 
            this.ipAddressField.AllowInternalTab = false;
            this.ipAddressField.AutoHeight = true;
            this.ipAddressField.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressField.Location = new System.Drawing.Point(128, 22);
            this.ipAddressField.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipAddressField.Name = "ipAddressField";
            this.ipAddressField.ReadOnly = false;
            this.ipAddressField.Size = new System.Drawing.Size(112, 20);
            this.ipAddressField.TabIndex = 7;
            this.ipAddressField.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subnet mask:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Default gateway:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dynamicIPOption
            // 
            this.dynamicIPOption.AutoSize = true;
            this.dynamicIPOption.Location = new System.Drawing.Point(18, 3);
            this.dynamicIPOption.Name = "dynamicIPOption";
            this.dynamicIPOption.Size = new System.Drawing.Size(188, 17);
            this.dynamicIPOption.TabIndex = 0;
            this.dynamicIPOption.TabStop = true;
            this.dynamicIPOption.Text = "Obtain an IP address automatically";
            this.dynamicIPOption.UseVisualStyleBackColor = true;
            // 
            // applySettingsButton
            // 
            this.applySettingsButton.Location = new System.Drawing.Point(407, 163);
            this.applySettingsButton.Name = "applySettingsButton";
            this.applySettingsButton.Size = new System.Drawing.Size(75, 23);
            this.applySettingsButton.TabIndex = 8;
            this.applySettingsButton.Text = "Apply";
            this.applySettingsButton.UseVisualStyleBackColor = true;
            this.applySettingsButton.Click += new System.EventHandler(this.applySettingsButton_Click);
            // 
            // refreshInterfacesButton
            // 
            this.refreshInterfacesButton.Location = new System.Drawing.Point(222, 162);
            this.refreshInterfacesButton.Name = "refreshInterfacesButton";
            this.refreshInterfacesButton.Size = new System.Drawing.Size(75, 23);
            this.refreshInterfacesButton.TabIndex = 9;
            this.refreshInterfacesButton.Text = "Refresh List";
            this.refreshInterfacesButton.UseVisualStyleBackColor = true;
            this.refreshInterfacesButton.Click += new System.EventHandler(this.refreshInterfacesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(493, 194);
            this.Controls.Add(this.refreshInterfacesButton);
            this.Controls.Add(this.applySettingsButton);
            this.Controls.Add(this.IPOptionsPanel);
            this.Controls.Add(this.networkInterfacesListBox);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Internet Protocol Version 4 (TCP/IPv4) Properties";
            this.IPOptionsPanel.ResumeLayout(false);
            this.IPOptionsPanel.PerformLayout();
            this.staticIPOptionGroup.ResumeLayout(false);
            this.staticIPOptionGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox networkInterfacesListBox;
        private UIToolbox.RadioButtonPanel IPOptionsPanel;
        private UIToolbox.RadioGroupBox staticIPOptionGroup;
        private IPAddressControlLib.IPAddressControl defaultGatewayField;
        private IPAddressControlLib.IPAddressControl subnetMaskField;
        private IPAddressControlLib.IPAddressControl ipAddressField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton dynamicIPOption;
        private System.Windows.Forms.Button applySettingsButton;
        private System.Windows.Forms.Button refreshInterfacesButton;
    }
}

