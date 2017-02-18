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
    public partial class Zadanie_1_3 : Form
    {
        public static int liczba131 = 0, liczba132 = 0, wynik13, odpowiedź13;

        public Zadanie_1_3()
        {

            if (menu_główne.trudność == 1)
            {
                liczba131 = menu_główne.los.Next(1, 10);
                liczba132 = menu_główne.los.Next(1, 10);
                wynik13 = liczba131 + liczba132;
            }

            if (menu_główne.trudność == 2)
            {
                liczba131 = menu_główne.los.Next(10, 30);
                liczba132 = menu_główne.los.Next(10, 30);
                wynik13 = liczba131 + liczba132;
            }

            if (menu_główne.trudność == 3)
            {
                liczba131 = menu_główne.los.Next(30, 100);
                liczba132 = menu_główne.los.Next(30, 100);
                wynik13 = liczba131 + liczba132;
            }

            InitializeComponent();

        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                odpowiedź13 = Int32.Parse(textBox1.Text);

                Zadanie_2_1 Zadanie_2_1 = new Zadanie_2_1();
                Zadanie_2_1.Show();
                this.Hide();
            }
        }
    }
}
