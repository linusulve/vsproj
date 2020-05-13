namespace TCP_5._2
{
    partial class ServerForm
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
            this.btnServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxInkorg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnServer
            // 
            this.btnServer.Location = new System.Drawing.Point(165, 31);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(112, 23);
            this.btnServer.TabIndex = 0;
            this.btnServer.Text = "Starta server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inkorg";
            // 
            // tbxInkorg
            // 
            this.tbxInkorg.Location = new System.Drawing.Point(12, 93);
            this.tbxInkorg.Multiline = true;
            this.tbxInkorg.Name = "tbxInkorg";
            this.tbxInkorg.Size = new System.Drawing.Size(265, 93);
            this.tbxInkorg.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 198);
            this.Controls.Add(this.tbxInkorg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxInkorg;
    }
}

