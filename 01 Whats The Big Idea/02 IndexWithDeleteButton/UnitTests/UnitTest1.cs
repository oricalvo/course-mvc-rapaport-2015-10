using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IndexWithDeleteButton.Controllers;
using System.Web.Mvc;
using IndexWithDeleteButton;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ContactController ctrl = new ContactController();

            ActionResult res = ctrl.Index(null);

            ViewResult viewRes = res as ViewResult;
            Assert.IsNotNull(viewRes);

            Contact[] contacts = (Contact[])viewRes.Model;
        }
    }
}
