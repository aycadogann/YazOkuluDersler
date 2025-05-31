using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class OgrenciBLL
    {
        public static int OgrenciEkleBLL(Ogrenci ogr)
        {
            if (ogr.OgrAd!=null && ogr.OgrSoyad!=null && ogr.OgrNumara!=null && ogr.OgrFotograf != null && ogr.OgrSifre!=null )
            {
                return OgrenciDAL.OgrenciEkle(ogr);
            }
            return -1;
        }
        public static List<Ogrenci> OgrenciListeleBLL()
        {
            return OgrenciDAL.OgrenciListesi();
        }
    }
}
