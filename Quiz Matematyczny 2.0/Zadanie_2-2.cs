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
    public partial class Zadanie_2_2 : Form
    {
        public static int liczba221 = 0, liczba222 = 0, wynik22, odpowiedź22;

        public Zadanie_2_2()
        {
            if (menu_główne.trudność == 1)
            {
                liczba221 = menu_główne.los.Next(6, 10);
                liczba222 = menu_główne.los.Next(1, 5);
                wynik22 = liczba221 - liczba222;
            }

            if (menu_główne.trudność == 2)
            {
                liczba221 = menu_główne.los.Next(16, 30);
                liczba222 = menu_główne.los.Next(10, 15);
                wynik22 = liczba221 - liczba222;
            }

            if (menu_główne.trudność == 3)
            {
                liczba221 = menu_główne.los.Next(60, 100);
                liczba222 = menu_główne.los.Next(30, 59);
                wynik22 = liczba221 - liczba222;
            }
            InitializeComponent();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                odpowiedź22 = Int32.Parse(textBox1.Text);

                Zadanie_2_3 Zadanie_2_3 = new Zadanie_2_3();
                Zadanie_2_3.Show();
                this.Hide();
            }
        }
    }
}

