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
    public partial class Zadanie_3_3 : Form
    {
        public static int liczba331 = 0, liczba332 = 0, wynik33, odpowiedź33;

        public Zadanie_3_3()
        {
            if (menu_główne.trudność == 1)
            {
                liczba331 = menu_główne.los.Next(1, 9);
                liczba332 = menu_główne.los.Next(1, 9);
                wynik33 = liczba331 * liczba332;
            }

            if (menu_główne.trudność == 2)
            {
                liczba331 = menu_główne.los.Next(5, 9);
                liczba332 = menu_główne.los.Next(10, 15);
                wynik33 = liczba331 * liczba332;
            }

            if (menu_główne.trudność == 3)
            {
                liczba331 = menu_główne.los.Next(5, 9);
                liczba332 = menu_główne.los.Next(30, 50);
                wynik33 = liczba331 * liczba332;
            }
            InitializeComponent();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                odpowiedź33 = Int32.Parse(textBox1.Text);

                Zadanie_4_1 Zadanie_4_1 = new Zadanie_4_1();
                Zadanie_4_1.Show();
                this.Hide();
            }
        }
    }
}
