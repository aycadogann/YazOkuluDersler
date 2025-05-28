using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Ogretmen
    {
        private int ogrtId;
        public int OgrtId
        {
            get => ogrtId;
            set => ogrtId = value;
        }

        private string ogrtAd;
        public string OgrtAd 
        {
            get => ogrtAd;
            set => ogrtAd = value;
        }

        private string ogrtBrans;
        public string OgrtBrans
        {
            get => ogrtBrans;
            set => ogrtBrans = value;
        }
    }
}
