using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace smart_house
{
    abstract class Uredjaj
    {
        public string naziv_uredjaja;   
        private string adresa_uredjaja;
        private bool stanje_uredjaja;

        public string NazivUredjaja
        {
            get { return naziv_uredjaja; }
        }
        protected string AdresaUredjaja
        {
            get { return adresa_uredjaja; }
            set
            {   
                if(value.Length>=7 && value.Length<=15)
                adresa_uredjaja = value;
            }
        }
        protected bool StanjeUredjaja
        {
            get { return stanje_uredjaja; }
            set { stanje_uredjaja = value; }
        }

        abstract public void UkljuciUredjaj();
        abstract public void IskljuciUredjaj();

        public override string ToString()
        {
            string pom = "";

            if (StanjeUredjaja == false)
                pom = "Iskljucen";
            else
                pom = "Ukljucen";

         	 return NazivUredjaja+" (" + AdresaUredjaja + "): " + pom;
        }

        public static implicit operator bool(Uredjaj A)
        {
            return A.StanjeUredjaja;
        }
        public static Uredjaj operator +(Uredjaj A)
        {
            A.UkljuciUredjaj();
            return A;
        }
    }
}
