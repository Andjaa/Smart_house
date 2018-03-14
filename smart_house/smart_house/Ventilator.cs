using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smart_house
{
    class Ventilator : Uredjaj
    {
        private int brzina_ventilatora;

        protected int BrzinaVentilatora
        {
            get { return brzina_ventilatora; }
            set
            {
                if (value >= 0 && value <= 10)
                    brzina_ventilatora = value;
            }
        }

        public override void UkljuciUredjaj()
        {
            if (StanjeUredjaja != true)
            {
                StanjeUredjaja = true;
                BrzinaVentilatora = 1;
                Console.WriteLine("AT+ON= " + BrzinaVentilatora);
            }
        }
        public override void IskljuciUredjaj()
        {
            if (StanjeUredjaja != false)
            {
                StanjeUredjaja = false;
                BrzinaVentilatora = 0;
                Console.WriteLine("AT+OFF");
            }
        }

        public static Ventilator operator ++(Ventilator A)
        {
            A.BrzinaVentilatora++;
            return A;
        }

        public Ventilator(string naziv, string adresa)
        {
            naziv_uredjaja = naziv;
            AdresaUredjaja = adresa;
            StanjeUredjaja = false;
            BrzinaVentilatora = 10;
        }
    }
}

   