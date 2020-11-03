using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Threading;
using Xunit;

namespace MakeMyTrip1
{
    public class Class1
    {
        String baseUrl = "https://www.makemytrip.com/";
        [Fact]
        public void MakeMyTripTest()
        { 
            IWebDriver WebDriver;
            WebDriver = new ChromeDriver();
            WebDriver.Url = baseUrl;
            WebDriver.Manage().Window.Maximize();
            WebDriver.FindElement(By.CssSelector(".loginModal")).Click();
            WebDriver.FindElement(By.CssSelector(".lhUser")).Click();
            //.FindElement(By.CssSelector(".we_close")).Click();
            WebDriver.FindElement(By.Id("username")).Click();
            WebDriver.FindElement(By.Id("username")).SendKeys("sruthyks.393@gmail.com");
            WebDriver.FindElement(By.CssSelector(".btnContainer > .capText")).Click();
            WebDriver.FindElement(By.Id("password")).Click();
            // WebDriver.FindElement(By.XPath("//input[@Id='password']").Click();
            WebDriver.FindElement(By.Id("password")).SendKeys("Makemytrip123@");
            WebDriver.FindElement(By.CssSelector(".btnContainer > .capText")).Click();
            WebDriver.FindElement(By.LinkText("Hotels")).Click();
            WebDriver.FindElement(By.CssSelector(".selectHtlCity > label")).Click();
            WebDriver.FindElement(By.CssSelector("#react-autowhatever-1-section-0-item-0 .font12")).Click();
            WebDriver.FindElement(By.CssSelector(".DayPicker-Day--selected:nth-child(5)")).Click();
            WebDriver.FindElement(By.CssSelector(".DayPicker-Day--selected:nth-child(7)")).Click();
            WebDriver.FindElement(By.Id("guest")).Click();
            WebDriver.FindElement(By.CssSelector(".guestCounter:nth-child(2) > li:nth-child(1)")).Click();
            WebDriver.FindElement(By.Id("0")).Click();
            WebDriver.FindElement(By.CssSelector(".btnApply")).Click();
            WebDriver.FindElement(By.Id("hsw_search_button")).Click();

            WebDriver.FindElement(By.CssSelector("#hlistpg_fr_star_category li:nth-child(2) label")).Click();
            {
                var element = WebDriver.FindElement(By.CssSelector("li:nth-child(3) > a:nth-child(2)"));
                Actions builder = new Actions(WebDriver);
                builder.MoveToElement(element).Perform();
            }
            WebDriver.FindElement(By.CssSelector("li:nth-child(2) > a:nth-child(2)")).Click();
            WebDriver.FindElement(By.Id("_Hlisting_area")).Click();
            {
                var element = WebDriver.FindElement(By.CssSelector(".input-range__slider-container:nth-child(3) > .input-range__slider"));
                Actions builder = new Actions(WebDriver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            WebDriver.FindElement(By.CssSelector(".input-range__slider-container:nth-child(3) > .input-range__slider")).Click();
            WebDriver.FindElement(By.Id("htl_id_seo_201001151654409599")).Click();
            WebDriver.FindElement(By.Id("fName")).Click();
            WebDriver.FindElement(By.Id("title")).Click();
            {
                var dropdown = WebDriver.FindElement(By.Id("title"));
                dropdown.FindElement(By.XPath("//option[. = 'Ms']")).Click();
            }
            WebDriver.FindElement(By.Id("title")).Click();
            WebDriver.FindElement(By.Id("fName")).Click();
            WebDriver.FindElement(By.Id("fName")).SendKeys("Sruthy");
            WebDriver.FindElement(By.Id("lName")).Click();
            WebDriver.FindElement(By.Id("lName")).SendKeys("Sasidharan");
            WebDriver.FindElement(By.CssSelector(".font14:nth-child(7) > .checkmarkOuter")).Click();
            WebDriver.FindElement(By.CssSelector(".font14:nth-child(7) label")).Click();
            WebDriver.FindElement(By.CssSelector(".timeSelectInner")).Click();
            {
                var element = WebDriver.FindElement(By.CssSelector(".timeDropdown"));
                Actions builder = new Actions(WebDriver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }

            WebDriver.FindElement(By.CssSelector(".font16:nth-child(5)")).Click();
            WebDriver.FindElement(By.Id("109")).Click();
            WebDriver.FindElement(By.Id("109")).SendKeys("room delivery");
            WebDriver.FindElement(By.CssSelector(".btnPayNow")).Click();
            WebDriver.FindElement(By.CssSelector("#PP > .option_txt")).Click();
            WebDriver.FindElement(By.CssSelector("#currencyList_INR .radio_option")).Click();
            {
                var element = WebDriver.FindElement(By.CssSelector("#currencyList_INR .radio_option"));
                Actions builder = new Actions(WebDriver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = WebDriver.FindElement(By.TagName("body"));
                Actions builder = new Actions(WebDriver);
                builder.MoveToElement(element, 0, 0).Perform();
            }
            WebDriver.FindElement(By.CssSelector("#widgetPayBtn > .pull-left")).Click();

            WebDriver.FindElement(By.Id("PAYMENT_inputVpa")).Click();
            {
                var element = WebDriver.FindElement(By.Id("btn_gen_pmt"));
                Actions builder = new Actions(WebDriver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = WebDriver.FindElement(By.TagName("body"));
                Actions builder = new Actions(WebDriver);
                builder.MoveToElement(element, 0, 0).Perform();
            }
            WebDriver.FindElement(By.Id("PAYMENT_inputVpa")).SendKeys("ssdhfj");
            WebDriver.FindElement(By.Id("makePaymentButton")).Click();
            WebDriver.FindElement(By.CssSelector("#CC > .option_txt")).Click();
            WebDriver.FindElement(By.Id("PAYMENT_cardNumber")).Click();
            WebDriver.FindElement(By.Id("PAYMENT_cardNumber")).SendKeys("5041123052134562");
            WebDriver.FindElement(By.Id("PAYMENT_nameOnCard")).Click();
            WebDriver.FindElement(By.Id("PAYMENT_nameOnCard")).SendKeys("dhfkh");
            WebDriver.FindElement(By.Id("PAYMENT_expiryMonth")).Click();
            {
                var dropdown = WebDriver.FindElement(By.Id("PAYMENT_expiryMonth"));
                dropdown.FindElement(By.XPath("//option[. = '04']")).Click();
            }
            WebDriver.FindElement(By.Id("PAYMENT_expiryMonth")).Click();
            WebDriver.FindElement(By.Id("hiddenMaestroDiv")).Click();
            WebDriver.FindElement(By.Id("PAYMENT_expiryYear")).Click();
            {
                var dropdown = WebDriver.FindElement(By.Id("PAYMENT_expiryYear"));
                dropdown.FindElement(By.XPath("//option[. = '2024']")).Click();
            }
            WebDriver.FindElement(By.Id("PAYMENT_expiryYear")).Click();
            WebDriver.FindElement(By.Id("PAYMENT_cvv")).Click();
            WebDriver.FindElement(By.Id("PAYMENT_cvv")).SendKeys("000");
            WebDriver.FindElement(By.Id("PAYMENT_billingCountry")).Click();
            {
                var dropdown = WebDriver.FindElement(By.Id("PAYMENT_billingCountry"));
                dropdown.FindElement(By.XPath("//option[. = 'India']")).Click();
            }
            WebDriver.FindElement(By.Id("PAYMENT_billingCountry")).Click();

            WebDriver.FindElement(By.CssSelector("#widgetPayBtn > .pull-left")).Click();
            WebDriver.Quit();
        }
    }

}
