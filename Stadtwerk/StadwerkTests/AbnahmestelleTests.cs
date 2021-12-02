using System;
using Stadtwerk;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StadwerkTests
{
    [TestClass]
    public class AbnahmestelleTests
    {
        [TestMethod]
        public void Abnahmestelle_KannErstelltWerden()
        {
            //Arrange
            string zaehlernummer = "21913168";
            string beschreibung = "1.OG rechts";
            int versorgteFlaeche = 20;

            //Act
            Abnahmestelle a = new Abnahmestelle(zaehlernummer, beschreibung, versorgteFlaeche);

            //Assert
            Assert.AreEqual(zaehlernummer, a.Zaehlernummer);
            Assert.AreEqual(beschreibung, a.Beschreibung);
            Assert.AreEqual(versorgteFlaeche, a.VersorgteFlaeche);
        }

        [TestMethod]
        public void Abnahmestelle_ZaehlernummerHatNiemalsLeerzeichen()
        {
            //Arrange
            string zaehlernummerIst = "21 913 168";
            string zaehlernummerSoll = "21913168";

            //Act
            Abnahmestelle a = new Abnahmestelle(zaehlernummerIst, "1.OG rechts", 20);

            //Assert
            Assert.AreEqual(zaehlernummerSoll, a.Zaehlernummer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Abnahmestelle_VersorgteFlaecheNegativerWertUnmoeglich()
        {
            //Arrange
            int versorgteFlaeche = -1;

            //Act
            Abnahmestelle a = new Abnahmestelle("21913168", "1.OG rechts", versorgteFlaeche);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Abnahmestelle_VersorgteFlaecheNurPositiverWertMoeglich()
        {
            //Arrange
            int versorgteFlaeche = 0;

            //Act
            Abnahmestelle a = new Abnahmestelle("21913168", "1.OG rechts", versorgteFlaeche);
        }
    }
}
