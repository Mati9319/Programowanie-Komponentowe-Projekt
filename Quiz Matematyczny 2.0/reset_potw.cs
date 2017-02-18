using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Quiz_Matematyczny_2._0
{
    public partial class reset_potw : Form
    {
        public static string[] rekordy;

        public reset_potw()
        {
            InitializeComponent();
        }

        private void przycisk_start_Click(object sender, EventArgs e)
        {
            ranking ranking = new ranking();
            ranking.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rekordy = File.ReadAllLines(@"rekordy.txt");

            rekordy[0] = "AAA";
            rekordy[1] = "0";
            rekordy[2] = "AAA";
            rekordy[3] = "0";
            rekordy[4] = "AAA";
            rekordy[5] = "0";
            rekordy[6] = "AAA";
            rekordy[7] = "0";
            rekordy[8] = "AAA";
            rekordy[9] = "0";
            rekordy[10] = "AAA";
            rekordy[11] = "0";
            rekordy[12] = "AAA";
            rekordy[13] = "0";
            rekordy[14] = "AAA";
            rekordy[15] = "0";
            rekordy[16] = "AAA";
            rekordy[17] = "0";
            rekordy[18] = "AAA";
            rekordy[19] = "0";

            File.WriteAllLines(@"rekordy.txt", rekordy);

            ranking ranking = new ranking();
            ranking.Show();
            this.Hide();
        }
    }
}
