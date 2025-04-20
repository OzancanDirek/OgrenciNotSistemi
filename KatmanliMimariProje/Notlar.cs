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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanliMimariProje
{
    public partial class Notlar : Form
    {
        public Notlar()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                EntityNotlar not = new EntityNotlar();
                not.DersNotu = byte.Parse(TxtDersNot.Text);
                not.Ogrenci = byte.Parse(TxtOgrenciID.Text);
                not.Ders = byte.Parse(TxtDersID.Text);
                BLNotlar.NotEkle(not);
                MessageBox.Show($"Ders Basarıyla Kayıt Edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
                reset();



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand(@"SELECT 
                                            N.NotID,
                                            O.Ad + ' ' + O.Soyad AS OgrenciAdSoyad,
                                            D.DersAd,
                                            N.DersNotu
                                        FROM 
                                            TBLNOTLAR N
                                        JOIN 
                                            TBLOGRENCI O ON N.Ogrenci = O.OgrID
                                        JOIN 
                                            TBLDERSLER D ON N.Ders = D.DersID", Baglanti.bgl);//idler ile isimleri eşleştirme

                if (komut.Connection.State != ConnectionState.Open)
                    komut.Connection.Open();

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
        public void list()
        {
            SqlCommand komut = new SqlCommand(@"SELECT 
                                            N.NotID,
                                            O.Ad + ' ' + O.Soyad AS OgrenciAdSoyad,
                                            D.DersAd,
                                            N.DersNotu
                                        FROM 
                                            TBLNOTLAR N
                                        JOIN 
                                            TBLOGRENCI O ON N.Ogrenci = O.OgrID
                                        JOIN 
                                            TBLDERSLER D ON N.Ders = D.DersID", Baglanti.bgl);//idler ile isimleri eşleştirme

            if (komut.Connection.State != ConnectionState.Open)
                komut.Connection.Open();

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public void reset()
        {
            TxtDersID.Clear();
            TxtDersNot.Clear();
            TxtNotID.Clear();
            TxtOgrenciID.Clear();
            
        }
        private void Notlar_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(800, 450);

            list();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                EntityNotlar not = new EntityNotlar();

                not.NotID = int.Parse(TxtNotID.Text);
                not.DersNotu = byte.Parse(TxtDersNot.Text);
                BLNotlar.NotGuncelleBL(not);
                MessageBox.Show($"Ogrenci Bilgileri Basariyla Guncellendi ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
                list();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }
    }
}
    
