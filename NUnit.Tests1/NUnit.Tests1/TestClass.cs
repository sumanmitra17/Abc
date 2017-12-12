﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            IWebDriver dr = new ChromeDriver(@"E:\Suman\Softwares\Cell\Visual Studio\Driver");
            dr.Url = "https://www.google.com/";
            String s = dr.Title;
            Console.WriteLine(s);
        }
    }
}
