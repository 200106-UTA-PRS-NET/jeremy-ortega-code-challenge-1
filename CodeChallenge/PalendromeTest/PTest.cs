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

        [TestMethod]
        public void TestMethod2()
        {
            PalenLib PTest = new PalenLib();
            Assert.AreEqual(PTest.palendromeCheck("aba, ."), true);
        }
        [TestMethod]
        public void TestMethod3()
        {
            PalenLib PTest = new PalenLib();
            Assert.AreEqual(PTest.palendromeCheck("abas"), false);
        }
        [TestMethod]
        public void TestMethod4()
        {
            PalenLib PTest = new PalenLib();
            Assert.AreEqual(PTest.palendromeCheck("a"), true);
        }
        [TestMethod]
        public void TestMethod5()
        {
            PalenLib PTest = new PalenLib();
            Assert.AreEqual(PTest.palendromeCheck("aa"), true);
        }
        [TestMethod]
        public void TestMethod6()
        {
            PalenLib PTest = new PalenLib();
            Assert.AreEqual(PTest.palendromeCheck("11"), true);
        }
        [TestMethod]
        public void TestMethod7()
        {
            PalenLib PTest = new PalenLib();
            Assert.AreEqual(PTest.palendromeCheck("1"), true);
        }


        [TestMethod]
        public void TestMethod8()
        {
            PalenLib PTest = new PalenLib();
            Assert.AreEqual(PTest.palendromeCheck("nurses run"), true);
        }
        [TestMethod]
        public void TestMethod9()
        {
            PalenLib PTest = new PalenLib();
            Assert.AreEqual(PTest.palendromeCheck("racecaR"), true);
        }
        [TestMethod]
        public void TestMethod10()
        {
            PalenLib PTest = new PalenLib();
            Assert.AreEqual(PTest.palendromeCheck("1221"), true);
        }
        [TestMethod]
        public void TestMethod11()
        {
            PalenLib PTest = new PalenLib();
            Assert.AreEqual(PTest.palendromeCheck("never odd, or even."), true);
        }
        [TestMethod]
        public void TestMethod12()
        {
            PalenLib PTest = new PalenLib();
            Assert.AreEqual(PTest.palendromeCheck("one two one"), false);
        }
        [TestMethod]
        public void TestMethod13()
        {
            PalenLib PTest = new PalenLib();
            Assert.AreEqual(PTest.palendromeCheck("123abccba123"), false);
        }
    }
}
