using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Application.Actions {
    public class ClickElement {
        string chromeDrivePath = "";
        ChromeOptions options = new ChromeOptions();
        // options.addArguments("--headless");

        public void Navigate() {
            using(ChromeDriver driver = new ChromeDriver(chromeDrivePath, options)) {
                string url = "https://www.google.com";
                driver.Navigate().GoToUrl(url);

                IWebElement searchBox = driver.FindElement(By.Id("APjFqb"));
                searchBox.SendKeys("Fluminense");

                System.Threading.Thread.Sleep(300);

                IWebElement btnSearch = driver.FindElement(By.Name("btnK"));
                btnSearch.Click();

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadKey();

                driver.Quit();
            }
        }
    }
}