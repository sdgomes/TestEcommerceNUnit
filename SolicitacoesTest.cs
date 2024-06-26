using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEcommerceNUnit.Models;

namespace TestEcommerceNUnit
{
    class SolicitacoesTest
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
        public void SolicitarTrocaRecusada()
        {
            //driver.Navigate().GoToUrl("http://localhost");
            //System.Threading.Thread.Sleep(3000);

            //ClienteTest clienteTest = new ClienteTest(driver);

            //Client Cliente = new();
            //Cliente.Email = "coby.souza@icloud.com";
            //Cliente.Senha = "Padrao.1235";

            //clienteTest.LoginCliente(Cliente);
            //System.Threading.Thread.Sleep(2000);

            //IWebElement button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div[1]/div/div[1]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//span[contains(text(), 'ENTREGUE')]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(3000);

            //button = driver.FindElement(By.XPath("//*[@id='solicitar-troca']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(2000);

            //button = driver.FindElement(By.XPath("//*[@id=\"from-solicitacao\"]/div[1]/table/tbody/tr[1]/td[1]/div/label/input"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //IWebElement input = driver.FindElement(By.XPath("//*[@id=\"from-solicitacao\"]/div[2]/label/textarea"));
            //input.Clear();
            //input.SendKeys("Laboris quis labore officia fugiat eiusmod. Labore ad nisi laboris officia laboris commodo nostrud non adipisicing. Veniam laborum ad enim irure duis sit sint duis aliqua mollit est. Pariatur sunt quis occaecat est. Nulla dolore cupidatat cillum exercitation qui fugiat quis aute pariatur magna. Velit elit et aliqua qui mollit consequat laboris nulla cupidatat qui sunt nostrud aliqua pariatur.");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/main/div/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("//*[@id='acesso']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //input = driver.FindElement(By.XPath("//*[@id='form-acesso']/div/input"));
            //input.Clear();
            //input.SendKeys("FUV05HRO6BN");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//*[@id='acessar']"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div/div/div[2]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/main/div/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[1]/form/div/table/tbody/tr/td[8]/div[1]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(2000);


            //input = driver.FindElement(By.XPath("//*[@id=\"from-solicitacao\"]/div/label/textarea"));
            //input.Clear();
            //input.SendKeys("Laboris quis labore officia fugiat eiusmod. Labore ad nisi laboris officia laboris commodo nostrud non adipisicing. Veniam laborum ad enim irure duis sit sint duis aliqua mollit est. Pariatur sunt quis occaecat est. Nulla dolore cupidatat cillum exercitation qui fugiat quis aute pariatur magna. Velit elit et aliqua qui mollit consequat laboris nulla cupidatat qui sunt nostrud aliqua pariatur.");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(2000);
        }

        [Test]
        public void SolicitarTroca()
        {
            //driver.Navigate().GoToUrl("http://localhost");
            //System.Threading.Thread.Sleep(3000);

            //ClienteTest clienteTest = new ClienteTest(driver);

            //Client Cliente = new();
            //Cliente.Email = "coby.souza@icloud.com";
            //Cliente.Senha = "Padrao.1235";

            //clienteTest.LoginCliente(Cliente);
            //System.Threading.Thread.Sleep(2000);

            //IWebElement button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div[1]/div/div[1]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//span[contains(text(), 'ENTREGUE')]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(3000);

            //button = driver.FindElement(By.XPath("//*[@id='solicitar-troca']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(2000);

            //button = driver.FindElement(By.XPath("//*[@id=\"from-solicitacao\"]/div[1]/table/tbody/tr[1]/td[1]/div/label/input"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //IWebElement input = driver.FindElement(By.XPath("//*[@id=\"from-solicitacao\"]/div[2]/label/textarea"));
            //input.Clear();
            //input.SendKeys("Laboris quis labore officia fugiat eiusmod. Labore ad nisi laboris officia laboris commodo nostrud non adipisicing. Veniam laborum ad enim irure duis sit sint duis aliqua mollit est. Pariatur sunt quis occaecat est. Nulla dolore cupidatat cillum exercitation qui fugiat quis aute pariatur magna. Velit elit et aliqua qui mollit consequat laboris nulla cupidatat qui sunt nostrud aliqua pariatur.");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/main/div/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("//*[@id='acesso']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //input = driver.FindElement(By.XPath("//*[@id='form-acesso']/div/input"));
            //input.Clear();
            //input.SendKeys("FUV05HRO6BN");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//*[@id='acessar']"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div/div/div[2]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/main/div/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[1]/form/div/table/tbody/tr/td[8]/div[2]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(2000);

            //button = driver.FindElement(By.XPath("//*[@id=\"sair\"]"));
            //button.Click();
            //System.Threading.Thread.Sleep(3000);

            //clienteTest.LoginCliente(Cliente);
            //System.Threading.Thread.Sleep(2000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div[1]/div/div[3]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/main/div/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[1]/form/div/table/tbody/tr/td[8]/div[2]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("//*[@id='acesso']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //input = driver.FindElement(By.XPath("//*[@id='form-acesso']/div/input"));
            //input.Clear();
            //input.SendKeys("FUV05HRO6BN");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//*[@id='acessar']"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div/div/div[2]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/main/div/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            ////
            //for (var i = 0; i < 2; i++)
            //{
            //    button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[1]/form/div/table/tbody/tr/td[8]/div/button"));
            //    button.Click();
            //    System.Threading.Thread.Sleep(1000);

            //    button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //    button.Click();
            //    System.Threading.Thread.Sleep(2000);
            //}

            //button = driver.FindElement(By.XPath("//*[@id=\"sair\"]"));
            //button.Click();
            //System.Threading.Thread.Sleep(2000);

            //clienteTest.LoginCliente(Cliente);
            //System.Threading.Thread.Sleep(2000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div[1]/div/div[5]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(8000);
        }

