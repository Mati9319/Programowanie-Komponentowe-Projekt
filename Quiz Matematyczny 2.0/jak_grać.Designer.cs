namespace Quiz_Matematyczny_2._0
{
    partial class jak_grać
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
            this.tytuł_jakgrać = new System.Windows.Forms.Label();
            this.przycisk_jakgrać_powrót = new System.Windows.Forms.Button();
            this.jak_grać_tekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tytuł_jakgrać
            // 
            this.tytuł_jakgrać.AutoSize = true;
            this.tytuł_jakgrać.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytuł_jakgrać.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tytuł_jakgrać.Location = new System.Drawing.Point(12, 9);
            this.tytuł_jakgrać.Name = "tytuł_jakgrać";
            this.tytuł_jakgrać.Size = new System.Drawing.Size(138, 37);
            this.tytuł_jakgrać.TabIndex = 2;
            this.tytuł_jakgrać.Text = "Jak grać";
            // 
            // przycisk_jakgrać_powrót
            // 
            this.przycisk_jakgrać_powrót.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_jakgrać_powrót.Location = new System.Drawing.Point(19, 372);
            this.przycisk_jakgrać_powrót.Name = "przycisk_jakgrać_powrót";
            this.przycisk_jakgrać_powrót.Size = new System.Drawing.Size(173, 49);
            this.przycisk_jakgrać_powrót.TabIndex = 4;
            this.przycisk_jakgrać_powrót.Text = "powrót";
            this.przycisk_jakgrać_powrót.UseVisualStyleBackColor = true;
            this.przycisk_jakgrać_powrót.Click += new System.EventHandler(this.przycisk_pomoc_powrót_Click);
            // 
            // jak_grać_tekst
            // 
            this.jak_grać_tekst.AutoSize = true;
            this.jak_grać_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jak_grać_tekst.Location = new System.Drawing.Point(16, 64);
            this.jak_grać_tekst.Name = "jak_grać_tekst";
            this.jak_grać_tekst.Size = new System.Drawing.Size(581, 100);
            this.jak_grać_tekst.TabIndex = 5;
            this.jak_grać_tekst.Text = "Po ukazaniu się działania matematycznego wpisujemy odpowiedź\r\ni zatwierdzamy ją k" +
    "lawiszem [ENTER].\r\n\r\nNie trzeba nic klikać myszką!";
            // 
            // jak_grać
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.ControlBox = false;
            this.Controls.Add(this.jak_grać_tekst);
            this.Controls.Add(this.przycisk_jakgrać_powrót);
            this.Controls.Add(this.tytuł_jakgrać);
            this.Name = "jak_grać";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Matematyczny 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytuł_jakgrać;
        private System.Windows.Forms.Button przycisk_jakgrać_powrót;
        private System.Windows.Forms.Label jak_grać_tekst;
    }
}