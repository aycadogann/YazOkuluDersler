using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DersDAL
    {
        public static List<Ders> DersListesi()
        {
            List<Ders> dersler = new List<Ders>();
            SqlCommand komut = new SqlCommand("select * from Ders", Baglanti.baglanti);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Ders ders = new Ders();
                ders.DersId = Convert.ToInt32(oku["DersId"].ToString());
                ders.DersAd = oku["DersAd"].ToString();
                ders.DersMinKontenjan = Convert.ToInt32(oku["DersMinKontenjan"].ToString());
                ders.DersMaksKontenjan = Convert.ToInt32(oku["DersMaksKontenjan"].ToString());
               
                dersler.Add(ders);
            }
            oku.Close();

            return dersler;
        }

        public static int TalepEkle(BasvuruFormu basvuruFormu)
        {
            SqlCommand komut = new SqlCommand("insert into BasvuruFormu (OgrenciId, DersId) values (@p1,@p2)", Baglanti.baglanti);
            komut.Parameters.AddWithValue("@p1", basvuruFormu.BasvuruFormOgrenciId);
            komut.Parameters.AddWithValue("@p2", basvuruFormu.BasvuruFormDersId);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();
        }
    }
}
