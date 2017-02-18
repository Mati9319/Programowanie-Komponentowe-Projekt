namespace Quiz_Matematyczny_2._0
{
    partial class pomoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pomoc));
            this.tytuł_pomoc = new System.Windows.Forms.Label();
            this.przycisk_pomoc_powrót = new System.Windows.Forms.Button();
            this.pomoc_przycisk_jakgrac = new System.Windows.Forms.Button();
            this.pomoc_przycisk_punktacja = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tytuł_pomoc
            // 
            this.tytuł_pomoc.AutoSize = true;
            this.tytuł_pomoc.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytuł_pomoc.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tytuł_pomoc.Location = new System.Drawing.Point(12, 9);
            this.tytuł_pomoc.Name = "tytuł_pomoc";
            this.tytuł_pomoc.Size = new System.Drawing.Size(113, 37);
            this.tytuł_pomoc.TabIndex = 1;
            this.tytuł_pomoc.Text = "Pomoc";
            // 
            // przycisk_pomoc_powrót
            // 
            this.przycisk_pomoc_powrót.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_pomoc_powrót.Location = new System.Drawing.Point(19, 372);
            this.przycisk_pomoc_powrót.Name = "przycisk_pomoc_powrót";
            this.przycisk_pomoc_powrót.Size = new System.Drawing.Size(173, 49);
            this.przycisk_pomoc_powrót.TabIndex = 3;
            this.przycisk_pomoc_powrót.Text = "powrót";
            this.przycisk_pomoc_powrót.UseVisualStyleBackColor = true;
            this.przycisk_pomoc_powrót.Click += new System.EventHandler(this.przycisk_pomoc_powrót_Click);
            // 
            // pomoc_przycisk_jakgrac
            // 
            this.pomoc_przycisk_jakgrac.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pomoc_przycisk_jakgrac.Location = new System.Drawing.Point(19, 83);
            this.pomoc_przycisk_jakgrac.Name = "pomoc_przycisk_jakgrac";
            this.pomoc_przycisk_jakgrac.Size = new System.Drawing.Size(173, 49);
            this.pomoc_przycisk_jakgrac.TabIndex = 4;
            this.pomoc_przycisk_jakgrac.Text = "Jak grać";
            this.pomoc_przycisk_jakgrac.UseVisualStyleBackColor = true;
            this.pomoc_przycisk_jakgrac.Click += new System.EventHandler(this.pomoc_przycisk_jakgrac_Click);
            // 
            // pomoc_przycisk_punktacja
            // 
            this.pomoc_przycisk_punktacja.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pomoc_przycisk_punktacja.Location = new System.Drawing.Point(19, 138);
            this.pomoc_przycisk_punktacja.Name = "pomoc_przycisk_punktacja";
            this.pomoc_przycisk_punktacja.Size = new System.Drawing.Size(173, 49);
            this.pomoc_przycisk_punktacja.TabIndex = 5;
            this.pomoc_przycisk_punktacja.Text = "Punktacja";
            this.pomoc_przycisk_punktacja.UseVisualStyleBackColor = true;
            this.pomoc_przycisk_punktacja.Click += new System.EventHandler(this.pomoc_przycisk_punktacja_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 331);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pomoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pomoc_przycisk_punktacja);
            this.Controls.Add(this.pomoc_przycisk_jakgrac);
            this.Controls.Add(this.przycisk_pomoc_powrót);
            this.Controls.Add(this.tytuł_pomoc);
            this.Name = "pomoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Matematyczny 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytuł_pomoc;
        private System.Windows.Forms.Button przycisk_pomoc_powrót;
        private System.Windows.Forms.Button pomoc_przycisk_jakgrac;
        private System.Windows.Forms.Button pomoc_przycisk_punktacja;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}