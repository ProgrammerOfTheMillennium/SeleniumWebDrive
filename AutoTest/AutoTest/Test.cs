using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;
using OpenQA.Selenium.Support.UI;

/**
 * @brief AutoTests for RedSoft LLC
 * @author Bulat Latypov
 * @details 4. Заказ товаров из раздела https://shop.saint-gobain.ru/multicomfort (любой пакет) с фиксированием стоимости в калькуляторе и в корзине
 * readytogo.lbm@gmail.com
 * steam.gaben_hl3
*/


namespace AutoTest
{
    [TestFixture]
    public class Test
    {
        public static string projectWorkDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL = "https://shop.saint-gobain.ru";
        private bool acceptNextAlert = true;

        [OneTimeSetUp] // TestSuite Start
        public void OneTimeSetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--ignore-certificate-errors");
            options.AddArguments("--ignore-ssl-errors");
            driver = new ChromeDriver(projectWorkDir, options);
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown] // TestSuite End
        public void OneTimeTearDown()
        {
            driver.Quit();
        }

        [SetUp] // TestCase Start
        public void SetUp()
        {
            driver.Navigate().GoToUrl("https://shop.saint-gobain.ru/user/login");
            driver.FindElement(By.Id("edit-name")).Clear();
            driver.FindElement(By.Id("edit-name")).SendKeys("readytogo.lbm@gmail.com");
            driver.FindElement(By.Id("edit-pass")).Clear();
            driver.FindElement(By.Id("edit-pass")).SendKeys("steam.gaben_hl3");
            driver.FindElement(By.Id("edit-submit")).Click();
        }

        [TearDown] // TestCase End
        public void TearDown()
        {}

        [Test]
        public void TestCase_Multicomfort()
        {
            driver.Navigate().GoToUrl("https://shop.saint-gobain.ru/multicomfort");
            driver.FindElement(By.CssSelector(".control__btn .btn")).Click();
            driver.FindElement(By.CssSelector(".c3 .btn")).Click();
            driver.FindElement(By.CssSelector(".btn:nth-child(2)")).Click();

            string actualvalue = driver.FindElement(By.CssSelector(".value > div:nth-child(1)")).Text;
            Assert.IsTrue(actualvalue.Contains("348 322,38 руб."), actualvalue + " doesn't contains '348 322,38 руб.'");           
        }
        



        static public void Main(String[] args)
        {
            Console.WriteLine("Main Method");
        }
    }
}
