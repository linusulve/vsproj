namespace TCP_5._2_Klient
{
    partial class klientForm
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
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.btnSänd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.btnSägHej = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(53, 58);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(108, 20);
            this.tbxIP.TabIndex = 0;
            // 
            // btnSänd
            // 
            this.btnSänd.Location = new System.Drawing.Point(53, 113);
            this.btnSänd.Name = "btnSänd";
            this.btnSänd.Size = new System.Drawing.Size(108, 23);
            this.btnSänd.TabIndex = 1;
            this.btnSänd.Text = "Säg Hej!";
            this.btnSänd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serverns IP-adress";
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(53, 84);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(108, 23);
            this.btnAnslut.TabIndex = 3;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            // 
            // btnSägHej
            // 
            this.btnSägHej.Location = new System.Drawing.Point(26, 108);
            this.btnSägHej.Name = "btnSägHej";
            this.btnSägHej.Size = new System.Drawing.Size(171, 27);
            this.btnSägHej.TabIndex = 4;
            this.btnSägHej.TabStop = false;
            this.btnSägHej.Text = "groupBox1";
            // 
            // klientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 148);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSänd);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.btnSägHej);
            this.Name = "klientForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Button btnSänd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.GroupBox btnSägHej;
    }
}

