namespace Quiz_Matematyczny_2._0
{
    partial class punktacja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(punktacja));
            this.tytuł_punktacja = new System.Windows.Forms.Label();
            this.przycisk_punktacja_powrót = new System.Windows.Forms.Button();
            this.punktacja_tekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tytuł_punktacja
            // 
            this.tytuł_punktacja.AutoSize = true;
            this.tytuł_punktacja.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytuł_punktacja.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tytuł_punktacja.Location = new System.Drawing.Point(12, 9);
            this.tytuł_punktacja.Name = "tytuł_punktacja";
            this.tytuł_punktacja.Size = new System.Drawing.Size(159, 37);
            this.tytuł_punktacja.TabIndex = 3;
            this.tytuł_punktacja.Text = "Punktacja";
            // 
            // przycisk_punktacja_powrót
            // 
            this.przycisk_punktacja_powrót.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_punktacja_powrót.Location = new System.Drawing.Point(19, 372);
            this.przycisk_punktacja_powrót.Name = "przycisk_punktacja_powrót";
            this.przycisk_punktacja_powrót.Size = new System.Drawing.Size(173, 49);
            this.przycisk_punktacja_powrót.TabIndex = 5;
            this.przycisk_punktacja_powrót.Text = "powrót";
            this.przycisk_punktacja_powrót.UseVisualStyleBackColor = true;
            this.przycisk_punktacja_powrót.Click += new System.EventHandler(this.przycisk_punktacja_powrót_Click);
            // 
            // punktacja_tekst
            // 
            this.punktacja_tekst.AutoSize = true;
            this.punktacja_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punktacja_tekst.Location = new System.Drawing.Point(16, 64);
            this.punktacja_tekst.Name = "punktacja_tekst";
            this.punktacja_tekst.Size = new System.Drawing.Size(602, 275);
            this.punktacja_tekst.TabIndex = 6;
            this.punktacja_tekst.Text = resources.GetString("punktacja_tekst.Text");
            // 
            // punktacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.ControlBox = false;
            this.Controls.Add(this.punktacja_tekst);
            this.Controls.Add(this.przycisk_punktacja_powrót);
            this.Controls.Add(this.tytuł_punktacja);
            this.Name = "punktacja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Matematyczny 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytuł_punktacja;
        private System.Windows.Forms.Button przycisk_punktacja_powrót;
        private System.Windows.Forms.Label punktacja_tekst;
    }
}