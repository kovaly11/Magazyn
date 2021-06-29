using Microsoft.VisualStudio.TestTools.UnitTesting;
using Magazyn.Functions;
using Magazyn.Tables;
using System.Collections.Generic;

namespace MagazynTests
{
    [TestClass]
    public class FunctionTest
    {
        [TestMethod]
        public void LogInTest()
        {
            Function login = new Function();
            Assert.AreEqual(login.LogIn("jan_kowalski", "12345"), "1");
        }
        [TestMethod]
        public void ToEntityTest()
        {
            Function toEntity = new Function();
            Prac prac = toEntity.ToEntity<Prac>("http://localhost:8090/prac/1");
            Assert.AreEqual(prac.imie, "Jan");
            Assert.AreEqual(prac.nazw, "Kowalski");
        }
        [TestMethod]
        public void ToEListTest()
        {
            Function toList = new Function();
            List<Adres> adresy = toList.ToList<Adres>("http://localhost:8090/adres/all");
            Assert.AreEqual(adresy[0].street, "Broniewskiego");
            Assert.AreEqual(adresy[1].street, "Krakowska");
        }
       
    }
}
