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

        public static List<Ogrenci> OgrenciListesi()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            SqlCommand komut2 = new SqlCommand("select * from Ogrenci", Baglanti.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                Ogrenci ogr = new Ogrenci();
                ogr.OgrId = Convert.ToInt32(oku["OgrId"].ToString());
                ogr.OgrAd = oku["OgrAd"].ToString();
                ogr.OgrSoyad = oku["OgrSoyad"].ToString();
                ogr.OgrNumara = oku["OgrNumara"].ToString();
                ogr.OgrFotograf = oku["OgrFotograf"].ToString();
                ogr.OgrSifre = oku["OgrSifre"].ToString();
                ogr.OgrBakiye = Convert.ToDouble(oku["OgrBakiye"].ToString());
                ogrenciler.Add(ogr);
            }
            oku.Close();
            
            return ogrenciler;
        }

        public static bool OgrenciSil(int id)
        {
            SqlCommand komut3 = new SqlCommand("delete from Ogrenci where OgrId=@p1", Baglanti.baglanti);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", id);
            return komut3.ExecuteNonQuery()>0;
        }

        public static List<Ogrenci> OgrenciDetay(int id)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            SqlCommand komut4 = new SqlCommand("select * from Ogrenci where OgrId=@p1", Baglanti.baglanti);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader oku = komut4.ExecuteReader();
            while (oku.Read())
            {
                Ogrenci ogr = new Ogrenci();
                ogr.OgrAd = oku["OgrAd"].ToString();
                ogr.OgrSoyad = oku["OgrSoyad"].ToString();
                ogr.OgrNumara = oku["OgrNumara"].ToString();
                ogr.OgrFotograf = oku["OgrFotograf"].ToString();
                ogr.OgrSifre = oku["OgrSifre"].ToString();
                ogr.OgrBakiye = Convert.ToDouble(oku["OgrBakiye"].ToString());
                ogrenciler.Add(ogr);
            }
            oku.Close();

            return ogrenciler;
        }

        public static bool OgrenciGuncelle(Ogrenci ogrenci)
        {
            SqlCommand komut5 = new SqlCommand("update Ogrenci set OgrAd=@p1, OgrSoyad=@p2, OgrNumara=@p3, OgrFotograf=@p4, OgrSifre=@p5 where OgrId=@p6", Baglanti.baglanti);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1", ogrenci.OgrAd);
            komut5.Parameters.AddWithValue("@p2", ogrenci.OgrSoyad);
            komut5.Parameters.AddWithValue("@p3", ogrenci.OgrNumara);
            komut5.Parameters.AddWithValue("@p4", ogrenci.OgrFotograf);
            komut5.Parameters.AddWithValue("@p5", ogrenci.OgrSifre);
            komut5.Parameters.AddWithValue("@p6", ogrenci.OgrId);
            return komut5.ExecuteNonQuery() > 0;
            
        }
    }
}
