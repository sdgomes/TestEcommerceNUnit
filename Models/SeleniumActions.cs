using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEcommerceNUnit.Models
{
    public class SeleniumActions
    {
        protected WebDriverWait wait;

        protected void Input(string caminho, string texto, string buscar = "")
        {
            By buscador = By.XPath(caminho);

            switch (buscar)
            {
                case "CSS":
                    buscador = By.CssSelector(caminho);
                    break;
            }

            var input = wait.Until(ExpectedConditions.ElementIsVisible(buscador));
            input.Clear();
            input.SendKeys(texto);
            System.Threading.Thread.Sleep(1000);
        }

        protected void Select(string caminho, string texto, string buscar = "")
        {
            By buscador = By.XPath(caminho);

            switch (buscar)
            {
                case "CSS":
                    buscador = By.CssSelector(caminho);
                    break;
            }

            var selectElement = new SelectElement(wait.Until(ExpectedConditions.ElementIsVisible(buscador)));
            selectElement.SelectByText(texto);
            System.Threading.Thread.Sleep(1000);
        }

        protected void Click(string caminho, string buscar = "")
        {
            By buscador = By.XPath(caminho);

            switch (buscar)
            {
                case "CSS":
                    buscador = By.CssSelector(caminho);
                    break;
            }

            wait.Until(ExpectedConditions.ElementToBeClickable(buscador)).Click();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
