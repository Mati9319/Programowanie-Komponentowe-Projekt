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
    public partial class punktacja : Form
    {
        public punktacja()
        {
            InitializeComponent();
        }

        private void przycisk_punktacja_powrót_Click(object sender, EventArgs e)
        {
            pomoc pomoc = new pomoc();
            pomoc.Show();
            this.Hide();
        }
    }
}
