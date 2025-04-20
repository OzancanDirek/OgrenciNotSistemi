using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanliMimariProje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void BtnOgrenci_Click(object sender, EventArgs e)
        {
            FrmOgrenci fr = new FrmOgrenci();
            fr.Show();
        }

        private void BtnDersler_Click(object sender, EventArgs e)
        {
            Notlar fr = new Notlar();
            fr.Show();
        }

        private void BtnDersler_Click_1(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }
    }
}
