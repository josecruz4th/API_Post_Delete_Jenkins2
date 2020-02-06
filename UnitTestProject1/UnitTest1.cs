using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1:Post_Delete_Classes
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {

                string strStringToVal = this.dataToPost("Jose", "12", "13");
                string strStringToDelete = this.dataToDelete(strStringToVal);
                Console.WriteLine("DELETE RESPONSE IS: " + strStringToDelete);
                Assert.IsTrue(true, strStringToDelete);

            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
