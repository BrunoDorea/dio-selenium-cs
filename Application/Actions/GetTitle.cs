using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Application.Actions {
    public class GetTitle {
        // indicar um browser
        string chromeDrivePath = "";

        // criar as configurações iniciais do browser
        ChromeOptions options = new ChromeOptions();

        // criar uma nova instancia do browser
        public void Navigate() {
            // options.AddArgument("--headless"); // rodar sem abrir o browser
            using(ChromeDriver driver = new ChromeDriver(chromeDrivePath, options)) {
                string url = "https://www.brunodorea.com.br";
                driver.Navigate().GoToUrl(url);

                string pageTitle = driver.Title;
                Console.WriteLine($"Titulo da página é {pageTitle}");

                // Console.WriteLine("Pressione uma tecla para continuar");
                // Console.ReadKey();

                driver.Quit();
            }
        }
    }
}