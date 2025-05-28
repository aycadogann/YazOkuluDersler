using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Ders
    {
        private int dersId;
        public int DersId
        {
            get => dersId;
            set => dersId = value;
        }

        private string dersAd;
        public string DersAd
        {
            get => dersAd;
            set => dersAd = value;
        }

        private int dersMin;
        public int DersMin
        {
            get=> dersMin;
            set => dersMin = value;
        }

        private int dersMaks;
        public int DersMaks
        {
            get => dersMaks;
            set => dersMaks = value;
        }
    }
}
