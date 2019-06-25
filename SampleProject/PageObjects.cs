using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SampleProject
{

    public class PageObjects
    {
        private readonly IWebDriver driver;
        public PageObjects(IWebDriver _driver)
        {
            PageFactory.InitElements(_driver, this);
            this.driver = _driver;
        }

        [FindsBy(How = How.Id, Using = "vehicleReg")]
        private IWebElement vehicleReg;

        [FindsBy(How = How.Name, Using = "btnfind")]
        private IWebElement btnFind;

        [FindsBy(How = How.XPath, Using = "//*[@id='page-container']/descendant::div[@class='result']")]
        private readonly IWebElement resultText;

        private readonly By result = By.ClassName("result");

        [FindsBy(How = How.XPath, Using = "//*[@id='page-container']/descendant::div[@class='error-required']")]
        private readonly IWebElement errorRequired;

        private readonly By error = By.ClassName("error-required");
        public void InputRegistrationNo(string regno)
        {
            vehicleReg.SendKeys(regno);
        }
         public void FindDetails()
        {
            btnFind.Click();
        }

        public string GetResultText()
        {
            WaitHelper.ElementIsVisible(driver, result);
            string text = resultText.Text;
            return text;
        }
        public string GetErrorText()
        {
            WaitHelper.ElementIsVisible(driver, error);
            string errortext = errorRequired.Text;
            return errortext;
        }
    }
}

