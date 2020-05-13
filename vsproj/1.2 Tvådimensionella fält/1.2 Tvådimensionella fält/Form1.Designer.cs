namespace _1._2_Tvådimensionella_fält
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Dest");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Avg");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Ank");
            this.btnÄndra = new System.Windows.Forms.Button();
            this.tbxRad = new System.Windows.Forms.TextBox();
            this.tbxVärde = new System.Windows.Forms.TextBox();
            this.tbxKolumn = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnÄndra
            // 
            this.btnÄndra.Location = new System.Drawing.Point(613, 239);
            this.btnÄndra.Name = "btnÄndra";
            this.btnÄndra.Size = new System.Drawing.Size(147, 40);
            this.btnÄndra.TabIndex = 1;
            this.btnÄndra.Text = "button1";
            this.btnÄndra.UseVisualStyleBackColor = true;
            this.btnÄndra.Click += new System.EventHandler(this.btnÄndra_Click);
            // 
            // tbxRad
            // 
            this.tbxRad.Location = new System.Drawing.Point(613, 126);
            this.tbxRad.Name = "tbxRad";
            this.tbxRad.Size = new System.Drawing.Size(66, 20);
            this.tbxRad.TabIndex = 2;
            // 
            // tbxVärde
            // 
            this.tbxVärde.Location = new System.Drawing.Point(613, 181);
            this.tbxVärde.Name = "tbxVärde";
            this.tbxVärde.Size = new System.Drawing.Size(147, 20);
            this.tbxVärde.TabIndex = 3;
            // 
            // tbxKolumn
            // 
            this.tbxKolumn.Location = new System.Drawing.Point(696, 126);
            this.tbxKolumn.Name = "tbxKolumn";
            this.tbxKolumn.Size = new System.Drawing.Size(64, 20);
            this.tbxKolumn.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(579, 426);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbxKolumn);
            this.Controls.Add(this.tbxVärde);
            this.Controls.Add(this.tbxRad);
            this.Controls.Add(this.btnÄndra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnÄndra;
        private System.Windows.Forms.TextBox tbxRad;
        private System.Windows.Forms.TextBox tbxVärde;
        private System.Windows.Forms.TextBox tbxKolumn;
        private System.Windows.Forms.ListView listView1;
    }
}

