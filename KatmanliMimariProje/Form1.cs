using BusinessLayer;
using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanliMimariProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void reset()
        {
            TxtAd.Clear();
            TxtID.Clear();
        }

        public void list()
        {
            List<EntityDers> ders = BLDers.DersListeliBL();
            dataGridView1.DataSource = ders;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            EntityDers ders = new EntityDers();
            try
            {
                
                if(TxtID.Text == null)
                {
                    MessageBox.Show("Kayıt Yaparken ID kısmı otomatik atanacaktır...");
                    reset();
                    list();


                }
                else
                {
                    ders.DersAd = TxtAd.Text;
                    BLDers.dersEkleBL(ders);
                    MessageBox.Show("Ders Kayıt Edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                    list();


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hatalı Giris: {ex.Message} " ,"Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                reset();

            }
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityDers> ders = BLDers.DersListeliBL();
            dataGridView1.DataSource = ders;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                byte deger;
                deger = byte.Parse(TxtID.Text);
                EntityDers ders = new EntityDers();
                ders.DersID = byte.Parse(deger.ToString());
                BLDers.DersSilBL(ders.DersID);
                MessageBox.Show($"Ders Basariyla Silindi ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                list();


            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata:  {ex.Message} ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();

            }

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                EntityDers ders = new EntityDers();
                ders.DersAd = TxtAd.Text;
                ders.DersID = byte.Parse(TxtID.Text);
                BLDers.DersGuncelleBL(ders);
                MessageBox.Show($"Ders Basariyla Guncellendi ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                list();


            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata:  {ex.Message} ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list();
        }
    }
}
