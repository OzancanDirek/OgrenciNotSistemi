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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        public void reset()
        {
            TxtAd.Clear();
            TxtID.Clear();
            TxtAranacak.Clear();
            TxtNumara.Clear();
            TxtSoyad.Clear();
        }
        public void list()
        {
            try
            {
                List<EntityOgrenci> ogrenci = BLOgrenci.ListOgrenci();
                dataGridView1.DataSource = ogrenci; 
                reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            EntityOgrenci ogrenci = new EntityOgrenci();

            try
            {
                ogrenci.Ad = TxtAd.Text;
                ogrenci.Soyad = TxtSoyad.Text;
                ogrenci.Numara = TxtNumara.Text;
                ogrenci.Bolum = TxtBolum.Text;

                BLOgrenci.ogrenciEkle(ogrenci);
                MessageBox.Show("Ogrenci Kayıt Edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                list();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            try
            {
                List<EntityOgrenci> ogrenci = BLOgrenci.ListOgrenci(); //BusinessLayer ogrenci listesi methodundan türettim
                dataGridView1.DataSource = ogrenci; //Source ataması
                reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                string deger;
                deger = TxtID.Text;
                EntityOgrenci ogrenci = new EntityOgrenci();
                ogrenci.OgrID = int.Parse(deger);
                BLOgrenci.ogrenciSil(ogrenci.OgrID);
                MessageBox.Show($"Ogrenci Basariyla Silindi ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                list();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();

            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                EntityOgrenci ogrenci = new EntityOgrenci();
                ogrenci.Ad = TxtAd.Text;
                ogrenci.Soyad = TxtSoyad.Text;
                ogrenci.Numara = TxtNumara.Text;
                ogrenci.Bolum = TxtBolum.Text;
                ogrenci.OgrID = int.Parse(TxtID.Text);

                BLOgrenci.OgrenciGuncelle(ogrenci);
                list();
                MessageBox.Show($"Ogrenci Bilgileri Basariyla Guncellendi ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM TBLOGRENCI WHERE Numara = @p1", Baglanti.bgl);
                komut.Parameters.AddWithValue("@p1", TxtAranacak.Text);

                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            list();
            this.Size = new System.Drawing.Size(800, 450);
        }

    }
}
