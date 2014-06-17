using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestkosztPrzejazduSamochod()
        {

            var kontekst = new RozliczeniePracownikow.Rozliczenia();
            var aktualne = kontekst.kosztPrzejazduSamochod(900, 5.5F,5.3F, 54);
            var oczekiwana = 316.35;

            Assert.AreEqual<double>(oczekiwana, aktualne);
        }

        [TestMethod]
        public void TestChorobowe()
        {

            var kontekst = new RozliczeniePracownikow.Rozliczenia();
            var aktualne = kontekst.chorobowe(10,3650.0F);
            decimal oczekiwana =973.30M;

            Assert.AreEqual<decimal>(oczekiwana, aktualne);
        }
    }
}


