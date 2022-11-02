using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using Xunit;

namespace SeleniumTestProject
{
    public class FirstSeleniumTests { // Nommer ici la class de test

        [Fact]
        public void CorrectTitleDisplayed_When_NavigateToHomePage() // Décrire ici le contexte comme nom de fonction
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser); 
            // DriverManager est responsable du téléchargement de la bonne version des pilotes
            var chromeOptions = new ChromeOptions(); // Option headless pour cacher la fenetre du navigateur en cours d'execution pendant le test
            chromeOptions.AddArguments("--headless");
            using var driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl("https://lambdatest.github.io/sample-todo-app/"); // Url sur laquelle on navigue

            Assert.Equal("Sample page - lambdatest.com", driver.Title);
        }
    }
}
