using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stadtwerk;
using System.Threading.Tasks;

namespace StadwerkTests
{
   public class Abnahmestelle
    {
        string zaehlernummer;
        string beschreibung;
        int versorgteflaeche;
        public Abnahmestelle(string zaehlernummer, string beschreibung, int versorgteflaeche)
        {
            //foreach (char Leerzeichen in zaehlernummer)
            //{
            //    if (Leerzeichen ==' ')
            //    {

            //        zaehlernummer.Remove(Leerzeichen);
            //    }
            //}
            zaehlernummer = zaehlernummer.Replace(" ","");
            this.zaehlernummer = zaehlernummer;
            
            this.beschreibung = beschreibung;

            if (versorgteflaeche <= 0)
            {
                throw new ArgumentOutOfRangeException();

            }
            else
            {
                this.versorgteflaeche = versorgteflaeche;
            }
        }
        public string Zaehlernummer { get => zaehlernummer; }
        public string Beschreibung { get => beschreibung; }
        public int VersorgteFlaeche
        { get => versorgteflaeche; }

    }
}