        [Test]
        public void SolicitarDevolucaoRecusada()
        {
            //driver.Navigate().GoToUrl("http://localhost");
            //System.Threading.Thread.Sleep(3000);

            //ClienteTest clienteTest = new ClienteTest(driver);

            //Client Cliente = new();
            //Cliente.Email = "edan.sales@icloud.com.br";
            //Cliente.Senha = "Padrao.1235";

            //clienteTest.LoginCliente(Cliente);
            //System.Threading.Thread.Sleep(2000);

            //IWebElement button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div[1]/div/div[1]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//span[contains(text(), 'ENTREGUE')]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(3000);

            //button = driver.FindElement(By.XPath("//*[@id='solicitar-devolucao']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(2000);

            //button = driver.FindElement(By.XPath("//*[@id=\"from-solicitacao\"]/div[1]/table/tbody/tr[1]/td[1]/div/label/input"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //IWebElement input = driver.FindElement(By.XPath("//*[@id=\"from-solicitacao\"]/div[2]/label/textarea"));
            //input.Clear();
            //input.SendKeys("Laboris quis labore officia fugiat eiusmod. Labore ad nisi laboris officia laboris commodo nostrud non adipisicing. Veniam laborum ad enim irure duis sit sint duis aliqua mollit est. Pariatur sunt quis occaecat est. Nulla dolore cupidatat cillum exercitation qui fugiat quis aute pariatur magna. Velit elit et aliqua qui mollit consequat laboris nulla cupidatat qui sunt nostrud aliqua pariatur.");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/main/div/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("//*[@id='acesso']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //input = driver.FindElement(By.XPath("//*[@id='form-acesso']/div/input"));
            //input.Clear();
            //input.SendKeys("FUV05HRO6BN");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//*[@id='acessar']"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div/div/div[3]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/main/div/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[1]/form/div/table/tbody/tr/td[8]/div[1]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(2000);


            //input = driver.FindElement(By.XPath("//*[@id=\"from-solicitacao\"]/div/label/textarea"));
            //input.Clear();
            //input.SendKeys("Laboris quis labore officia fugiat eiusmod. Labore ad nisi laboris officia laboris commodo nostrud non adipisicing. Veniam laborum ad enim irure duis sit sint duis aliqua mollit est. Pariatur sunt quis occaecat est. Nulla dolore cupidatat cillum exercitation qui fugiat quis aute pariatur magna. Velit elit et aliqua qui mollit consequat laboris nulla cupidatat qui sunt nostrud aliqua pariatur.");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(2000);
        }

        [Test]
        public void SolicitarDevolucao()
        {
            //driver.Navigate().GoToUrl("http://localhost");
            //System.Threading.Thread.Sleep(3000);

            //ClienteTest clienteTest = new ClienteTest(driver);

            //Client Cliente = new();
            //Cliente.Email = "edan.sales@icloud.com.br";
            //Cliente.Senha = "Padrao.1235";

            //clienteTest.LoginCliente(Cliente);
            //System.Threading.Thread.Sleep(2000);

            //IWebElement button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div[1]/div/div[1]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//span[contains(text(), 'ENTREGUE')]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(3000);

            //button = driver.FindElement(By.XPath("//*[@id='solicitar-devolucao']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(2000);

            //button = driver.FindElement(By.XPath("//*[@id=\"from-solicitacao\"]/div[1]/table/tbody/tr[1]/td[1]/div/label/input"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //IWebElement input = driver.FindElement(By.XPath("//*[@id=\"from-solicitacao\"]/div[2]/label/textarea"));
            //input.Clear();
            //input.SendKeys("Laboris quis labore officia fugiat eiusmod. Labore ad nisi laboris officia laboris commodo nostrud non adipisicing. Veniam laborum ad enim irure duis sit sint duis aliqua mollit est. Pariatur sunt quis occaecat est. Nulla dolore cupidatat cillum exercitation qui fugiat quis aute pariatur magna. Velit elit et aliqua qui mollit consequat laboris nulla cupidatat qui sunt nostrud aliqua pariatur.");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/main/div/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("//*[@id='acesso']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //input = driver.FindElement(By.XPath("//*[@id='form-acesso']/div/input"));
            //input.Clear();
            //input.SendKeys("FUV05HRO6BN");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//*[@id='acessar']"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div/div/div[3]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/main/div/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[1]/form/div/table/tbody/tr/td[8]/div[2]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(2000);

            //button = driver.FindElement(By.XPath("//*[@id=\"sair\"]"));
            //button.Click();
            //System.Threading.Thread.Sleep(3000);

            //clienteTest.LoginCliente(Cliente);
            //System.Threading.Thread.Sleep(2000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div[1]/div/div[4]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/main/div/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[1]/form/div/table/tbody/tr/td[8]/div[2]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("//*[@id='acesso']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //input = driver.FindElement(By.XPath("//*[@id='form-acesso']/div/input"));
            //input.Clear();
            //input.SendKeys("FUV05HRO6BN");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//*[@id='acessar']"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div/div/div[3]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/main/div/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(4000);

            ////
            //for (var i = 0; i < 2; i++)
            //{
            //    button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[1]/form/div/table/tbody/tr/td[8]/div/button"));
            //    button.Click();
            //    System.Threading.Thread.Sleep(1000);

            //    button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //    button.Click();
            //    System.Threading.Thread.Sleep(2000);
            //}

            //button = driver.FindElement(By.XPath("//*[@id=\"sair\"]"));
            //button.Click();
            //System.Threading.Thread.Sleep(2000);

            //clienteTest.LoginCliente(Cliente);
            //System.Threading.Thread.Sleep(2000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div[1]/div/div[5]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(8000);
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
