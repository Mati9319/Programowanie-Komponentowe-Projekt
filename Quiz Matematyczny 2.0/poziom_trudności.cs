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
    public partial class poziom_trudności : Form
    {
        public poziom_trudności()
        {
            InitializeComponent();
        }

        private void przycisk_łatwy_Click(object sender, EventArgs e)
        {
            menu_główne.trudność = 1;

            podaj_imię podaj_imię = new podaj_imię();
            podaj_imię.Show();
            this.Hide();
        }

        private void przycisk_średni_Click(object sender, EventArgs e)
        {
            menu_główne.trudność = 2;

            podaj_imię podaj_imię = new podaj_imię();
            podaj_imię.Show();
            this.Hide();
        }

        private void poziom_trudny_Click(object sender, EventArgs e)
        {
            menu_główne.trudność = 3;

            podaj_imię podaj_imię = new podaj_imię();
            podaj_imię.Show();
            this.Hide();
        }
    }
}
