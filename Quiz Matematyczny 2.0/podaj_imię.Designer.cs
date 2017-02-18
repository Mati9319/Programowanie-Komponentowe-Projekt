namespace Quiz_Matematyczny_2._0
{
    partial class podaj_imię
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
            this.podaj_imię_tytuł = new System.Windows.Forms.Label();
            this.pole_imię = new System.Windows.Forms.TextBox();
            this.podaj_imię_ost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // podaj_imię_tytuł
            // 
            this.podaj_imię_tytuł.AutoSize = true;
            this.podaj_imię_tytuł.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podaj_imię_tytuł.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.podaj_imię_tytuł.Location = new System.Drawing.Point(228, 153);
            this.podaj_imię_tytuł.Name = "podaj_imię_tytuł";
            this.podaj_imię_tytuł.Size = new System.Drawing.Size(167, 37);
            this.podaj_imię_tytuł.TabIndex = 1;
            this.podaj_imię_tytuł.Text = "Podaj imię";
            // 
            // pole_imię
            // 
            this.pole_imię.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pole_imię.Location = new System.Drawing.Point(224, 211);
            this.pole_imię.Name = "pole_imię";
            this.pole_imię.Size = new System.Drawing.Size(171, 30);
            this.pole_imię.TabIndex = 2;
            this.pole_imię.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pole_imię_KeyDown);
            // 
            // podaj_imię_ost
            // 
            this.podaj_imię_ost.AutoSize = true;
            this.podaj_imię_ost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podaj_imię_ost.Location = new System.Drawing.Point(108, 267);
            this.podaj_imię_ost.Name = "podaj_imię_ost";
            this.podaj_imię_ost.Size = new System.Drawing.Size(407, 50);
            this.podaj_imię_ost.TabIndex = 3;
            this.podaj_imię_ost.Text = "         Pierwsze pytanie ukaże się od razu\r\npo zatwierdzeniu imienia klawiszem [" +
    "ENTER].";
            // 
            // podaj_imię
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.ControlBox = false;
            this.Controls.Add(this.podaj_imię_ost);
            this.Controls.Add(this.pole_imię);
            this.Controls.Add(this.podaj_imię_tytuł);
            this.Name = "podaj_imię";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Matematyczny 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label podaj_imię_tytuł;
        private System.Windows.Forms.TextBox pole_imię;
        private System.Windows.Forms.Label podaj_imię_ost;
    }
}