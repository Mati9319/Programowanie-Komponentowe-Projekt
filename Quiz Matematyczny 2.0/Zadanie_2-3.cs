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
    public partial class Zadanie_2_3 : Form
    {
        public static int liczba231 = 0, liczba232 = 0, wynik23, odpowiedź23;

        public Zadanie_2_3()
        {
            if (menu_główne.trudność == 1)
            {
                liczba231 = menu_główne.los.Next(6, 10);
                liczba232 = menu_główne.los.Next(1, 5);
                wynik23 = liczba231 - liczba232;
            }

            if (menu_główne.trudność == 2)
            {
                liczba231 = menu_główne.los.Next(16, 30);
                liczba232 = menu_główne.los.Next(10, 15);
                wynik23 = liczba231 - liczba232;
            }

            if (menu_główne.trudność == 3)
            {
                liczba231 = menu_główne.los.Next(60, 100);
                liczba232 = menu_główne.los.Next(30, 59);
                wynik23 = liczba231 - liczba232;
            }
            InitializeComponent();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                odpowiedź23 = Int32.Parse(textBox1.Text);

                Zadanie_3_1 Zadanie_3_1 = new Zadanie_3_1();
                Zadanie_3_1.Show();
                this.Hide();
            }
        }
    }
}


