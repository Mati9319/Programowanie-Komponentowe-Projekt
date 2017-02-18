namespace Quiz_Matematyczny_2._0
{
    partial class reset_potw
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
            this.jak_grać_tekst = new System.Windows.Forms.Label();
            this.przycisk_start = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jak_grać_tekst
            // 
            this.jak_grać_tekst.AutoSize = true;
            this.jak_grać_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jak_grać_tekst.Location = new System.Drawing.Point(46, 23);
            this.jak_grać_tekst.Name = "jak_grać_tekst";
            this.jak_grać_tekst.Size = new System.Drawing.Size(351, 25);
            this.jak_grać_tekst.TabIndex = 6;
            this.jak_grać_tekst.Text = "Na pewno chcesz zresetować ranking?";
            // 
            // przycisk_start
            // 
            this.przycisk_start.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_start.Location = new System.Drawing.Point(277, 92);
            this.przycisk_start.Name = "przycisk_start";
            this.przycisk_start.Size = new System.Drawing.Size(173, 49);
            this.przycisk_start.TabIndex = 7;
            this.przycisk_start.Text = "Nie";
            this.przycisk_start.UseVisualStyleBackColor = true;
            this.przycisk_start.Click += new System.EventHandler(this.przycisk_start_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(12, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reset_potw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 153);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.przycisk_start);
            this.Controls.Add(this.jak_grać_tekst);
            this.Name = "reset_potw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Matematyczny 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jak_grać_tekst;
        private System.Windows.Forms.Button przycisk_start;
        private System.Windows.Forms.Button button1;
    }
}