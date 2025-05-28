using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class BasvuruForm
    {
        private int basvuruId;
        public int BasvuruId
        {
            get => basvuruId;
            set => basvuruId = value;
        }

        private int basDersId;
        public int BasDersId
        {
            get => basDersId;
            set => basDersId = value;
        }

        private int basOgrId;
        public int BasOgrId
        {
            get => basOgrId;
            set => basOgrId = value;
        }
    }
}
