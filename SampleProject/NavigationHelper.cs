using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string Url)
        {
           ObjectRepository.Driver.Navigate().GoToUrl(Url);
        }
    }
}
