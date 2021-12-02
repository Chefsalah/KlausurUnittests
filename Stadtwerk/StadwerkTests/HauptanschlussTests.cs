using System;
using Stadtwerk;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StadwerkTests
{
    [TestClass]
    public class HauptanschlussTests
    {
        [TestMethod]
        public void Hauptanschluss_KannErstelltWerden()
        {
            //Arrange
            Adresse adresse = new Adresse("Strasse", "Hausnummer", "PLZ", "Stadt");

            //Act
            Hauptanschluss h = new Hauptanschluss(adresse);

            //Assert
            Assert.AreEqual(h.Adresses, adresse);
        }

        [TestMethod]
        public void Abnahmestellen_KoennenHinzugefuegtWerden()
        {
            //Arrange
            Abnahmestelle a = new Abnahmestelle("1", "EG", 1);

            Adresse adresse = new Adresse("Strasse", "Hausnummer", "PLZ", "Stadt");
            Hauptanschluss h = new Hauptanschluss(adresse);


            //Act
            h.Abnahmestellen.Add(a);
            bool abnahmestelleIstEnthalten = h.Abnahmestellen.Contains(a);

            //Assert
            Assert.IsTrue(abnahmestelleIstEnthalten);
        }
    }
}
