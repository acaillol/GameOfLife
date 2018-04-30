using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMortUneCellule()
        {
            var tableau = new List<List<char>>
            {
                "........".ToCharArray().ToList(),
                "........".ToCharArray().ToList(),
                "..*.....".ToCharArray().ToList(),
                "........".ToCharArray().ToList()
            };

            var jeuDeLaVie = new JeuDeLaVie(tableau);

            List<List<char>> tableauResultat = jeuDeLaVie.JouerEtapeSuivante();

            Assert.AreEqual('.', tableauResultat[2][2]);
        }

        [TestMethod]
        public void TestMortUneCelluleAvecUneVoisine()
        {
            var tableau = new List<List<char>>
            {
                "........".ToCharArray().ToList(),
                "........".ToCharArray().ToList(),
                "..**....".ToCharArray().ToList(),
                "........".ToCharArray().ToList()
            };

            var jeuDeLaVie = new JeuDeLaVie(tableau);

            List<List<char>> tableauResultat = jeuDeLaVie.JouerEtapeSuivante();

            Assert.AreEqual('.', tableauResultat[2][2]);
        }

        [TestMethod]
        public void TestResteEnVieUneCelluleAvecDeuxVoisineHorizontales()
        {
            var tableau = new List<List<char>>
            {
                "........".ToCharArray().ToList(),
                "........".ToCharArray().ToList(),
                ".***....".ToCharArray().ToList(),
                "........".ToCharArray().ToList()
            };

            var jeuDeLaVie = new JeuDeLaVie(tableau);

            List<List<char>> tableauResultat = jeuDeLaVie.JouerEtapeSuivante();

            Assert.AreEqual('*', tableauResultat[2][2]);
        }
    }

}
