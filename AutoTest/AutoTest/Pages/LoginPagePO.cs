using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;

/**
 * @brief AutoTests for RedSoft LLC
 * @author Bulat Latypov
 * @details Страница входа в аккаунт
*/

namespace AutoTest.Pages
{
    class LoginPagePO
    {
        private IWebDriver driver;

        public void OpenLoginForm()
        {
            driver.Navigate().GoToUrl("https://shop.saint-gobain.ru/");
            driver.FindElement(By.LinkText("Войти")).Click();
            driver.FindElement(By.LinkText("Вход для зарегистрированных покупателей")).Click();
            driver.FindElement(By.Id("edit-name")).Click();
        }
    }
}
