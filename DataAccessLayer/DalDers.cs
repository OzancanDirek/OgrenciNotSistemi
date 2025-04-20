using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DalDers
    {
        public static int DersEkle(EntityDers p)//entity dersten istediğimiz prop'a ulaşabilmek için p adında tanımladık
        {
            SqlCommand komut = new SqlCommand("insert into TBLDERSLER VALUES (@p1)",Baglanti.bgl);
            if(komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open(); //baglantı açık değilse açıyoruz
            }
            
            komut.Parameters.AddWithValue("@p1", p.DersAd);
            return komut.ExecuteNonQuery();
        }
        public static List<EntityDers> DersListesi()
        {
            List<EntityDers> dersler = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("select * from TBLDERSLER",Baglanti.bgl);
            if(komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.DersID = byte.Parse(dr["DersID"].ToString());
                ent.DersAd = dr["DersAd"].ToString();
                dersler.Add(ent);
            }
            dr.Close();
            return dersler;
        }

        public static int DersSil(byte p)
        {
            SqlCommand komut3 = new SqlCommand("delete from TBLDERSLER where DersID = @p1 ", Baglanti.bgl);
            if (komut3.Connection.State != System.Data.ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery();
        }

        
        public static int DersGuncelle(EntityDers p)
        {
            SqlCommand komut4 = new SqlCommand("Update TBLDERSLER set DersAd= @p1 where DersID = @p2", Baglanti.bgl);

            if (komut4.Connection.State != System.Data.ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1",p.DersAd);
            komut4.Parameters.AddWithValue("@p2", p.DersID);
            return komut4.ExecuteNonQuery();


        }
    }
}

