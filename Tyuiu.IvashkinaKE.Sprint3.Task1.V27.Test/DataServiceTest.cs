using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IvashkinaKE.Sprint3.Task1.V27.Lib;

namespace Tyuiu.IvashkinaKE.Sprint3.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.75;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 7440986.446;

            Assert.AreEqual(wait, res);

        }
    }
}
