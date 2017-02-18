namespace Quiz_Matematyczny_2._0
{
    partial class poziom_trudności
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
            this.poziom_trudności_tytuł = new System.Windows.Forms.Label();
            this.przycisk_łatwy = new System.Windows.Forms.Button();
            this.przycisk_średni = new System.Windows.Forms.Button();
            this.poziom_trudny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poziom_trudności_tytuł
            // 
            this.poziom_trudności_tytuł.AutoSize = true;
            this.poziom_trudności_tytuł.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poziom_trudności_tytuł.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.poziom_trudności_tytuł.Location = new System.Drawing.Point(116, 144);
            this.poziom_trudności_tytuł.Name = "poziom_trudności_tytuł";
            this.poziom_trudności_tytuł.Size = new System.Drawing.Size(387, 37);
            this.poziom_trudności_tytuł.TabIndex = 2;
            this.poziom_trudności_tytuł.Text = "Wybierz poziom trudności";
            // 
            // przycisk_łatwy
            // 
            this.przycisk_łatwy.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_łatwy.Location = new System.Drawing.Point(38, 217);
            this.przycisk_łatwy.Name = "przycisk_łatwy";
            this.przycisk_łatwy.Size = new System.Drawing.Size(173, 49);
            this.przycisk_łatwy.TabIndex = 3;
            this.przycisk_łatwy.Text = "Łatwy";
            this.przycisk_łatwy.UseVisualStyleBackColor = true;
            this.przycisk_łatwy.Click += new System.EventHandler(this.przycisk_łatwy_Click);
            // 
            // przycisk_średni
            // 
            this.przycisk_średni.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_średni.Location = new System.Drawing.Point(217, 217);
            this.przycisk_średni.Name = "przycisk_średni";
            this.przycisk_średni.Size = new System.Drawing.Size(173, 49);
            this.przycisk_średni.TabIndex = 4;
            this.przycisk_średni.Text = "Średni";
            this.przycisk_średni.UseVisualStyleBackColor = true;
            this.przycisk_średni.Click += new System.EventHandler(this.przycisk_średni_Click);
            // 
            // poziom_trudny
            // 
            this.poziom_trudny.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poziom_trudny.Location = new System.Drawing.Point(396, 217);
            this.poziom_trudny.Name = "poziom_trudny";
            this.poziom_trudny.Size = new System.Drawing.Size(173, 49);
            this.poziom_trudny.TabIndex = 5;
            this.poziom_trudny.Text = "Trudny";
            this.poziom_trudny.UseVisualStyleBackColor = true;
            this.poziom_trudny.Click += new System.EventHandler(this.poziom_trudny_Click);
            // 
            // poziom_trudności
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.ControlBox = false;
            this.Controls.Add(this.poziom_trudny);
            this.Controls.Add(this.przycisk_średni);
            this.Controls.Add(this.przycisk_łatwy);
            this.Controls.Add(this.poziom_trudności_tytuł);
            this.Name = "poziom_trudności";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Matematyczny 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label poziom_trudności_tytuł;
        private System.Windows.Forms.Button przycisk_łatwy;
        private System.Windows.Forms.Button przycisk_średni;
        private System.Windows.Forms.Button poziom_trudny;
    }
}