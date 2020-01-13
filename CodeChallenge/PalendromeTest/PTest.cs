using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalinLibrary;

namespace PalendromeTest
{
    [TestClass]
    public class PTest :PalinLibrary.PalenLib

    {
        [TestMethod]
        public void TestMethod1()
        {
            PalenLib PTest = new PalenLib();
            Assert.AreEqual(PTest.palendromeCheck("aba"), true);
        }
    }
}
