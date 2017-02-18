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
using System.IO;

namespace Quiz_Matematyczny_2._0
{
    public partial class Zadanie_1_2 : Form
    {
        public static int liczba121 = 0, liczba122 = 0, wynik12, odpowiedź12;

        public Zadanie_1_2()
        {
            if (menu_główne.trudność == 1)
            {
                liczba121 = menu_główne.los.Next(1, 10);
                liczba122 = menu_główne.los.Next(1, 10);
                wynik12 = liczba121 + liczba122;
            }

            if (menu_główne.trudność == 2)
            {
                liczba121 = menu_główne.los.Next(10, 30);
                liczba122 = menu_główne.los.Next(10, 30);
                wynik12 = liczba121 + liczba122;
            }

            if (menu_główne.trudność == 3)
            {
                liczba121 = menu_główne.los.Next(30, 100);
                liczba122 = menu_główne.los.Next(30, 100);
                wynik12 = liczba121 + liczba122;
            }

            InitializeComponent();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                odpowiedź12 = Int32.Parse(textBox1.Text);

                Zadanie_1_3 Zadanie_1_3 = new Zadanie_1_3();
                Zadanie_1_3.Show();
                this.Hide();
            }
        }
    }
}
