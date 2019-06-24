using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SampleProject
{
    public static class WaitHelper
    {
        public static void ElementIsVisible(IWebDriver driver, By bylocator)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(bylocator));
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message + "Error waiting for element");
            }
        }
    }
}
