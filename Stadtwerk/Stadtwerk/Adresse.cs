using System;
using System.Collections.Generic;
using Stadtwerk;
namespace Stadtwerk
{
    public class Adresse
    {
        string strasse;
        string hausnummer;
        string plz;
        string stadt;

        public Adresse(string strasse, string hausnummer, string plz, string stadt)
        {
            this.strasse = strasse;
            this.hausnummer = hausnummer;
            this.plz = plz;
            this.stadt = stadt;
        }
        public string Strasse { get => strasse; }
        public string Hausnummer { get => hausnummer; }
        public string Plz { get => plz;}    
        public string Stadt { get => stadt;}



    }
}
