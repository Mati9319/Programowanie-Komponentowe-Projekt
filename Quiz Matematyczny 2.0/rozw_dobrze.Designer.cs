namespace Quiz_Matematyczny_2._0
{
    partial class rozw_dobrze
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
            this.tytuł = new System.Windows.Forms.Label();
            this.przycisk_punktacja_powrót = new System.Windows.Forms.Button();
            this.tekst = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tytuł
            // 
            this.tytuł.AutoSize = true;
            this.tytuł.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytuł.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tytuł.Location = new System.Drawing.Point(79, 9);
            this.tytuł.Name = "tytuł";
            this.tytuł.Size = new System.Drawing.Size(443, 98);
            this.tytuł.TabIndex = 1;
            this.tytuł.Text = "GRATULACJE!";
            // 
            // przycisk_punktacja_powrót
            // 
            this.przycisk_punktacja_powrót.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_punktacja_powrót.Location = new System.Drawing.Point(19, 372);
            this.przycisk_punktacja_powrót.Name = "przycisk_punktacja_powrót";
            this.przycisk_punktacja_powrót.Size = new System.Drawing.Size(173, 49);
            this.przycisk_punktacja_powrót.TabIndex = 6;
            this.przycisk_punktacja_powrót.Text = "powrót";
            this.przycisk_punktacja_powrót.UseVisualStyleBackColor = true;
            this.przycisk_punktacja_powrót.Click += new System.EventHandler(this.przycisk_punktacja_powrót_Click);
            // 
            // tekst
            // 
            this.tekst.AutoSize = true;
            this.tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tekst.Location = new System.Drawing.Point(40, 126);
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(526, 25);
            this.tekst.TabIndex = 7;
            this.tekst.Text = "Udało Ci się odpowiedzieć poprawnie na wszystkie pytania!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(40, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = komunikat3;
            // 
            // rozw_dobrze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tekst);
            this.Controls.Add(this.przycisk_punktacja_powrót);
            this.Controls.Add(this.tytuł);
            this.Name = "rozw_dobrze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Matematyczny 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytuł;
        private System.Windows.Forms.Button przycisk_punktacja_powrót;
        private System.Windows.Forms.Label tekst;
        private System.Windows.Forms.Label label1;
    }
}