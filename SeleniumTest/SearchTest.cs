using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System.Threading;

namespace SeleniumTest
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void SearchTestMethod()
        {
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {

                driver.Navigate().GoToUrl("https://www.amazon.in");
                Thread.Sleep(2000);
                driver.Quit();
            }
        }
    }
}
