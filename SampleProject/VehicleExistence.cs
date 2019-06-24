using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SampleProject
{
    [Binding]
    public sealed class VehicleExistence
    {
        [Given(@"I'm on the dealer portal ""(.*)""")]
        public void GivenIMOnTheDealerPortal(string dealerportal)
        {
            NavigationHelper.NavigateToUrl(dealerportal);
            ObjectRepository.DealerPortal = new PageObjects(ObjectRepository.Driver);
        }
        [When(@"I enter a  valid ""(.*)"" that is not present in the system")]
        [When(@"I enter an invalid ""(.*)""")]
        [When(@"I enter a valid ""(.*)"" that is present in the system")]
        public void WhenIEnterAValidInTheInputBox(string regno)
        {
            ObjectRepository.DealerPortal.InputRegistrationNo(regno);
            ObjectRepository.DealerPortal.FindDetails();
        }

        [Then(@"I should be able to see the details of the vehicle")]
        public void ThenIShouldBeAbleToSeeTheDetailsOfTheVehicle()
        {
            string result = ObjectRepository.DealerPortal.GetResultText();
            Assert.IsTrue(result.Contains("Result for"));
        }
        [Then(@"""(.*)"" message should appear")]
        public void ThenMessageShouldAppear(string message)
        {
            string result = ObjectRepository.DealerPortal.GetResultText();
            Assert.IsTrue(result.Equals(message));
        }

        [Then(@"""(.*)"" error should appear")]
        public void ThenErrorShouldAppear(string errormessage)
        {
            string result = ObjectRepository.DealerPortal.GetErrorText();
            Assert.IsTrue(result.Equals(errormessage));
        }
    }
}
