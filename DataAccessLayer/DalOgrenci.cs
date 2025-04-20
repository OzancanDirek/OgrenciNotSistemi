using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DalOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci p)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI (Ad,Soyad,Numara,Bolum) VALUES (@p1, @p2, @p3, @p4)" +
                "",Baglanti.bgl);
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", p.Ad);
            komut1.Parameters.AddWithValue("@p2", p.Soyad);
            komut1.Parameters.AddWithValue("@p3", p.Numara);
            komut1.Parameters.AddWithValue("@p4", p.Bolum);
            return komut1.ExecuteNonQuery();

        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> ogrenciler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select * from TBLOGRENCI", Baglanti.bgl);

            if (komut2.Connection.State != System.Data.ConnectionState.Open)
            {
                komut2.Connection.Open();
            }

            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ogrenci1 = new EntityOgrenci();
                ogrenci1.OgrID = int.Parse(dr[0].ToString());
                ogrenci1.Ad = dr[1].ToString();
                ogrenci1.Soyad = dr[2].ToString();
                ogrenci1.Numara = dr[3].ToString();
                ogrenci1.Bolum = dr[4].ToString();
                
                ogrenciler.Add(ogrenci1);

            }
            dr.Close();
            return ogrenciler;
        }
        public static int ogrenciSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("delete from TBLOGRENCI where OgrID = @p1", Baglanti.bgl);
            if (komut3.Connection.State != System.Data.ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);

            return komut3.ExecuteNonQuery();
        }
        public static int ogrenciGuncelle(EntityOgrenci p)
        {
            SqlCommand komut4 = new SqlCommand("Update TBLOGRENCI set Ad = @p1, Soyad = @p2, Numara = @p3, Bolum = @p4 " +
                                    "where OgrID = @p5", Baglanti.bgl);
            if (komut4.Connection.State != System.Data.ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1",p.Ad);
            komut4.Parameters.AddWithValue("@p2", p.Soyad);
            komut4.Parameters.AddWithValue("@p3", p.Numara);
            komut4.Parameters.AddWithValue("@p4", p.Bolum);
            komut4.Parameters.AddWithValue("@p5", p.OgrID);
            return komut4.ExecuteNonQuery();


        }



    }
}
