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
    class CompraTest
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
        public void CompraSemLogin()
        {
            //driver.Navigate().GoToUrl("http://localhost/produtos");
            //System.Threading.Thread.Sleep(3000);

            ///*Item no carrinho*/
            //IWebElement button = driver.FindElement(By.XPath("//*[@id='shop-content']/div/div/div[3]/div/div[2]/h4/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[2]/form/div[3]/div/button[2]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[2]/form/button[2]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);


            //button = driver.FindElement(By.XPath("/html/body/main/div[1]/div/div/div[2]/ul/li[2]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            ///*Outro item no carrinho*/
            //button = driver.FindElement(By.XPath("//*[@id='shop-content']/div/div/div[1]/div/div[2]/h4/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[2]/form/button[2]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            ///*Vai para o carrinho*/
            //button = driver.FindElement(By.XPath("/html/body/header/div[2]/div/div/div[3]/div/div/div[2]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(3000);

            ///*Calcula frete */
            //IWebElement input = driver.FindElement(By.XPath("//*[@id='lista-produtos']/div[2]/div/div[1]/div/div/div[1]/input"));
            //input.Clear();
            //input.SendKeys("08740-450");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//*[@id='lista-produtos']/div[2]/div/div[1]/div/div/div[2]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(3000);

            ///*Vai pra tela de cadastro */
            //button = driver.FindElement(By.XPath("//*[@id='lista-produtos']/div[2]/div/div[2]/div/div[3]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(500);

            //Client Cliente = new();
            //Cliente.Email = "tiago_assuncao@kascher.com.br";
            //Cliente.Senha = "m2xNzOQPfn.";

            //Cliente.Nome = "Tiago";
            //Cliente.Sobrenome = "Assunção";
            //Cliente.CPF = "441.739.269-28";
            //Cliente.RG = "22.085.455-5";
            //Cliente.Telefone = "(41) 3638-4325";
            //Cliente.Celular = "(41) 98672-8392";
            //Cliente.DataNascimento = new DateTime(2002, 01, 24);
            //Cliente.Genero = "Masculino";

            //System.Threading.Thread.Sleep(3000);

            //ClienteTest clienteTest = new ClienteTest(driver);
            //clienteTest.CadastroCliente(Cliente);

            //Address Endereco = new();
            //Endereco.CEP = "83550-970";
            //Endereco.TipoLogradouro = "Avenida";
            //Endereco.TipoResidencia = "Apartamento";
            //Endereco.Numero = "56 - Bloco B";
            //Endereco.NomeEndereco = "Minha Casa";

            //clienteTest.PreencheEndereco(Endereco, "endereco-prinicpal");

            //Card Cartao = new();
            //Cartao.NomeBandeira = "Visa";
            //Cartao.NomeTitular = Cliente.Nome + " " + Cliente.Sobrenome;
            //Cartao.NomeCartao = "Mey Card";
            //Cartao.CPFTitular = Cliente.CPF;
            //Cartao.Numero = "4485 0429 4065 4583";
            //Cartao.DataValidade = "12/2024";
            //Cartao.CodigoSeguranca = "202";

            //clienteTest.CartaoCredito(Cartao);
            //clienteTest.PreencheEndereco(Endereco, "endereco-cobranca");

            //input = driver.FindElement(By.CssSelector("[data-test-target='infomacoes-acesso'] input[name$='email']"));
            //input.Clear();
            //input.SendKeys(Cliente.Email);
            //System.Threading.Thread.Sleep(1000);

            //input = driver.FindElement(By.CssSelector("[data-test-target='infomacoes-acesso'] input[name$='senha']"));
            //input.Clear();
            //input.SendKeys(Cliente.Senha);
            //System.Threading.Thread.Sleep(1000);

            //input = driver.FindElement(By.CssSelector("[data-test-target='infomacoes-acesso'] input[name$='confirmaSenha']"));
            //input.Clear();
            //input.SendKeys(Cliente.Senha);
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//*[@id='submit']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(5000);

            ///* FInaliza compra */
            //button = driver.FindElement(By.XPath("//*[@id='container-enderecos']/div[1]/label"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //IWebElement element = driver.FindElement(By.XPath("//*[@id='container-enderecos']/div[1]/label/div/div/div[1]"));
            //var CEP = element.Text;
            //System.Threading.Thread.Sleep(1000);

            //input = driver.FindElement(By.XPath("/html/body/main/section/div[2]/div/div[2]/div/div[3]/form/div/div[1]/input"));
            //input.Clear();
            //input.SendKeys(CEP);
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/section/div[2]/div/div[2]/div/div[3]/form/div/div[2]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(3000);

            //button = driver.FindElement(By.XPath("//*[@id='container-cartoes']/label[1]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/section/div[2]/div/div[2]/div/div[4]/div[3]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(5000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[1]/div/div/div[2]/ul/li[3]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(5000);

            //Assert.Pass();
        }

        [Test]
        public void CompraComLogin()
        {
            //driver.Navigate().GoToUrl("http://localhost");
            //System.Threading.Thread.Sleep(3000);

            //ClienteTest clienteTest = new ClienteTest(driver);

            //Client Cliente = new();
            //Cliente.Email = "coby.souza@icloud.com";
            //Cliente.Senha = "Padrao.1235";

            //clienteTest.LoginCliente(Cliente);

            //System.Threading.Thread.Sleep(2000);

            //driver.Navigate().GoToUrl("http://localhost/produtos");
            //System.Threading.Thread.Sleep(3000);

            ///*Item no carrinho*/
            //IWebElement button = driver.FindElement(By.XPath("//*[@id='shop-content']/div/div/div[3]/div/div[2]/h4/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[2]/form/div[3]/div/button[2]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[2]/form/button[2]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);


            //button = driver.FindElement(By.XPath("/html/body/main/div[1]/div/div/div[2]/ul/li[2]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            ///*Outro item no carrinho*/
            //button = driver.FindElement(By.XPath("//*[@id='shop-content']/div/div/div[1]/div/div[2]/h4/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[2]/form/button[2]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            ///*Vai para o carrinho*/
            //button = driver.FindElement(By.XPath("/html/body/header/div[2]/div/div/div[3]/div/div/div[2]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(3000);

            ///*Calcula frete */
            //IWebElement input = driver.FindElement(By.XPath("//*[@id='lista-produtos']/div[2]/div/div[1]/div/div/div[1]/input"));
            //input.Clear();
            //input.SendKeys("08740-450");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//*[@id='lista-produtos']/div[2]/div/div[1]/div/div/div[2]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(3000);

            //button = driver.FindElement(By.XPath("//*[@id='lista-produtos']/div[2]/div/div[2]/div/div[3]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(500);


            ///* Finaliza compra */
            //button = driver.FindElement(By.XPath("//*[@id='container-enderecos']/div[1]/label"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //IWebElement element = driver.FindElement(By.XPath("//*[@id='container-enderecos']/div[1]/label/div/div/div[1]"));
            //var CEP = element.Text;
            //System.Threading.Thread.Sleep(1000);

            //input = driver.FindElement(By.XPath("/html/body/main/section/div[2]/div/div[2]/div/div[3]/form/div/div[1]/input"));
            //input.Clear();
            //input.SendKeys(CEP);
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/section/div[2]/div/div[2]/div/div[3]/form/div/div[2]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(3000);

            //// Escolhe cartao
            //button = driver.FindElement(By.XPath("//*[@id='container-cartoes']/label[1]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/section/div[2]/div/div[2]/div/div[4]/div[3]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(5000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[1]/div/div/div[2]/ul/li[3]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(5000);
            //Assert.Pass();
        }

        [Test]
        public void CaminhoFeliz()
        {
            //driver.Navigate().GoToUrl("http://localhost");
            //System.Threading.Thread.Sleep(3000);

            //Client Cliente = new();
            //Cliente.Email = "candace.pinheiro@google.com";
            //Cliente.Senha = "Padrao.1235";

            //ClienteTest clienteTest = new ClienteTest(driver);
            //clienteTest.LoginCliente(Cliente);

            //System.Threading.Thread.Sleep(2000);

            //driver.Navigate().GoToUrl("http://localhost/produtos");
            //System.Threading.Thread.Sleep(3000);

            ///*Item no carrinho*/
            //IWebElement button = driver.FindElement(By.XPath("//*[@id='shop-content']/div/div/div[3]/div/div[2]/h4/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[2]/form/div[3]/div/button[2]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[2]/form/button[2]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);


            //button = driver.FindElement(By.XPath("/html/body/main/div[1]/div/div/div[2]/ul/li[2]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            ///*Outro item no carrinho*/
            //button = driver.FindElement(By.XPath("//*[@id='shop-content']/div/div/div[1]/div/div[2]/h4/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[2]/form/button[2]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[1]/div/div/div[2]/ul/li[2]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            ///*Outro item no carrinho*/

            //button = driver.FindElement(By.XPath("//*[@id='shop-content']/div/div/div[1]/div/div[2]/h4/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div[2]/form/button[2]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            ///*Vai para o carrinho*/
            //button = driver.FindElement(By.XPath("/html/body/header/div[2]/div/div/div[3]/div/div/div[2]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(3000);

            ////
            //for (var i = 0; i < 2; i++)
            //{
            //    button = driver.FindElement(By.XPath("//*[@id=\"lista-produtos\"]/div[1]/table/tbody/tr[1]/td[3]/div/button[2]"));
            //    button.Click();
            //    System.Threading.Thread.Sleep(1000);
            //}

            //button = driver.FindElement(By.XPath("//*[@id=\"lista-produtos\"]/div[2]/div/div[2]/div/div[3]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(3000);

            ///* Finaliza compra */
            //button = driver.FindElement(By.XPath("//*[@id='container-enderecos']/div[1]/label"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //IWebElement element = driver.FindElement(By.XPath("//*[@id='container-enderecos']/div[1]/label/div/div/div[1]"));
            //var CEP = element.Text;
            //System.Threading.Thread.Sleep(1000);

            //IWebElement input = driver.FindElement(By.XPath("/html/body/main/section/div[2]/div/div[2]/div/div[3]/form/div/div[1]/input"));
            //input.Clear();
            //input.SendKeys(CEP);
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/main/section/div[2]/div/div[2]/div/div[3]/form/div/div[2]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(3000);

            //// Escolhe cartao
            //button = driver.FindElement(By.XPath("//*[@id='container-cartoes']/label[1]"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //// Paga
            //button = driver.FindElement(By.XPath("/html/body/main/section/div[2]/div/div[2]/div/div[4]/div[3]/button"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //System.Threading.Thread.Sleep(5000);

            //try
            //{
            //    element = driver.FindElement(By.XPath("//span[contains(text(), 'Pagamento Recusado')]"));

            //    button = driver.FindElement(By.XPath("//*[@id=\"refazer-pagamento\"]"));
            //    button.Click();
            //    System.Threading.Thread.Sleep(2000);

            //    button = driver.FindElement(By.XPath("//*[@id=\"swal2-html-container\"]/div/div[1]/div/div/label[1]"));
            //    button.Click();
            //    System.Threading.Thread.Sleep(2000);

            //    button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //    button.Click();
            //    System.Threading.Thread.Sleep(4000);
            //}
            //catch (Exception) { }

            //element = driver.FindElement(By.XPath("/html/body/main/div[2]/div[3]/div[1]/div[1]/h2"));
            //var texto = element.Text;
            //System.Threading.Thread.Sleep(1000);

            //var npedido = String.Join("", System.Text.RegularExpressions.Regex.Split(texto, @"[^\d]"));

            //// vai para aprovacao do pedido
            //button = driver.FindElement(By.XPath("//*[@id='acesso']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //input = driver.FindElement(By.XPath("//*[@id='form-acesso']/div/input"));
            //input.Clear();
            //input.SendKeys("FUV05HRO6BN");
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("//*[@id='acessar']"));
            //button.Click();
            //System.Threading.Thread.Sleep(3000);

            //button = driver.FindElement(By.XPath("/html/body/main/div[2]/div/div/div/div[8]/a"));
            //button.Click();
            //System.Threading.Thread.Sleep(9000);

            //input = driver.FindElement(By.XPath("//*[@id='dt-search-0']"));
            //input.Clear();
            //input.SendKeys(npedido);
            //System.Threading.Thread.Sleep(3000);

            //button = driver.FindElement(By.XPath("//*[@id='registros']/tbody/tr[1]/td[9]/div[1]/button[@data-etapa='COMPRA APROVADA']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(9000);

            //input = driver.FindElement(By.XPath("//*[@id='dt-search-0']"));
            //input.Clear();
            //input.SendKeys(npedido);
            //System.Threading.Thread.Sleep(1000);

            ////
            //button = driver.FindElement(By.XPath("//*[@id='registros']/tbody/tr[1]/td[9]/div[1]/button[@data-etapa='EM PREPARAÇÃO']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(9000);

            //input = driver.FindElement(By.XPath("//*[@id='dt-search-0']"));
            //input.Clear();
            //input.SendKeys(npedido);
            //System.Threading.Thread.Sleep(1000);

            ////
            //button = driver.FindElement(By.XPath("//*[@id='registros']/tbody/tr[1]/td[9]/div[1]/button[@data-etapa='A CAMINHO']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(9000);

            //input = driver.FindElement(By.XPath("//*[@id='dt-search-0']"));
            //input.Clear();
            //input.SendKeys(npedido);
            //System.Threading.Thread.Sleep(1000);

            ////
            //button = driver.FindElement(By.XPath("//*[@id='registros']/tbody/tr[1]/td[9]/div[1]/button[@data-etapa='ENTREGUE']"));
            //button.Click();
            //System.Threading.Thread.Sleep(1000);

            //button = driver.FindElement(By.XPath("/html/body/div/div/div[6]/button[3]"));
            //button.Click();
            //System.Threading.Thread.Sleep(9000);

            //input = driver.FindElement(By.XPath("//*[@id='dt-search-0']"));
            //input.Clear();
            //input.SendKeys(npedido);
            //System.Threading.Thread.Sleep(1000);
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
