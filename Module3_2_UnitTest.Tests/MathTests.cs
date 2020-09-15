using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Module3_2_UnitTest.Controllers;

namespace Module3_2_UnitTest.Tests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Carre_Valeur2_Return4()
        {
            int resultat = new MathController().Carre(2);
            Assert.AreEqual(4, resultat);
        }
    }
}
