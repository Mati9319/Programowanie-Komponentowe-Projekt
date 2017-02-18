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
    public partial class rozw_źle : Form
    {
        public static int błędy;
        public static string komunikat1;
        public static string komunikat2;

        public rozw_źle()
        {
            błędy = 0;
            komunikat2 = "";
            if (Zadanie_1_1.odpowiedź11 != Zadanie_1_1.wynik11)
            {
                błędy = błędy + 1;
                komunikat2 = komunikat2 + Zadanie_1_1.liczba111 + " + " + Zadanie_1_1.liczba112 + " to nie " + Zadanie_1_1.odpowiedź11 + ", tylko " + Zadanie_1_1.wynik11 + "\r\n";
            }
            if (Zadanie_1_2.odpowiedź12 != Zadanie_1_2.wynik12)
            {
                błędy = błędy + 1;
                komunikat2 = komunikat2 + Zadanie_1_2.liczba121 + " + " + Zadanie_1_2.liczba122 + " to nie " + Zadanie_1_2.odpowiedź12 + ", tylko " + Zadanie_1_2.wynik12 + "\r\n";
            }
            if (Zadanie_1_3.odpowiedź13 != Zadanie_1_3.wynik13)
            {
                błędy = błędy + 1;
                komunikat2 = komunikat2 + Zadanie_1_3.liczba131 + " + " + Zadanie_1_3.liczba132 + " to nie " + Zadanie_1_3.odpowiedź13 + ", tylko " + Zadanie_1_3.wynik13 + "\r\n";
            }
            if (Zadanie_2_1.odpowiedź21 != Zadanie_2_1.wynik21)
            {
                błędy = błędy + 1;
                komunikat2 = komunikat2 + Zadanie_2_1.liczba211 + " - " + Zadanie_2_1.liczba212 + " to nie " + Zadanie_2_1.odpowiedź21 + ", tylko " + Zadanie_2_1.wynik21 + "\r\n";
            }
            if (Zadanie_2_2.odpowiedź22 != Zadanie_2_2.wynik22)
            {
                błędy = błędy + 1;
                komunikat2 = komunikat2 + Zadanie_2_2.liczba221 + " - " + Zadanie_2_2.liczba222 + " to nie " + Zadanie_2_2.odpowiedź22 + ", tylko " + Zadanie_2_2.wynik22 + "\r\n";
            }
            if (Zadanie_2_3.odpowiedź23 != Zadanie_2_3.wynik23)
            {
                błędy = błędy + 1;
                komunikat2 = komunikat2 + Zadanie_2_3.liczba231 + " - " + Zadanie_2_3.liczba232 + " to nie " + Zadanie_2_3.odpowiedź23 + ", tylko " + Zadanie_2_3.wynik23 + "\r\n";
            }
            if (Zadanie_3_1.odpowiedź31 != Zadanie_3_1.wynik31)
            {
                błędy = błędy + 1;
                komunikat2 = komunikat2 + Zadanie_3_1.liczba311 + " * " + Zadanie_3_1.liczba312 + " to nie " + Zadanie_3_1.odpowiedź31 + ", tylko " + Zadanie_3_1.wynik31 + "\r\n";
            }
            if (Zadanie_3_2.odpowiedź32 != Zadanie_3_2.wynik32)
            {
                błędy = błędy + 1;
                komunikat2 = komunikat2 + Zadanie_3_2.liczba321 + " * " + Zadanie_3_2.liczba322 + " to nie " + Zadanie_3_2.odpowiedź32 + ", tylko " + Zadanie_3_2.wynik32 + "\r\n";
            }
            if (Zadanie_3_3.odpowiedź33 != Zadanie_3_3.wynik33)
            {
                błędy = błędy + 1;
                komunikat2 = komunikat2 + Zadanie_3_3.liczba331 + " * " + Zadanie_3_3.liczba332 + " to nie " + Zadanie_3_3.odpowiedź33 + ", tylko " + Zadanie_3_3.wynik33 + "\r\n";
            }
            if (Zadanie_4_1.odpowiedź41 != Zadanie_4_1.wynik41)
            {
                błędy = błędy + 1;
                komunikat2 = komunikat2 + Zadanie_4_1.liczba411 + " / " + Zadanie_4_1.liczba412 + " to nie " + Zadanie_4_1.odpowiedź41 + ", tylko " + Zadanie_4_1.wynik41 + "\r\n";
            }
            if (Zadanie_4_2.odpowiedź42 != Zadanie_4_2.wynik42)
            {
                błędy = błędy + 1;
                komunikat2 = komunikat2 + Zadanie_4_2.liczba421 + " / " + Zadanie_4_2.liczba422 + " to nie " + Zadanie_4_2.odpowiedź42 + ", tylko " + Zadanie_4_2.wynik42 + "\r\n";
            }
            if (Zadanie_4_3.odpowiedź43 != Zadanie_4_3.wynik43)
            {
                błędy = błędy + 1;
                komunikat2 = komunikat2 + Zadanie_4_3.liczba431 + " / " + Zadanie_4_3.liczba432 + " to nie " + Zadanie_4_3.odpowiedź43 + ", tylko " + Zadanie_4_3.wynik43 + "\r\n";
            }

            if (błędy == 1)
            {
                komunikat1 = "Niestety nie udało Ci się poprawnie odpowiedzieć na wszystkie\r\npytania. Masz " + błędy + " błędną odpowiedź:";
            }
            if (błędy > 1 && błędy < 5)
            {
                komunikat1 = "Niestety nie udało Ci się poprawnie odpowiedzieć na wszystkie\r\npytania. Masz " + błędy + " błędne odpowiedzi:";
            }
            if (błędy > 4)
            {
                komunikat1 = "Niestety nie udało Ci się poprawnie odpowiedzieć na wszystkie\r\npytania. Masz " + błędy + " błędnych odpowiedzi:";
            }

            InitializeComponent();
        }

        private void przycisk_jakgrać_powrót_Click(object sender, EventArgs e)
        {
            menu_główne menu_główne = new menu_główne();
            menu_główne.Show();
            this.Hide();
        }
    }
}
