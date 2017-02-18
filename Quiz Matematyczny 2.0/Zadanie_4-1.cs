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
    public partial class Zadanie_4_1 : Form
    {
        public static int liczba411 = 0, liczba412 = 0, wynik41, odpowiedź41;

        public Zadanie_4_1()
        {
            if (menu_główne.trudność == 1)
            {
                liczba411 = menu_główne.los.Next(1, 5)*2;
                liczba412 = 2;
                wynik41 = liczba411 / liczba412;
            }

            if (menu_główne.trudność == 2)
            {
                liczba411 = menu_główne.los.Next(10, 30)*2;
                liczba412 = 2;
                wynik41 = liczba411 / liczba412;
            }

            if (menu_główne.trudność == 3)
            {
                liczba411 = menu_główne.los.Next(30, 60)*2;
                liczba412 = 2;
                wynik41 = liczba411 / liczba412;
            }
            InitializeComponent();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                odpowiedź41 = Int32.Parse(textBox1.Text);

                Zadanie_4_2 Zadanie_4_2 = new Zadanie_4_2();
                Zadanie_4_2.Show();
                this.Hide();
            }
        }
    }
}
