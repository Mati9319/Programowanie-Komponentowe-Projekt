using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Matematyczny_2._0
{
    public partial class ranking : Form
    {
        public ranking()
        {
            InitializeComponent();
        }

        private void przycisk_ranking_powrót_Click(object sender, EventArgs e)
        {
            menu_główne menu_główne = new menu_główne();
            menu_główne.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset_potw reset_potw = new reset_potw();
            reset_potw.Show();
            this.Hide();
        }
    }
}
