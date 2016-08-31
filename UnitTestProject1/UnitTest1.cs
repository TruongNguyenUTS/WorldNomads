using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using WorldNomads.Models;
using WorldNomads.Controllers;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_NotNUm()
        {
            TestModel m = new TestModel();
            m.InputNumber = "abcdsf";
            HomeController home = new HomeController();
            var result = home.Index(m, "") as ViewResult;
            Assert.AreEqual("Failed", result.ViewData["Result"]);
        }
        [TestMethod]
        public void TestMethod_NegativeNum()
        {
            TestModel m = new TestModel();
            m.InputNumber = "-3000";
            HomeController home = new HomeController();
            var result = home.Index(m, "") as ViewResult;
            Assert.AreEqual("Failed", result.ViewBag.Result);
        }
       
        [TestMethod]
        public void TestMethod_OutOfInteger()
        {
            TestModel m = new TestModel();
            m.InputNumber = "9999999999";
            HomeController home = new HomeController();
            var result = home.Index(m, "") as ViewResult;
            Assert.AreEqual("Failed", result.ViewBag.Result);
        }
        [TestMethod]
        public void TestMethod_ValidNum()
        {
            TestModel m = new TestModel();
            m.InputNumber = "20";
            HomeController home = new HomeController();
            var result = home.Index(m, "") as ViewResult;
            Assert.AreEqual("Success", result.ViewBag.Result);
            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20", result.ViewBag.Result1);
            Assert.AreEqual("1, 3, 5, 7, 9, 11, 13, 15, 17, 19", result.ViewBag.Result2);
            Assert.AreEqual("0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20", result.ViewBag.Result3);
            Assert.AreEqual("Z, 1, 2, C, 4, E, C, 7, 8, C, E, 11, C, 13, 14, Z, 16, 17, C, 19, E", result.ViewBag.Result4);
            Assert.AreEqual("0, 1, 1, 2, 3, 5, 8, 13", result.ViewBag.Result5);
        }
    }
}
