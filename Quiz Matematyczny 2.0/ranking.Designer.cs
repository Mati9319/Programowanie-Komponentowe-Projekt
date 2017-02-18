using System;
using System.IO;
using System.Diagnostics;

namespace Quiz_Matematyczny_2._0
{
    partial class ranking
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
            var rekordy = File.ReadAllLines(@"rekordy.txt");
            this.tytuł_ranking = new System.Windows.Forms.Label();
            this.przycisk_ranking_powrót = new System.Windows.Forms.Button();
            this.ranking_ranking = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tytuł_ranking
            // 
            this.tytuł_ranking.AutoSize = true;
            this.tytuł_ranking.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytuł_ranking.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tytuł_ranking.Location = new System.Drawing.Point(12, 9);
            this.tytuł_ranking.Name = "tytuł_ranking";
            this.tytuł_ranking.Size = new System.Drawing.Size(136, 37);
            this.tytuł_ranking.TabIndex = 1;
            this.tytuł_ranking.Text = "Ranking";
            // 
            // przycisk_ranking_powrót
            // 
            this.przycisk_ranking_powrót.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_ranking_powrót.Location = new System.Drawing.Point(19, 372);
            this.przycisk_ranking_powrót.Name = "przycisk_ranking_powrót";
            this.przycisk_ranking_powrót.Size = new System.Drawing.Size(173, 49);
            this.przycisk_ranking_powrót.TabIndex = 2;
            this.przycisk_ranking_powrót.Text = "powrót";
            this.przycisk_ranking_powrót.UseVisualStyleBackColor = true;
            this.przycisk_ranking_powrót.Click += new System.EventHandler(this.przycisk_ranking_powrót_Click);
            // 
            // ranking_ranking
            // 
            this.ranking_ranking.AutoSize = true;
            this.ranking_ranking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ranking_ranking.Location = new System.Drawing.Point(16, 64);
            this.ranking_ranking.Name = "ranking_ranking";
            this.ranking_ranking.Size = new System.Drawing.Size(35, 25);
            this.ranking_ranking.TabIndex = 3;
            this.ranking_ranking.Text = "1) " + rekordy[0] + " " + rekordy[1] + " p.\r\n2) " + rekordy[2] + " " + rekordy[3] + " p.\r\n3) " + rekordy[4] + " " + rekordy[5] + " p.\r\n4) " + rekordy[6] + " " + rekordy[7] + " p.\r\n5) " + rekordy[8] + " " + rekordy[9] + " p.\r\n6) " + rekordy[10] + " " + rekordy[11] + " p.\r\n7) " + rekordy[12] + " " + rekordy[13] + " p.\r\n8) " + rekordy[14] + " " + rekordy[15] + " p.\r\n9) " + rekordy[16] + " " + rekordy[17] + " p.\r\n10) " + rekordy[18] + " " + rekordy[19] + " p.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(227, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ranking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ranking_ranking);
            this.Controls.Add(this.przycisk_ranking_powrót);
            this.Controls.Add(this.tytuł_ranking);
            this.Name = "ranking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Matematyczny 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytuł_ranking;
        private System.Windows.Forms.Button przycisk_ranking_powrót;
        private System.Windows.Forms.Label ranking_ranking;
        private System.Windows.Forms.Button button1;
    }
}