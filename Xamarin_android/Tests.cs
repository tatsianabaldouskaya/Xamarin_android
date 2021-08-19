using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;

namespace Xamarin_android
{
    [TestFixture]
    public class Tests
    {
        private string newApp = @"C:/Users/Tatsiana_Baldouskaya/source/repos/Xamarin_android/onliner.apk";


        [Test]
        public void CloudTest()
        {
            AppInstaller.OnCreate();
        }
    }
}
