using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Quiz_Matematyczny_2._0
{
    public partial class rozw_dobrze : Form
    {
        public static string[] rekordy;
        public static decimal punktacja;
        public static string komunikat3;
        public static decimal mnożnik;

        public rozw_dobrze()
        {
            komunikat3 = "";
            rekordy = File.ReadAllLines(@"rekordy.txt");
            if (menu_główne.trudność == 1) mnożnik = 1;
            if (menu_główne.trudność == 2) mnożnik = 2;
            if (menu_główne.trudność == 3) mnożnik = 3;
            punktacja = (100000 - Decimal.Round(Convert.ToDecimal(menu_główne.czas.Elapsed.TotalMilliseconds), 0)) * mnożnik;

            if (punktacja > Convert.ToDecimal(rekordy[1]))
            {
                rekordy[18] = rekordy[16];
                rekordy[19] = rekordy[17];
                rekordy[16] = rekordy[14];
                rekordy[17] = rekordy[15];
                rekordy[14] = rekordy[12];
                rekordy[15] = rekordy[13];
                rekordy[12] = rekordy[10];
                rekordy[13] = rekordy[11];
                rekordy[10] = rekordy[8];
                rekordy[11] = rekordy[9];
                rekordy[8] = rekordy[6];
                rekordy[9] = rekordy[7];
                rekordy[6] = rekordy[4];
                rekordy[7] = rekordy[5];
                rekordy[4] = rekordy[2];
                rekordy[5] = rekordy[3];
                rekordy[2] = rekordy[0];
                rekordy[3] = rekordy[1];
                rekordy[0] = menu_główne.imię;
                rekordy[1] = Convert.ToString(punktacja);
                File.WriteAllLines(@"rekordy.txt", rekordy);
                komunikat3 = "Ponadto ustanawiasz NOWY REKORD, zdobywając " + punktacja + " pkt.!";
            }
            else
            if (punktacja > Convert.ToDecimal(rekordy[3]))
            {
                rekordy[18] = rekordy[16];
                rekordy[19] = rekordy[17];
                rekordy[16] = rekordy[14];
                rekordy[17] = rekordy[15];
                rekordy[14] = rekordy[12];
                rekordy[15] = rekordy[13];
                rekordy[12] = rekordy[10];
                rekordy[13] = rekordy[11];
                rekordy[10] = rekordy[8];
                rekordy[11] = rekordy[9];
                rekordy[8] = rekordy[6];
                rekordy[9] = rekordy[7];
                rekordy[6] = rekordy[4];
                rekordy[7] = rekordy[5];
                rekordy[4] = rekordy[2];
                rekordy[5] = rekordy[3];
                rekordy[2] = menu_główne.imię;
                rekordy[3] = Convert.ToString(punktacja);
                File.WriteAllLines(@"rekordy.txt", rekordy);
                komunikat3 = "Ponadto zajmujesz drugie miejsce, zdobywając " + punktacja + " pkt.!";
            }
            else
            if (punktacja > Convert.ToDecimal(rekordy[5]))
            {
                rekordy[18] = rekordy[16];
                rekordy[19] = rekordy[17];
                rekordy[16] = rekordy[14];
                rekordy[17] = rekordy[15];
                rekordy[14] = rekordy[12];
                rekordy[15] = rekordy[13];
                rekordy[12] = rekordy[10];
                rekordy[13] = rekordy[11];
                rekordy[10] = rekordy[8];
                rekordy[11] = rekordy[9];
                rekordy[8] = rekordy[6];
                rekordy[9] = rekordy[7];
                rekordy[6] = rekordy[4];
                rekordy[7] = rekordy[5];
                rekordy[4] = menu_główne.imię;
                rekordy[5] = Convert.ToString(punktacja);
                File.WriteAllLines(@"rekordy.txt", rekordy);
                komunikat3 = "Ponadto zajmujesz trzecie miejsce, zdobywając " + punktacja + " pkt.!";
            }
            else
            if (punktacja > Convert.ToDecimal(rekordy[7]))
            {
                rekordy[18] = rekordy[16];
                rekordy[19] = rekordy[17];
                rekordy[16] = rekordy[14];
                rekordy[17] = rekordy[15];
                rekordy[14] = rekordy[12];
                rekordy[15] = rekordy[13];
                rekordy[12] = rekordy[10];
                rekordy[13] = rekordy[11];
                rekordy[10] = rekordy[8];
                rekordy[11] = rekordy[9];
                rekordy[8] = rekordy[6];
                rekordy[9] = rekordy[7];
                rekordy[6] = menu_główne.imię;
                rekordy[7] = Convert.ToString(punktacja);
                File.WriteAllLines(@"rekordy.txt", rekordy);
                komunikat3 = "Ponadto zajmujesz czwarte miejsce, zdobywając " + punktacja + " pkt.!";
            }
            else
            if (punktacja > Convert.ToDecimal(rekordy[9]))
            {
                rekordy[18] = rekordy[16];
                rekordy[19] = rekordy[17];
                rekordy[16] = rekordy[14];
                rekordy[17] = rekordy[15];
                rekordy[14] = rekordy[12];
                rekordy[15] = rekordy[13];
                rekordy[12] = rekordy[10];
                rekordy[13] = rekordy[11];
                rekordy[10] = rekordy[8];
                rekordy[11] = rekordy[9];
                rekordy[8] = menu_główne.imię;
                rekordy[9] = Convert.ToString(punktacja);
                File.WriteAllLines(@"rekordy.txt", rekordy);
                komunikat3 = "Ponadto zajmujesz piąte miejsce, zdobywając " + punktacja + " pkt.!";
            }
            else
            if (punktacja > Convert.ToDecimal(rekordy[11]))
            {
                rekordy[18] = rekordy[16];
                rekordy[19] = rekordy[17];
                rekordy[16] = rekordy[14];
                rekordy[17] = rekordy[15];
                rekordy[14] = rekordy[12];
                rekordy[15] = rekordy[13];
                rekordy[12] = rekordy[10];
                rekordy[13] = rekordy[11];
                rekordy[10] = menu_główne.imię;
                rekordy[11] = Convert.ToString(punktacja);
                File.WriteAllLines(@"rekordy.txt", rekordy);
                komunikat3 = "Ponadto zajmujesz szóste miejsce, zdobywając " + punktacja + " pkt.!";
            }
            else
            if (punktacja > Convert.ToDecimal(rekordy[13]))
            {
                rekordy[18] = rekordy[16];
                rekordy[19] = rekordy[17];
                rekordy[16] = rekordy[14];
                rekordy[17] = rekordy[15];
                rekordy[14] = rekordy[12];
                rekordy[15] = rekordy[13];
                rekordy[12] = menu_główne.imię;
                rekordy[13] = Convert.ToString(punktacja);
                File.WriteAllLines(@"rekordy.txt", rekordy);
                komunikat3 = "Ponadto zajmujesz siódme miejsce, zdobywając " + punktacja + " pkt.!";
            }
            else
            if (punktacja > Convert.ToDecimal(rekordy[15]))
            {
                rekordy[18] = rekordy[16];
                rekordy[19] = rekordy[17];
                rekordy[16] = rekordy[14];
                rekordy[17] = rekordy[15];
                rekordy[14] = menu_główne.imię;
                rekordy[15] = Convert.ToString(punktacja);
                File.WriteAllLines(@"rekordy.txt", rekordy);
                komunikat3 = "Ponadto zajmujesz ósme miejsce, zdobywając " + punktacja + " pkt.!";
            }
            else
            if (punktacja > Convert.ToDecimal(rekordy[17]))
            {
                rekordy[18] = rekordy[16];
                rekordy[19] = rekordy[17];
                rekordy[16] = menu_główne.imię;
                rekordy[17] = Convert.ToString(punktacja);
                File.WriteAllLines(@"rekordy.txt", rekordy);
                komunikat3 = "Ponadto zajmujesz dziewiąte miejsce, zdobywając " + punktacja + " pkt.!";
            }
            else
            if (punktacja > Convert.ToDecimal(rekordy[19]))
            {
                rekordy[18] = menu_główne.imię;
                rekordy[19] = Convert.ToString(punktacja);
                File.WriteAllLines(@"rekordy.txt", rekordy);
                komunikat3 = "Ponadto zajmujesz dziesiąte miejsce, zdobywając " + punktacja + " pkt.!";
            }
            else
            {
                komunikat3 = "Zdobywasz " + punktacja + " pkt., jednakże aby zaistnieć w rankingu,\r\nmusisz poradzić sobie szybciej.";
            }

            InitializeComponent();
        }

        private void przycisk_punktacja_powrót_Click(object sender, EventArgs e)
        {
            menu_główne menu_główne = new menu_główne();
            menu_główne.Show();
            this.Hide();
        }
    }
}
