namespace Connect
{
    partial class ServerForms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx4 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnV4 = new System.Windows.Forms.RadioButton();
            this.rbnV3 = new System.Windows.Forms.RadioButton();
            this.rbnV2 = new System.Windows.Forms.RadioButton();
            this.rbnV1 = new System.Windows.Forms.RadioButton();
            this.btnServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx4);
            this.groupBox1.Controls.Add(this.tbx3);
            this.groupBox1.Controls.Add(this.tbx2);
            this.groupBox1.Controls.Add(this.tbx1);
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbx4
            // 
            this.tbx4.Location = new System.Drawing.Point(268, 122);
            this.tbx4.Multiline = true;
            this.tbx4.Name = "tbx4";
            this.tbx4.Size = new System.Drawing.Size(254, 100);
            this.tbx4.TabIndex = 12;
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(6, 122);
            this.tbx3.Multiline = true;
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(256, 100);
            this.tbx3.TabIndex = 11;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(268, 19);
            this.tbx2.Multiline = true;
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(254, 97);
            this.tbx2.TabIndex = 10;
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(6, 19);
            this.tbx1.Multiline = true;
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(256, 97);
            this.tbx1.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnV4);
            this.groupBox2.Controls.Add(this.rbnV3);
            this.groupBox2.Controls.Add(this.rbnV2);
            this.groupBox2.Controls.Add(this.rbnV1);
            this.groupBox2.Controls.Add(this.btnServer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.tbxPort);
            this.groupBox2.Controls.Add(this.tbxIP);
            this.groupBox2.Location = new System.Drawing.Point(546, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 426);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rbnV4
            // 
            this.rbnV4.AutoSize = true;
            this.rbnV4.Location = new System.Drawing.Point(71, 228);
            this.rbnV4.Name = "rbnV4";
            this.rbnV4.Size = new System.Drawing.Size(56, 17);
            this.rbnV4.TabIndex = 17;
            this.rbnV4.TabStop = true;
            this.rbnV4.Text = "view 4";
            this.rbnV4.UseVisualStyleBackColor = true;
            this.rbnV4.CheckedChanged += new System.EventHandler(this.rbnV4_CheckedChanged);
            // 
            // rbnV3
            // 
            this.rbnV3.AutoSize = true;
            this.rbnV3.Location = new System.Drawing.Point(9, 228);
            this.rbnV3.Name = "rbnV3";
            this.rbnV3.Size = new System.Drawing.Size(56, 17);
            this.rbnV3.TabIndex = 16;
            this.rbnV3.TabStop = true;
            this.rbnV3.Text = "view 3";
            this.rbnV3.UseVisualStyleBackColor = true;
            this.rbnV3.CheckedChanged += new System.EventHandler(this.rbnV3_CheckedChanged);
            // 
            // rbnV2
            // 
            this.rbnV2.AutoSize = true;
            this.rbnV2.Location = new System.Drawing.Point(71, 205);
            this.rbnV2.Name = "rbnV2";
            this.rbnV2.Size = new System.Drawing.Size(56, 17);
            this.rbnV2.TabIndex = 15;
            this.rbnV2.TabStop = true;
            this.rbnV2.Text = "view 2";
            this.rbnV2.UseVisualStyleBackColor = true;
            this.rbnV2.CheckedChanged += new System.EventHandler(this.rbnV2_CheckedChanged);
            // 
            // rbnV1
            // 
            this.rbnV1.AutoSize = true;
            this.rbnV1.Location = new System.Drawing.Point(9, 205);
            this.rbnV1.Name = "rbnV1";
            this.rbnV1.Size = new System.Drawing.Size(56, 17);
            this.rbnV1.TabIndex = 14;
            this.rbnV1.TabStop = true;
            this.rbnV1.Text = "view 1";
            this.rbnV1.UseVisualStyleBackColor = true;
            this.rbnV1.CheckedChanged += new System.EventHandler(this.rbnV1_CheckedChanged);
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(6, 145);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(230, 23);
            this.btnServer.TabIndex = 13;
            this.btnServer.Text = "Lyssna";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Servers IP";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 116);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(230, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(6, 83);
            this.tbxPort.Multiline = true;
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(230, 27);
            this.tbxPort.TabIndex = 9;
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(6, 37);
            this.tbxIP.Multiline = true;
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(230, 25);
            this.tbxIP.TabIndex = 8;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(18, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(178, 192);
            this.treeView1.TabIndex = 5;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(199, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(341, 192);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // ServerForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ServerForms";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx4;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.RadioButton rbnV4;
        private System.Windows.Forms.RadioButton rbnV3;
        private System.Windows.Forms.RadioButton rbnV2;
        private System.Windows.Forms.RadioButton rbnV1;
    }
}

