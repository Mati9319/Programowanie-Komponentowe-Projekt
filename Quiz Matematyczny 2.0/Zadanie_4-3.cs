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
    public partial class Zadanie_4_3 : Form
    {
        public static int liczba431 = 0, liczba432 = 0, wynik43, odpowiedź43;

        public Zadanie_4_3()
        {
            if (menu_główne.trudność == 1)
            {
                liczba431 = menu_główne.los.Next(1, 5) * 2;
                liczba432 = 2;
                wynik43 = liczba431 / liczba432;
            }

            if (menu_główne.trudność == 2)
            {
                liczba431 = menu_główne.los.Next(10, 30) * 2;
                liczba432 = 2;
                wynik43 = liczba431 / liczba432;
            }

            if (menu_główne.trudność == 3)
            {
                liczba431 = menu_główne.los.Next(30, 60) * 2;
                liczba432 = 2;
                wynik43 = liczba431 / liczba432;
            }
            InitializeComponent();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                menu_główne.czas.Stop();
                odpowiedź43 = Int32.Parse(textBox1.Text);
                if (Zadanie_1_1.odpowiedź11 == Zadanie_1_1.wynik11 && Zadanie_1_2.odpowiedź12 == Zadanie_1_2.wynik12 && Zadanie_1_3.odpowiedź13 == Zadanie_1_3.wynik13 && Zadanie_2_1.odpowiedź21 == Zadanie_2_1.wynik21 && Zadanie_2_2.odpowiedź22 == Zadanie_2_2.wynik22 && Zadanie_2_3.odpowiedź23 == Zadanie_2_3.wynik23 && Zadanie_3_1.odpowiedź31 == Zadanie_3_1.wynik31 && Zadanie_3_2.odpowiedź32 == Zadanie_3_2.wynik32 && Zadanie_3_3.odpowiedź33 == Zadanie_3_3.wynik33 && Zadanie_4_1.odpowiedź41 == Zadanie_4_1.wynik41 && Zadanie_4_2.odpowiedź42 == Zadanie_4_2.wynik42 && Zadanie_4_3.odpowiedź43 == Zadanie_4_3.wynik43)
                {
                    rozw_dobrze rozw_dobrze = new rozw_dobrze();
                    rozw_dobrze.Show();
                    this.Hide();
                }
                else
                {
                    rozw_źle rozw_źle = new rozw_źle();
                    rozw_źle.Show();
                    this.Hide();
                }
            }
        }
    }
}
