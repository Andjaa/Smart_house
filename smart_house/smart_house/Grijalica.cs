using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smart_house
{
    class Grijalica : Uredjaj
    {
        protected int temperatura;

        public int Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        public override void UkljuciUredjaj()
        {
            if (StanjeUredjaja != true)
                StanjeUredjaja = true;

            Console.WriteLine("AT+TEMP= " + Temperatura);
        }
        public override void IskljuciUredjaj()
        {
            if (StanjeUredjaja != false)
                StanjeUredjaja = false;

            Console.WriteLine("AT+STOP");
        }
        
        public static Grijalica operator ++(Grijalica A)
        {
            A.Temperatura++;
            return A;
        }

        public Grijalica(string naziv, string adresa, int temperatura)
        {
            naziv_uredjaja = naziv;
            AdresaUredjaja = adresa;
            Temperatura = temperatura;
            StanjeUredjaja = false;
        }
    }
}

