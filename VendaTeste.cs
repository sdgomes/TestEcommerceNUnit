using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEcommerceNUnit
{
    class VendaTeste
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void AprovaVenda()
        {
            //driver.Navigate().GoToUrl("http://localhost");
            //System.Threading.Thread.Sleep(3000);

            //IWebElement button = driver.FindElement(By.XPath("//*[@id='acesso']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //IWebElement input = driver.FindElement(By.XPath("//*[@id='form-acesso']/div/input"));
            //input.Clear();
            //input.SendKeys("FUV05HRO6BN");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//*[@id='acessar']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(3000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div/div/div[8]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(9000);

            //input = driver.FindElement(By.XPath("//*[@id='dt-search-0']"));
            //input.Clear();
            //input.SendKeys("Processando Pagamento");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//*[@id='registros']/thead/tr/th[9]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//*[@id='registros']/thead/tr/th[9]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //IWebElement element = driver.FindElement(By.XPath("//*[@id='registros']/tbody/tr[1]/td[1]"));
            //var texto = element.Text;
            //System.Threading.Thread.Sleep(1000);
            
            //button = driver.FindElement(By.XPath("//*[@id='registros']/tbody/tr[1]/td[9]/div[1]/button[@data-etapa='COMPRA APROVADA']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(8000);

            //input = driver.FindElement(By.XPath("//*[@id='dt-search-0']"));
            //input.Clear();
            //input.SendKeys(texto);
            //System.Threading.Thread.Sleep(1000);
            
            ////
            //button = driver.FindElement(By.XPath("//*[@id='registros']/tbody/tr[1]/td[9]/div[1]/button[@data-etapa='EM PREPARAÇÃO']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(8000);

            //input = driver.FindElement(By.XPath("//*[@id='dt-search-0']"));
            //input.Clear();
            //input.SendKeys(texto);
            //System.Threading.Thread.Sleep(1000);

            ////
            //button = driver.FindElement(By.XPath("//*[@id='registros']/tbody/tr[1]/td[9]/div[1]/button[@data-etapa='A CAMINHO']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(8000);

            //input = driver.FindElement(By.XPath("//*[@id='dt-search-0']"));
            //input.Clear();
            //input.SendKeys(texto);
            //System.Threading.Thread.Sleep(1000);

            ////
            //button = driver.FindElement(By.XPath("//*[@id='registros']/tbody/tr[1]/td[9]/div[1]/button[@data-etapa='ENTREGUE']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(8000);

            //input = driver.FindElement(By.XPath("//*[@id='dt-search-0']"));
            //input.Clear();
            //input.SendKeys(texto);
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(5000);
            //Assert.Pass();
        }


        [TearDown]
        public void TearDown()
        {
            // Encerrar o WebDriver
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
