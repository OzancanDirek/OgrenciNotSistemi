using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLOgrenci
    {
        public static int ogrenciEkle(EntityOgrenci p)
        {
            if(p.Ad != "" && p.Ad.Length >= 2 && p.Ad.Length <= 30 && p.Soyad != "" && p.Bolum !="" && 
                p.Numara.Length == 5)
            {
                return DalOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> ListOgrenci()
        {
            return DalOgrenci.OgrenciListesi();
        }
        public static int ogrenciSil(int p)
        {
            if (p >= 1)
            {
                return DalOgrenci.ogrenciSil(p);
            }
            else
            {
                return -1;
            }
        }
        public static int OgrenciGuncelle(EntityOgrenci p)
        {
            if( p.Ad !=null && p.Soyad !=""&&p.Numara.Length ==5 &&p.Bolum != ""&& p.OgrID >= 1)
            {
                return DalOgrenci.ogrenciGuncelle(p);
            }
            else
            {
                return -1;
            }
        }
        
    }
}
