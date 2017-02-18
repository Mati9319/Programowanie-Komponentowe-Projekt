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
    public partial class Zadanie_3_2 : Form
    {
        public static int liczba321 = 0, liczba322 = 0, wynik32, odpowiedź32;

        public Zadanie_3_2()
        {
            if (menu_główne.trudność == 1)
            {
                liczba321 = menu_główne.los.Next(1, 9);
                liczba322 = menu_główne.los.Next(1, 9);
                wynik32 = liczba321 * liczba322;
            }

            if (menu_główne.trudność == 2)
            {
                liczba321 = menu_główne.los.Next(5, 9);
                liczba322 = menu_główne.los.Next(10, 15);
                wynik32 = liczba321 * liczba322;
            }

            if (menu_główne.trudność == 3)
            {
                liczba321 = menu_główne.los.Next(5, 9);
                liczba322 = menu_główne.los.Next(30, 50);
                wynik32 = liczba321 * liczba322;
            }
            InitializeComponent();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                odpowiedź32 = Int32.Parse(textBox1.Text);

                Zadanie_3_3 Zadanie_3_3 = new Zadanie_3_3();
                Zadanie_3_3.Show();
                this.Hide();
            }
        }
    }
}
