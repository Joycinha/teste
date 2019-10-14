using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Collections.Generic;

namespace TesteJoyce
{

    [Binding]
    public class PesquisaDePassagemSteps
    {

        private static IWebDriver driver = new ChromeDriver();


        [Given(@"que eu acesse o site da Gol")]
        public void DadoQueEuAcesseOSiteDaGol()

        {
            driver.Navigate().GoToUrl("https://www.voegol.com.br/pt");
        }

        [When(@"eu informo a origem e destino")]
        public void QuandoEuInformoAOrigemEDestino()


        {
            IWebElement txtOrigem = driver.FindElement(By.XPath("//*[@id='purchase-box']/form[2]/div[1]/div[2]/div[1]"));
            txtOrigem.Click();
            IWebElement txtOrigem2 = driver.FindElement(By.Id("header-chosen-origin"));
            txtOrigem2.SendKeys("SDU");
            txtOrigem2.SendKeys(Keys.Enter);
            IWebElement txtDestino = driver.FindElement(By.XPath("//*[@id='purchase-box']/form[2]/div[1]/div[3]/div[1]/div[1]"));
            txtDestino.Click();
            IWebElement txtDestino2 = driver.FindElement(By.Id("header-chosen-destiny"));
            txtDestino2.SendKeys("GRU");
            txtDestino2.SendKeys(Keys.Enter);

        }

        [When(@"seleciono a data de ida e de volta")]
        public void QuandoSelecionoADataDeIdaEDeVolta()

        {
            //IWebElement dataIda = driver.FindElement(By.Id("datepickerGo"));
            //dataIda.Click();
            //IWebElement dataAtual = driver.FindElement(By.ClassName("ui-state-default ui-state-highlight ui-state-active"));
            //dataAtual = DateTime.Now;
                   
           // IWebElement dataVolta = driver.FindElement(By.Id("datepickerBack"));         
           // dataVolta.Click();
        }


        [When(@"seleciono a quantidade de passageiros")]
        public void QuandoSelecionoAQuantidadeDePassageiros()
        {
            IWebElement qntAdulto = driver.FindElement(By.ClassName("number"));
            qntAdulto.Click();
            qntAdulto.Clear();
            qntAdulto.SendKeys("2");
        }

        [Then(@"o sistema me retornará o resultado da pesquisa")]
        public void EntaoOSistemaMeRetornaraOResultadoDaPesquisa()

        {
            IWebElement compreAqui = driver.FindElement(By.Id("btn-box-buy"));
            compreAqui.Click();
        }

        [Then(@"eu selecionarei a menor tarifa do dia")]
        public void EntaoEuSelecionareiAMenorTarifaDoDia()

        {
            IWebElement menorPreço = driver.FindElement(By.ClassName("lessPrice"));
            menorPreço.Click();
        }
    }

}