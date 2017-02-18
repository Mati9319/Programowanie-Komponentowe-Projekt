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
    public partial class Zadanie_1_1 : Form
    {
        public static int liczba111 = 0, liczba112 = 0, wynik11, odpowiedź11;

        public Zadanie_1_1()
        {
            menu_główne.czas.Reset();
            menu_główne.czas.Start();

            if (menu_główne.trudność == 1)
            {
                liczba111 = menu_główne.los.Next(1, 10);
                liczba112 = menu_główne.los.Next(1, 10);
                wynik11 = liczba111 + liczba112;
            }

            if (menu_główne.trudność == 2)
            {
                liczba111 = menu_główne.los.Next(10, 30);
                liczba112 = menu_główne.los.Next(10, 30);
                wynik11 = liczba111 + liczba112;
            }

            if (menu_główne.trudność == 3)
            {
                liczba111 = menu_główne.los.Next(30, 100);
                liczba112 = menu_główne.los.Next(30, 100);
                wynik11 = liczba111 + liczba112;
            }

            InitializeComponent();

        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                odpowiedź11 = Int32.Parse(textBox1.Text);

                Zadanie_1_2 Zadanie_1_2 = new Zadanie_1_2();
                Zadanie_1_2.Show();
                this.Hide();
            }
        }

    }
}
