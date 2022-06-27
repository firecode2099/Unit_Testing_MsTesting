
using Microsoft.VisualStudio.TestTools.UnitTesting;

using NetCoreWebApp;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_String()
        {

            string a = "hola";
            var s = new Program();
            Assert.AreEqual(a, s.Getname("hola"));

        }

        [TestMethod]
        public void Test_number()
        {

            int x =10;
            var xx = new Program();
            Assert.AreEqual(x, xx.Getnumber(10));

        }
    }
}
