using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    public class ObjectRepository
    {
        public static IWebDriver Driver { get; set; }
        public static PageObjects DealerPortal;
    }
}
