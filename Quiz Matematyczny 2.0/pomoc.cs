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
    public partial class pomoc : Form
    {
        public pomoc()
        {
            InitializeComponent();
        }

        private void przycisk_pomoc_powrót_Click(object sender, EventArgs e)
        {
            menu_główne menu_główne = new menu_główne();
            menu_główne.Show();
            this.Hide();
        }

        private void pomoc_przycisk_jakgrac_Click(object sender, EventArgs e)
        {
            jak_grać jak_grać = new jak_grać();
            jak_grać.Show();
            this.Hide();
        }

        private void pomoc_przycisk_punktacja_Click(object sender, EventArgs e)
        {
            punktacja punktacja = new punktacja();
            punktacja.Show();
            this.Hide();
        }
    }
}
