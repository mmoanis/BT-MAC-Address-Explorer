namespace BTMAE
{
    partial class MainMindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMindow));
            this.explor = new System.Windows.Forms.Button();
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lastUsedTB = new System.Windows.Forms.TextBox();
            this.lastSeenTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rememberedTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.authenticatedTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.connectedTB = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.macAddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notificaion = new System.Windows.Forms.NotifyIcon(this.components);
            this.aboutTB = new System.Windows.Forms.RichTextBox();
            this.poke = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // explor
            // 
            this.explor.Location = new System.Drawing.Point(12, 214);
            this.explor.Name = "explor";
            this.explor.Size = new System.Drawing.Size(171, 23);
            this.explor.TabIndex = 0;
            this.explor.Text = "explor";
            this.explor.UseVisualStyleBackColor = true;
            this.explor.Click += new System.EventHandler(this.explor_Click);
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(62, 12);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(121, 21);
            this.devicesComboBox.TabIndex = 1;
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lastUsedTB);
            this.panel1.Controls.Add(this.lastSeenTB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rememberedTB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.authenticatedTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.connectedTB);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.macAddressTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(200, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 194);
            this.panel1.TabIndex = 2;
            // 
            // lastUsedTB
            // 
            this.lastUsedTB.Location = new System.Drawing.Point(95, 173);
            this.lastUsedTB.Name = "lastUsedTB";
            this.lastUsedTB.ReadOnly = true;
            this.lastUsedTB.Size = new System.Drawing.Size(211, 20);
            this.lastUsedTB.TabIndex = 14;
            // 
            // lastSeenTB
            // 
            this.lastSeenTB.Location = new System.Drawing.Point(95, 139);
            this.lastSeenTB.Name = "lastSeenTB";
            this.lastSeenTB.ReadOnly = true;
            this.lastSeenTB.Size = new System.Drawing.Size(211, 20);
            this.lastSeenTB.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "last used:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "last seen:";
            // 
            // rememberedTB
            // 
            this.rememberedTB.Location = new System.Drawing.Point(95, 106);
            this.rememberedTB.Name = "rememberedTB";
            this.rememberedTB.ReadOnly = true;
            this.rememberedTB.Size = new System.Drawing.Size(61, 20);
            this.rememberedTB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Remembered:";
            // 
            // authenticatedTB
            // 
            this.authenticatedTB.Location = new System.Drawing.Point(245, 77);
            this.authenticatedTB.Name = "authenticatedTB";
            this.authenticatedTB.ReadOnly = true;
            this.authenticatedTB.Size = new System.Drawing.Size(61, 20);
            this.authenticatedTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Authenticated:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(71, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "MAC Address:";
            this.linkLabel1.UseWaitCursor = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // connectedTB
            // 
            this.connectedTB.Location = new System.Drawing.Point(95, 77);
            this.connectedTB.Name = "connectedTB";
            this.connectedTB.ReadOnly = true;
            this.connectedTB.Size = new System.Drawing.Size(61, 20);
            this.connectedTB.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(63, 48);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(243, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Connected:";
            // 
            // macAddressTextBox
            // 
            this.macAddressTextBox.Location = new System.Drawing.Point(151, 5);
            this.macAddressTextBox.Name = "macAddressTextBox";
            this.macAddressTextBox.ReadOnly = true;
            this.macAddressTextBox.Size = new System.Drawing.Size(155, 20);
            this.macAddressTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "devices:";
            // 
            // notificaion
            // 
            this.notificaion.Icon = ((System.Drawing.Icon)(resources.GetObject("notificaion.Icon")));
            this.notificaion.Visible = true;
            // 
            // aboutTB
            // 
            this.aboutTB.Location = new System.Drawing.Point(12, 61);
            this.aboutTB.Name = "aboutTB";
            this.aboutTB.ReadOnly = true;
            this.aboutTB.Size = new System.Drawing.Size(171, 145);
            this.aboutTB.TabIndex = 4;
            this.aboutTB.Text = "";
            this.aboutTB.Click += new System.EventHandler(this.aboutTB_Click);
            // 
            // poke
            // 
            this.poke.Location = new System.Drawing.Point(287, 214);
            this.poke.Name = "poke";
            this.poke.Size = new System.Drawing.Size(171, 23);
            this.poke.TabIndex = 5;
            this.poke.Text = "poke";
            this.poke.UseVisualStyleBackColor = true;
            this.poke.Click += new System.EventHandler(this.poke_Click);
            // 
            // MainMindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 260);
            this.Controls.Add(this.poke);
            this.Controls.Add(this.aboutTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.devicesComboBox);
            this.Controls.Add(this.explor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BT MAC Address Explorer";
            this.Load += new System.EventHandler(this.MainMindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button explor;
        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox macAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox connectedTB;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authenticatedTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rememberedTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lastUsedTB;
        private System.Windows.Forms.TextBox lastSeenTB;
        private System.Windows.Forms.NotifyIcon notificaion;
        private System.Windows.Forms.RichTextBox aboutTB;
        private System.Windows.Forms.Button poke;
    }
}

