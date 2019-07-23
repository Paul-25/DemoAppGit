using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoAppGit;
using DemoAppGit.Controllers;

namespace DemoAppGit.Tests.Controllers
{
    [TestClass]
    public class MainControllerTest
    {
        MainController mc = new MainController();
        [TestMethod]
        public void AddTest()
        {
            int res = mc.Add(5, 3);
            Assert.Equals(res, "2");
        }
    }
}
