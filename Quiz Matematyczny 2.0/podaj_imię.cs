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
    public partial class podaj_imię : Form
    {
        public podaj_imię()
        {
            InitializeComponent();
        }

        private void pole_imię_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                menu_główne.imię = pole_imię.Text;

                Zadanie_1_1 Zadanie_1_1 = new Zadanie_1_1();
                Zadanie_1_1.Show();
                this.Hide();
            }
        }
    }
}
