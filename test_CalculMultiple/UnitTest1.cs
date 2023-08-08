using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_CalculMultiple; 

namespace test_CalculMultiple
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalculMultiple.Multiple m = new CalculMultiple.Multiple();

            string result= m.Multiple_3(8);

            Assert.AreEqual("n n'est pas de multiple du 3", result); ; 
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Test_Multiple_5()
        {
            CalculMultiple.Multiple m = new CalculMultiple.Multiple();

            string result = m.Multiple_5(0);

            Assert.AreEqual("n est de multiple du 5", result); ;
        }
    }
}
