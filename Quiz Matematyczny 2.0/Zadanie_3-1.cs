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
    public partial class Zadanie_3_1 : Form
    {
        public static int liczba311 = 0, liczba312 = 0, wynik31, odpowiedź31;

        public Zadanie_3_1()
        {
            if (menu_główne.trudność == 1)
            {
                liczba311 = menu_główne.los.Next(1, 9);
                liczba312 = menu_główne.los.Next(1, 9);
                wynik31 = liczba311 * liczba312;
            }

            if (menu_główne.trudność == 2)
            {
                liczba311 = menu_główne.los.Next(5, 9);
                liczba312 = menu_główne.los.Next(10, 15);
                wynik31 = liczba311 * liczba312;
            }

            if (menu_główne.trudność == 3)
            {
                liczba311 = menu_główne.los.Next(5, 9);
                liczba312 = menu_główne.los.Next(30, 50);
                wynik31 = liczba311 * liczba312;
            }
            InitializeComponent();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                odpowiedź31 = Int32.Parse(textBox1.Text);

                Zadanie_3_2 Zadanie_3_2 = new Zadanie_3_2();
                Zadanie_3_2.Show();
                this.Hide();
            }
        }
    }
}
