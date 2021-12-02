using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stadtwerk;

namespace StadwerkTests
{
    public class Hauptanschluss
    {
        List<Abnahmestelle> abnahmestelle = new List<Abnahmestelle>();
        Adresse adresse;
        public Hauptanschluss(Adresse adresses)
        {
            this.adresse = adresses;

        }

        public Adresse Adresses { get => adresse; }

        public List<Abnahmestelle> Abnahmestellen
        {
            get => abnahmestelle;

        }


    }
}

