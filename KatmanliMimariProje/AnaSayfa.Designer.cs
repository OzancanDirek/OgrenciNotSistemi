namespace KatmanliMimariProje
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.BtnNotlarr = new System.Windows.Forms.Button();
            this.BtnDersler = new System.Windows.Forms.Button();
            this.BtnOgrenci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNotlarr
            // 
            this.BtnNotlarr.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.BtnNotlarr.FlatAppearance.BorderSize = 2;
            this.BtnNotlarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotlarr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnNotlarr.Location = new System.Drawing.Point(446, 431);
            this.BtnNotlarr.Name = "BtnNotlarr";
            this.BtnNotlarr.Size = new System.Drawing.Size(252, 93);
            this.BtnNotlarr.TabIndex = 5;
            this.BtnNotlarr.Text = "Notlar";
            this.BtnNotlarr.UseVisualStyleBackColor = true;
            this.BtnNotlarr.Click += new System.EventHandler(this.BtnDersler_Click);
            // 
            // BtnDersler
            // 
            this.BtnDersler.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnDersler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDersler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnDersler.Location = new System.Drawing.Point(808, 431);
            this.BtnDersler.Name = "BtnDersler";
            this.BtnDersler.Size = new System.Drawing.Size(252, 93);
            this.BtnDersler.TabIndex = 4;
            this.BtnDersler.Text = "Dersler";
            this.BtnDersler.UseVisualStyleBackColor = true;
            this.BtnDersler.Click += new System.EventHandler(this.BtnDersler_Click_1);
            // 
            // BtnOgrenci
            // 
            this.BtnOgrenci.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnOgrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOgrenci.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOgrenci.Location = new System.Drawing.Point(78, 431);
            this.BtnOgrenci.Name = "BtnOgrenci";
            this.BtnOgrenci.Size = new System.Drawing.Size(261, 93);
            this.BtnOgrenci.TabIndex = 3;
            this.BtnOgrenci.Text = "Ogrenci";
            this.BtnOgrenci.UseVisualStyleBackColor = true;
            this.BtnOgrenci.Click += new System.EventHandler(this.BtnOgrenci_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 618);
            this.Controls.Add(this.BtnNotlarr);
            this.Controls.Add(this.BtnDersler);
            this.Controls.Add(this.BtnOgrenci);
            this.DoubleBuffered = true;
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNotlarr;
        private System.Windows.Forms.Button BtnDersler;
        private System.Windows.Forms.Button BtnOgrenci;
    }
}