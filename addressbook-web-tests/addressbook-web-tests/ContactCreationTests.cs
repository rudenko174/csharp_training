using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;


        [SetUp]
        public void SetupTest()
        {
            FirefoxOptions options = new FirefoxOptions
            {
                BrowserExecutableLocation = @"c:\Program Files\Mozilla Firefox\firefox.exe",
                UseLegacyImplementation = true
            };
            driver = new FirefoxDriver(options);
            baseURL = "http://localhost/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void ContactCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            InitNewContactCreation();

            ContactInfoData general = new ContactInfoData("Firstname")
            {
                Middlename = "Middlename",
                Lastname = "Lastname",
                Nickname = "Nickname",
                Title = "Title",
                Company = "Company",
                Address = "Address",
                Home = "Home",
                Mobile = "Mobile",
                Work = "Work",
                Fax = "Fax",
                Email = "E-mail",
                Email2 = "E-mail2",
                Email3 = "E-mail3",
                Homepage = "Homepage",
                Birthday = "1",
                Birthmonth = "January",
                Birthyear = "1999",
                Anniversaryday = "1",
                Anniversarymonth = "January",
                Anniversaryyear = "1999",
                SecondaryAddress = "Address",
                phone = "Phone",
                notes = "Notes"
            };
            FillContactInfoData(general);
            SubmitContactCreation();
            Logout();
        }

        private void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }

        private void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        private void InitNewContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        private void FillContactInfoData(ContactInfoData general)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(general.Firstname);
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(general.Middlename);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(general.Lastname);
            driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("nickname")).SendKeys(general.Nickname);
            driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("title")).SendKeys(general.Title);
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys(general.Company);
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys(general.Address);

            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("home")).SendKeys(general.Home);
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys(general.Mobile);
            driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("work")).SendKeys(general.Work);
            driver.FindElement(By.Name("fax")).Clear();
            driver.FindElement(By.Name("fax")).SendKeys(general.Fax);

            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys(general.Email);
            driver.FindElement(By.Name("email2")).Clear();
            driver.FindElement(By.Name("email2")).SendKeys(general.Email2);
            driver.FindElement(By.Name("email3")).Clear();
            driver.FindElement(By.Name("email3")).SendKeys(general.Email3);
            driver.FindElement(By.Name("homepage")).Clear();
            driver.FindElement(By.Name("homepage")).SendKeys(general.Homepage);

            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText(general.Birthday);
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText(general.Birthmonth);
            driver.FindElement(By.Name("byear")).Clear();
            driver.FindElement(By.Name("byear")).SendKeys(general.Birthyear);
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText(general.Anniversaryday);
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText(general.Anniversarymonth);
            driver.FindElement(By.Name("ayear")).Clear();
            driver.FindElement(By.Name("ayear")).SendKeys(general.Anniversaryyear);

            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys(general.SecondaryAddress);
            driver.FindElement(By.Name("phone2")).Clear();
            driver.FindElement(By.Name("phone2")).SendKeys(general.Phone);
            driver.FindElement(By.Name("notes")).Clear();
            driver.FindElement(By.Name("notes")).SendKeys(general.Notes);
        }

        private void SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        private void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}