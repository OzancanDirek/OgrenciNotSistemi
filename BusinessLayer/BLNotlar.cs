using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLNotlar
    {
        public static int NotEkle(EntityNotlar p)
        {
            if(p.Ogrenci >= 1 && p.Ders >= 1)
            {
                return DalNotlar.NotEkle(p);
            }
            else
            {
                return -1;
            }
        }

        public static List<EntityNotlar> NotListesi()
        {
            return DalNotlar.NotListele();
        }
        public static int NotSilBL(EntityNotlar p)
        {
            if (p.NotID >= 1)
            {
                return DalNotlar.NotSil(p.NotID);
            }
            else
            {
                return -1;
            }
        }
        public static int NotGuncelleBL(EntityNotlar p)
        {
            if (p.NotID >= 1)
            {
                return DalNotlar.NotGuncelle(p);
            }
            return -1;
        }
    }
}
