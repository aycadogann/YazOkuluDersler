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
    public class OgrenciDAL
    {
        public static int OgrenciEkle(Ogrenci ogrenci)
        {
            SqlCommand komut = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrNumara,OgrFotograf,OgrSifre) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.baglanti);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", ogrenci.OgrAd);
            komut.Parameters.AddWithValue("@p2", ogrenci.OgrSoyad);
            komut.Parameters.AddWithValue("@p3", ogrenci.OgrNumara);
            komut.Parameters.AddWithValue("@p4", ogrenci.OgrFotograf);
            komut.Parameters.AddWithValue("@p5", ogrenci.OgrSifre);
            return komut.ExecuteNonQuery();
        }
    }
}
