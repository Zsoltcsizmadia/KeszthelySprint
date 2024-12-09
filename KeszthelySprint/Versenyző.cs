using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeszthelySprint
{
    internal class Versenyző
    {
        public string Név { get; set; }
        public int SzületésiÉv { get; set; }
        public int Rajtszám { get; set; }
        public string Nem { get; set; }
        public string ÉletKategória { get; set; }
        public string ÚszásIdeje { get; set; }
        public string DepóbanTöltöttIdő { get; set; }
        public string KerékpározásIdeje { get; set; }
        public string MásodikDepóIdő { get; set; }
        public string FutásIdeje { get; set; }

        public Versenyző(string sor)
        {
            string[] s = sor.Split(';');

            Név = s[0];
            SzületésiÉv = int.Parse(s[1]);
            Rajtszám = int.Parse(s[2]);
            Nem = s[3];
            ÉletKategória = s[4];
            ÚszásIdeje = s[5];
            DepóbanTöltöttIdő = s[6];
            KerékpározásIdeje = s[7];
            MásodikDepóIdő = s[8];
            FutásIdeje = s[9];
        }

    }
}
