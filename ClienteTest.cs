using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TestEcommerceNUnit.Models;

namespace TestEcommerceNUnit
{
    public class ClienteTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }

        public void PreencheEndereco(Address Endereco, string Tipo)
        {
            IWebElement input = driver.FindElement(By.CssSelector($@"[data-test-target='{Tipo}'] input[name$='cep']"));
            input.Clear();
            input.SendKeys(Endereco.CEP);
            System.Threading.Thread.Sleep(300);

            IWebElement button = driver.FindElement(By.CssSelector($@"[data-test-target='{Tipo}'] .viacep"));
            button.Click();
            System.Threading.Thread.Sleep(300);

            IWebElement select = driver.FindElement(By.CssSelector($@"[data-test-target='{Tipo}'] select[name$='tipoLogradouro']"));
            var selectElement = new SelectElement(select);
            selectElement.SelectByText(Endereco.TipoLogradouro);
            System.Threading.Thread.Sleep(300);

            select = driver.FindElement(By.CssSelector($@"[data-test-target='{Tipo}'] select[name$='tipoResidencia']"));
            selectElement = new SelectElement(select);
            selectElement.SelectByText(Endereco.TipoResidencia);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='{Tipo}'] input[name$='numero']"));
            input.Clear();
            input.SendKeys(Endereco.Numero);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='{Tipo}'] input[name$='nomeEndereco']"));
            input.Clear();
            input.SendKeys(Endereco.NomeEndereco);
            System.Threading.Thread.Sleep(300);

            button = driver.FindElement(By.CssSelector($@"[data-test-target='{Tipo}'] [data-action='next']"));
            button.Click();
            System.Threading.Thread.Sleep(300);
        }

        public void CadastroCliente(Client Cliente)
        {
            IWebElement input = driver.FindElement(By.CssSelector($@"[data-test-target='dados-cadastrais'] input[name$='nome']"));
            input.Clear();
            input.SendKeys(Cliente.Nome);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='dados-cadastrais'] input[name$='sobrenome']"));
            input.Clear();
            input.SendKeys(Cliente.Sobrenome);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='dados-cadastrais'] input[name$='cpf']"));
            input.Clear();
            input.SendKeys(Cliente.CPF);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='dados-cadastrais'] input[name$='celular']"));
            input.Clear();
            input.SendKeys(Cliente.Celular);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='dados-cadastrais'] input[name$='telefone']"));
            input.Clear();
            input.SendKeys(Cliente.Telefone);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='dados-cadastrais'] input[name$='rg']"));
            input.Clear();
            input.SendKeys(Cliente.RG);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='dados-cadastrais'] input[name$='dataNascimento']"));
            input.Clear();
            input.SendKeys(Cliente.DataNascimento.ToString("d"));
            System.Threading.Thread.Sleep(300);

            IWebElement select = driver.FindElement(By.CssSelector($@"[data-test-target='dados-cadastrais'] select[name$='genero']"));
            var selectElement = new SelectElement(select);
            selectElement.SelectByText(Cliente.Genero);
            System.Threading.Thread.Sleep(300);

            IWebElement button = driver.FindElement(By.CssSelector($@"[data-test-target='dados-cadastrais'] [data-action='next']"));
            button.Click();
            System.Threading.Thread.Sleep(300);
        }

        public void CartaoCredito(Card Cartao)
        {
            IWebElement select = driver.FindElement(By.CssSelector($@"[data-test-target='informacoes-pagamento'] select[name$='idBandeira']"));
            var selectElement = new SelectElement(select);
            selectElement.SelectByText(Cartao.NomeBandeira);
            System.Threading.Thread.Sleep(300);

            IWebElement input = driver.FindElement(By.CssSelector($@"[data-test-target='informacoes-pagamento'] input[name$='nomeTitular']"));
            input.Clear();
            input.SendKeys(Cartao.NomeTitular);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='informacoes-pagamento'] input[name$='nomeCartao']"));
            input.Clear();
            input.SendKeys(Cartao.NomeCartao);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='informacoes-pagamento'] input[name$='CPFTitular']"));
            input.Clear();
            input.SendKeys(Cartao.CPFTitular);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='informacoes-pagamento'] input[name$='numero']"));
            input.Clear();
            input.SendKeys(Cartao.Numero);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='informacoes-pagamento'] input[name$='mes']"));
            input.Clear();
            input.SendKeys(Cartao.DataValidade.Split("/")[0]);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='informacoes-pagamento'] input[name$='ano']"));
            input.Clear();
            input.SendKeys(Cartao.DataValidade.Split("/")[1]);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='informacoes-pagamento'] input[name$='codigoSeguranca']"));
            input.Clear();
            input.SendKeys(Cartao.CodigoSeguranca);
            System.Threading.Thread.Sleep(300);

            IWebElement button = driver.FindElement(By.CssSelector($@"[data-test-target='informacoes-pagamento'] [data-action='next']"));
            button.Click();
            System.Threading.Thread.Sleep(300);
        }

        [Test]
        public void CadastraCliente()
        {
            /** Navegar para a pagina de cadastro */
            driver.Navigate().GoToUrl("http://localhost/cadastro/cliente");

            /** Cadastro de dados pessoais */
            Client Cliente = new();
            Cliente.Email = "sabrina.alessandra@gmail.com.br";
            Cliente.Senha = "2hAxOT85kf.";

            Cliente.Nome = "Sabrina";
            Cliente.Sobrenome = "Alessandra";
            Cliente.CPF = "874.973.127-07";
            Cliente.RG = "22.799.219-2";
            Cliente.Telefone = "(22) 3720-7677";
            Cliente.Celular = "(22) 98229-4728";
            Cliente.DataNascimento = new DateTime(1994, 06, 17);
            Cliente.Genero = "Feminino";

            CadastroCliente(Cliente);

            /** Cadastro do Endereco prinicpal */
            Address Endereco = new();
            Endereco.CEP = "78745-550";
            Endereco.TipoLogradouro = "Rua";
            Endereco.TipoResidencia = "Casa";
            Endereco.Numero = "234";
            Endereco.NomeEndereco = "Minha Casa";

            PreencheEndereco(Endereco, "endereco-prinicpal");

            /** Cadastro do Cart�o de credito */
            Card Cartao = new();
            Cartao.NomeBandeira = "Mastercard";
            Cartao.NomeTitular = Cliente.Nome + " " + Cliente.Sobrenome;
            Cartao.NomeCartao = "NuCard";
            Cartao.CPFTitular = Cliente.CPF;
            Cartao.Numero = "5424 0385 5545 9947";
            Cartao.DataValidade = "02/2025";
            Cartao.CodigoSeguranca = "746";

            CartaoCredito(Cartao);

            /** Cadastro do Endereco cobranca */
            Endereco.CEP = "60055-100";
            Endereco.TipoLogradouro = "Rua";
            Endereco.TipoResidencia = "Apartamento";
            Endereco.Numero = "S/N";
            Endereco.NomeEndereco = "Casa da v�";

            PreencheEndereco(Endereco, "endereco-cobranca");

            /** Preenche dados de acesso */
            IWebElement input = driver.FindElement(By.CssSelector($@"[data-test-target='infomacoes-acesso'] input[name$='email']"));
            input.Clear();
            input.SendKeys(Cliente.Email);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='infomacoes-acesso'] input[name$='senha']"));
            input.Clear();
            input.SendKeys(Cliente.Senha);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"[data-test-target='infomacoes-acesso'] input[name$='confirmaSenha']"));
            input.Clear();
            input.SendKeys(Cliente.Senha);
            System.Threading.Thread.Sleep(300);

            IWebElement button = driver.FindElement(By.XPath($@"//*[@id='submit']"));
            button.Click();
            System.Threading.Thread.Sleep(300);

            // Aguarda alguns segundos para visualizar o resultado (opcional)
            System.Threading.Thread.Sleep(5000);

            Assert.Pass();
        }

        public void LoginCliente()
        {
            /** Navegar para a pagina inical */
            driver.Navigate().GoToUrl("http://localhost/cadastro/cliente");

            Client Cliente = new();
            Cliente.Email = "sabrina.alessandra@gmail.com.br";
            Cliente.Senha = "2hAxOT85kf.";

            IWebElement button = driver.FindElement(By.XPath($@"//*[@id='entrar']"));
            button.Click();
            System.Threading.Thread.Sleep(500);

            /** Preenche acesso */
            IWebElement input = driver.FindElement(By.XPath($@"//*[@id='login-cliente']/label[1]/label/input"));
            input.Clear();
            input.SendKeys(Cliente.Email);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.XPath($@"//*[@id='login-cliente']/label[2]/label/input"));
            input.Clear();
            input.SendKeys(Cliente.Senha);
            System.Threading.Thread.Sleep(300);

            button = driver.FindElement(By.XPath($@"/html/body/div/div/div[6]/button[1]"));
            button.Click();
            System.Threading.Thread.Sleep(500);
        }

        [Test]
        public void BuscaCliente()
        {
            LoginCliente();

            System.Threading.Thread.Sleep(5000);

            Assert.Pass();
        }

        [Test]
        public void EditaCliente()
        {
            LoginCliente();

            IWebElement button = driver.FindElement(By.XPath($@"/html/body/main/div[2]/div/div[1]/div/div[2]/a"));
            button.Click();
            System.Threading.Thread.Sleep(500);

            button = driver.FindElement(By.XPath($@"/html/body/main/div[2]/div[2]/div[1]/div[2]/div/button"));
            button.Click();
            System.Threading.Thread.Sleep(500);

            Client Cliente = new();

            Cliente.Nome = "Geraldo";
            Cliente.Sobrenome = "Vitor Jesus";
            Cliente.CPF = "332.318.701-60";
            Cliente.RG = "47.672.922-1";
            Cliente.Telefone = "(65) 3832-7624";
            Cliente.Celular = "(65) 98321-5187";
            Cliente.DataNascimento = new DateTime(1990, 03, 18);
            Cliente.Genero = "Masculino";

            IWebElement input = driver.FindElement(By.CssSelector($@"#form-altera-cliente input[name$='nome']"));
            input.Clear();
            input.SendKeys(Cliente.Nome);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"#form-altera-cliente input[name$='sobrenome']"));
            input.Clear();
            input.SendKeys(Cliente.Sobrenome);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"#form-altera-cliente input[name$='cpf']"));
            input.Clear();
            input.SendKeys(Cliente.CPF);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"#form-altera-cliente input[name$='celular']"));
            input.Clear();
            input.SendKeys(Cliente.Celular);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"#form-altera-cliente input[name$='telefone']"));
            input.Clear();
            input.SendKeys(Cliente.Telefone);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"#form-altera-cliente input[name$='rg']"));
            input.Clear();
            input.SendKeys(Cliente.RG);
            System.Threading.Thread.Sleep(300);

            input = driver.FindElement(By.CssSelector($@"#form-altera-cliente input[name$='dataNascimento']"));
            input.Clear();
            input.SendKeys(Cliente.DataNascimento.ToString("d"));
            System.Threading.Thread.Sleep(300);

            IWebElement select = driver.FindElement(By.CssSelector($@"#form-altera-cliente select[name$='genero']"));
            var selectElement = new SelectElement(select);
            selectElement.SelectByText(Cliente.Genero);
            System.Threading.Thread.Sleep(300);

            button = driver.FindElement(By.XPath($@"/html/body/div/div/div[6]/button[3]"));
            button.Click();
            System.Threading.Thread.Sleep(500);

            System.Threading.Thread.Sleep(5000);

            Assert.Pass();
        }

        [Test]
        public void ApagaCliente()
        {
            LoginCliente();

            IWebElement button = driver.FindElement(By.XPath($@"//*[@id='excluir-conta']"));
            button.Click();
            System.Threading.Thread.Sleep(800);

            button = driver.FindElement(By.XPath($@"/html/body/div/div/div[6]/button[3]"));
            button.Click();
            System.Threading.Thread.Sleep(500);

            System.Threading.Thread.Sleep(5000);

            Assert.Pass();
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