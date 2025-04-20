using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DalNotlar
    {
        public static int NotEkle(EntityNotlar p)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLNOTLAR (Ogrenci,Ders,DersNotu)" +
            "Values(@p1,@p2,@p3)  ", Baglanti.bgl);
            komut1.Parameters.AddWithValue("@p1", p.Ogrenci);
            komut1.Parameters.AddWithValue("@p2", p.Ders);
            komut1.Parameters.AddWithValue("@p3", p.DersNotu);
            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open(); //baglantı açık değilse açıyoruz
            }
            return komut1.ExecuteNonQuery();
        }

        public static List<EntityNotlar> NotListele()
        {
            List<EntityNotlar> notlar = new List<EntityNotlar>();
            SqlCommand komut2 = new SqlCommand("select * from TBLNOTLAR", Baglanti.bgl);
            if (komut2.Connection.State != System.Data.ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityNotlar not1 = new EntityNotlar();
                not1.NotID = byte.Parse(dr[0].ToString());
                not1.Ogrenci = byte.Parse(dr[1].ToString());
                not1.Ders = byte.Parse(dr[2].ToString());
                not1.DersNotu = byte.Parse(dr[3].ToString());
                notlar.Add(not1);

            }
            dr.Close();
            return notlar;

        }
        public static int NotSil(int id)
        {
            SqlCommand komut = new SqlCommand("delete from TBLNOTLAR where NotID = @p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", id);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }
        public static int NotGuncelle(EntityNotlar p)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBLNOTLAR SET DersNotu = @p1 WHERE NotID = @p2", Baglanti.bgl);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p.DersNotu);
            komut.Parameters.AddWithValue("@p2", p.NotID);
            return komut.ExecuteNonQuery();
        }

    }
}
