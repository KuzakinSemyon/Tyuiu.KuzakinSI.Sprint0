using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KuzakinSI.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KuzakinSI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Сёма";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Сёма", res);
        }
    }
}
