using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChatJobsity.Tests
{
    [TestClass]
    public class GetStockTest
    {
        [TestMethod]
        public void GetStockApple()
        {
            string _stockCode = "AAPL.US";
            string _respuesta=new ChatJobsity.App_Code.StockProvider().GetStock(_stockCode);
            string _getCodigo = _respuesta.Split(',')[0];
            Assert.AreEqual(_stockCode, _getCodigo);



        }
    }
}
