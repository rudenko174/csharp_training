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

            GeneralInfoData general = new GeneralInfoData("Firstname")
            {
                Middlename = "Middlename",
                Lastname = "Lastname",
                Nickname = "Nickname",
                Title = "Title",
                Company = "Company",
                Address = "Address"
            };
            FillGeneralInfo(general);

            TelephoneData telephones = new TelephoneData
            {
                Home = "Home",
                Mobile = "Mobile",
                Work = "Work",
                Fax = "Fax"
            };
            FillTelephone(telephones);

            MailData mails = new MailData
            {
                Email = "E-mail",
                Email2 = "E-mail2",
                Email3 = "E-mail3",
                Homepage = "Homepage"
            };
            FillMail(mails);

            BirthDayAndAnniversaryData DDMMYY = new BirthDayAndAnniversaryData
            {
                Birthday = "1",
                Birthmonth = "January",
                Birthyear = "1999",
                Anniversaryday = "1",
                Anniversarymonth = "January",
                Anniversaryyear = "1999"
            };
            FillBirthDayAndAnniversary(DDMMYY);

            SecondaryInfoData secondaryinfo = new SecondaryInfoData
            {
                address = "Address",
                phone = "Phone",
                notes = "Notes"
            };
            FillSecondaryInfo(secondaryinfo);
            SubmitContactCreation();
            Logout();
        }

        private void FillSecondaryInfo(SecondaryInfoData secondaryinfo)
        {
            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys(secondaryinfo.Address);
            driver.FindElement(By.Name("phone2")).Clear();
            driver.FindElement(By.Name("phone2")).SendKeys(secondaryinfo.Phone);
            driver.FindElement(By.Name("notes")).Clear();
            driver.FindElement(By.Name("notes")).SendKeys(secondaryinfo.Notes);
        }

        private void FillBirthDayAndAnniversary(BirthDayAndAnniversaryData DDMMYY)
        {
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText(DDMMYY.Birthday);
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText(DDMMYY.Birthmonth);
            driver.FindElement(By.Name("byear")).Clear();
            driver.FindElement(By.Name("byear")).SendKeys(DDMMYY.Birthyear);
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText(DDMMYY.Anniversaryday);
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText(DDMMYY.Anniversarymonth);
            driver.FindElement(By.Name("ayear")).Clear();
            driver.FindElement(By.Name("ayear")).SendKeys(DDMMYY.Anniversaryyear);
        }

        private void FillMail(MailData mail)
        {
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys(mail.Email);
            driver.FindElement(By.Name("email2")).Clear();
            driver.FindElement(By.Name("email2")).SendKeys(mail.Email2);
            driver.FindElement(By.Name("email3")).Clear();
            driver.FindElement(By.Name("email3")).SendKeys(mail.Email3);
            driver.FindElement(By.Name("homepage")).Clear();
            driver.FindElement(By.Name("homepage")).SendKeys(mail.Homepage);
        }

        private void FillTelephone(TelephoneData telephones)
        {
            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("home")).SendKeys(telephones.Home);
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys(telephones.Mobile);
            driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("work")).SendKeys(telephones.Work);
            driver.FindElement(By.Name("fax")).Clear();
            driver.FindElement(By.Name("fax")).SendKeys(telephones.Fax);
        }

        private void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        private void SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        private void FillGeneralInfo(GeneralInfoData general)
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
        }

        private void InitNewContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        private void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        private void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
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