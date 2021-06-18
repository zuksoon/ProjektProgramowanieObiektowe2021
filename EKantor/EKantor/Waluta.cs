using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKantor
{
    class Waluta
    {
        public string nazwaWaluty;
        public float cenaZakupu;
        public float cenaSprzedazy;
        public float staraCenaSprzedazy;

        void PobierzInformacjeOWalucie()
        {
            nazwaWaluty = "empty";
            cenaZakupu = 1f;
            cenaSprzedazy = 1f;
            staraCenaSprzedazy = 1f;
        }
    }
}
