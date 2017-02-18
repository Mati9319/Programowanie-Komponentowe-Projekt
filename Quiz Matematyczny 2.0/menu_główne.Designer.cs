namespace Quiz_Matematyczny_2._0
{
    partial class menu_główne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu_główne));
            this.tytuł = new System.Windows.Forms.Label();
            this.przycisk_start = new System.Windows.Forms.Button();
            this.przycisk_ranking = new System.Windows.Forms.Button();
            this.przycisk_pomoc = new System.Windows.Forms.Button();
            this.przycisk_wyjście = new System.Windows.Forms.Button();
            this.autor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tytuł
            // 
            this.tytuł.AutoSize = true;
            this.tytuł.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tytuł.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tytuł.Location = new System.Drawing.Point(12, 9);
            this.tytuł.Name = "tytuł";
            this.tytuł.Size = new System.Drawing.Size(348, 37);
            this.tytuł.TabIndex = 0;
            this.tytuł.Text = "Quiz Matematyczny 2.0";
            // 
            // przycisk_start
            // 
            this.przycisk_start.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_start.Location = new System.Drawing.Point(19, 83);
            this.przycisk_start.Name = "przycisk_start";
            this.przycisk_start.Size = new System.Drawing.Size(173, 49);
            this.przycisk_start.TabIndex = 1;
            this.przycisk_start.Text = "Start";
            this.przycisk_start.UseVisualStyleBackColor = true;
            this.przycisk_start.Click += new System.EventHandler(this.przycisk_start_Click);
            // 
            // przycisk_ranking
            // 
            this.przycisk_ranking.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_ranking.Location = new System.Drawing.Point(19, 138);
            this.przycisk_ranking.Name = "przycisk_ranking";
            this.przycisk_ranking.Size = new System.Drawing.Size(173, 49);
            this.przycisk_ranking.TabIndex = 2;
            this.przycisk_ranking.Text = "Ranking";
            this.przycisk_ranking.UseVisualStyleBackColor = true;
            this.przycisk_ranking.Click += new System.EventHandler(this.przycisk_ranking_Click);
            // 
            // przycisk_pomoc
            // 
            this.przycisk_pomoc.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_pomoc.Location = new System.Drawing.Point(19, 193);
            this.przycisk_pomoc.Name = "przycisk_pomoc";
            this.przycisk_pomoc.Size = new System.Drawing.Size(173, 49);
            this.przycisk_pomoc.TabIndex = 3;
            this.przycisk_pomoc.Text = "Pomoc";
            this.przycisk_pomoc.UseVisualStyleBackColor = true;
            this.przycisk_pomoc.Click += new System.EventHandler(this.przycisk_pomoc_Click);
            // 
            // przycisk_wyjście
            // 
            this.przycisk_wyjście.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przycisk_wyjście.Location = new System.Drawing.Point(19, 248);
            this.przycisk_wyjście.Name = "przycisk_wyjście";
            this.przycisk_wyjście.Size = new System.Drawing.Size(173, 49);
            this.przycisk_wyjście.TabIndex = 4;
            this.przycisk_wyjście.Text = "Wyjście";
            this.przycisk_wyjście.UseVisualStyleBackColor = true;
            this.przycisk_wyjście.Click += new System.EventHandler(this.przycisk_wyjście_Click);
            // 
            // autor
            // 
            this.autor.AutoSize = true;
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.autor.Location = new System.Drawing.Point(352, 399);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(258, 25);
            this.autor.TabIndex = 5;
            this.autor.Text = "Autor: Mateusz Rzempołuch";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 331);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // menu_główne
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.autor);
            this.Controls.Add(this.przycisk_wyjście);
            this.Controls.Add(this.przycisk_pomoc);
            this.Controls.Add(this.przycisk_ranking);
            this.Controls.Add(this.przycisk_start);
            this.Controls.Add(this.tytuł);
            this.Name = "menu_główne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Matematyczny 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytuł;
        private System.Windows.Forms.Button przycisk_start;
        private System.Windows.Forms.Button przycisk_ranking;
        private System.Windows.Forms.Button przycisk_pomoc;
        private System.Windows.Forms.Button przycisk_wyjście;
        private System.Windows.Forms.Label autor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

