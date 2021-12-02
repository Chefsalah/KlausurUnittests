using System;
using Stadtwerk;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StadwerkTests
{
	[TestClass]
	public class AdresseTests
	{
		[TestMethod]
		public void Adresse_KannErstelltWerden()
		{
			//Arrange
			string strasse = "Westerwaldstrasse";
			string hausnummer = "92";
			string plz = "51105";
			string stadt = "Köln";

			//Act
			Adresse a = new Adresse(strasse, hausnummer, plz, stadt);

			//Assert
			Assert.AreEqual(strasse, a.Strasse);
			Assert.AreEqual(hausnummer, a.Hausnummer);
			Assert.AreEqual(plz, a.Plz);
			Assert.AreEqual(stadt, a.Stadt);
		}
	}
}
