using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DersBLL
    {
        public static List<Ders> DersListeleBLL()
        {
            return DersDAL.DersListesi();
        }

        public static int TalepEkle(BasvuruFormu basvuruFormu)
        {
            if (basvuruFormu.BasvuruFormOgrenciId != null && basvuruFormu.BasvuruFormDersId != null)
            {
                return DersDAL.TalepEkle(basvuruFormu);
            }
            return -1;
        }

    }
}
