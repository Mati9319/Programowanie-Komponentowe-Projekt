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
    public partial class Zadanie_4_2 : Form
    {
        public static int liczba421 = 0, liczba422 = 0, wynik42, odpowiedź42;

        public Zadanie_4_2()
        {
            if (menu_główne.trudność == 1)
            {
                liczba421 = menu_główne.los.Next(1, 5) * 2;
                liczba422 = 2;
                wynik42 = liczba421 / liczba422;
            }

            if (menu_główne.trudność == 2)
            {
                liczba421 = menu_główne.los.Next(10, 30) * 2;
                liczba422 = 2;
                wynik42 = liczba421 / liczba422;
            }

            if (menu_główne.trudność == 3)
            {
                liczba421 = menu_główne.los.Next(30, 60) * 2;
                liczba422 = 2;
                wynik42 = liczba421 / liczba422;
            }
            InitializeComponent();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                odpowiedź42 = Int32.Parse(textBox1.Text);

                Zadanie_4_3 Zadanie_4_3 = new Zadanie_4_3();
                Zadanie_4_3.Show();
                this.Hide();
            }
        }
    }
}
