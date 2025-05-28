using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Ogrenci
    {
        private int ogrId;
        public int OgrId
        {
            get => ogrId;
            set => ogrId = value;
        }

        private string ogrAd;
        public string OgrAd 
        { 
            get => ogrAd; 
            set => ogrAd = value; 
        }

        private string ogrSoyad;
        public string OgrSoyad 
        { 
            get => ogrSoyad; 
            set => ogrSoyad = value; 
        }

        private string ogrNumara;
        public string OgrNumara
        {
            get => ogrNumara;
            set => ogrNumara = value;
        }

        private string ogrFotograf;
        public string OgrFotograf
        {
            get => ogrFotograf;
            set => ogrFotograf = value;
        }

        private double ogrBakiye;
        public double OgrBakiye
        {
            get => ogrBakiye;
            set => ogrBakiye = value;
        }


    }
}
