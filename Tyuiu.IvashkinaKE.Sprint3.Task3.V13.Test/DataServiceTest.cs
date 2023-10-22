using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IvashkinaKE.Sprint3.Task3.V13.Lib;

namespace Tyuiu.IvashkinaKE.Sprint3.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();
            string str = "?sd!! 5gh. s!";

            int res = ds.ConvertStringToInt(str);

            int wait = 5;

            Assert.AreEqual(wait, res);

        }
    }
}
