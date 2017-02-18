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
    public partial class Zadanie_2_1 : Form
    {
        public static int liczba211 = 0, liczba212 = 0, wynik21, odpowiedź21;

        public Zadanie_2_1()
        {
            if (menu_główne.trudność == 1)
            {
                liczba211 = menu_główne.los.Next(6, 10);
                liczba212 = menu_główne.los.Next(1, 5);
                wynik21 = liczba211 - liczba212;
            }

            if (menu_główne.trudność == 2)
            {
                liczba211 = menu_główne.los.Next(16, 30);
                liczba212 = menu_główne.los.Next(10, 15);
                wynik21 = liczba211 - liczba212;
            }

            if (menu_główne.trudność == 3)
            {
                liczba211 = menu_główne.los.Next(60, 100);
                liczba212 = menu_główne.los.Next(30, 59);
                wynik21 = liczba211 - liczba212;
            }
            InitializeComponent();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                odpowiedź21 = Int32.Parse(textBox1.Text);

                Zadanie_2_2 Zadanie_2_2 = new Zadanie_2_2();
                Zadanie_2_2.Show();
                this.Hide();
            }
        }
    }
}
