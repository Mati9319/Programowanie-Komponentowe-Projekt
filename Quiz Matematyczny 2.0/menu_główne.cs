using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Quiz_Matematyczny_2._0
{
    public partial class menu_główne : Form
    {


        public static string imię;

        public static Stopwatch czas = new Stopwatch();

        public static Random los = new Random();

        public static int trudność;
        
        public menu_główne()
        {
            InitializeComponent();
        }

        private void przycisk_wyjście_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void przycisk_ranking_Click(object sender, EventArgs e)
        {
            ranking ranking = new ranking();
            ranking.Show();
            this.Hide();
        }

        private void przycisk_pomoc_Click(object sender, EventArgs e)
        {
            pomoc pomoc = new pomoc();
            pomoc.Show();
            this.Hide();
        }

        private void przycisk_start_Click(object sender, EventArgs e)
        {
            poziom_trudności poziom_trudności = new poziom_trudności();
            poziom_trudności.Show();
            this.Hide();
        }
    }
}
