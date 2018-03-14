using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smart_house
{
    class KlimaUredjaj : Ventilator
    {
        Grijalica G;
        public override void UkljuciUredjaj()
        {
            if(StanjeUredjaja!=true)
            {
                StanjeUredjaja = true;
                Console.WriteLine("AT+ON= " + BrzinaVentilatora + "\nAT+TEMP= " + G.Temperatura);
            }
        }
        public override void IskljuciUredjaj()
        {
            if (StanjeUredjaja != false)
            {
                StanjeUredjaja = false;
                Console.WriteLine("AT+OFF\nAT+STOP");
            }
        }

        public static KlimaUredjaj operator ++(KlimaUredjaj A)
        {
            A.G.Temperatura++;
            A.BrzinaVentilatora++;
            return A;
        }

        public KlimaUredjaj(string naziv, string adresa, int temperatura):base(naziv, adresa)
        {
            G = new Grijalica(naziv, adresa, temperatura);
            G.Temperatura = temperatura;
            StanjeUredjaja = false;
        }
    }
}


