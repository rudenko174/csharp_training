using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressBookTests
{
    public class TestBase
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;

        [SetUp]
        public void SetupTest()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"c:\Program Files\Mozilla Firefox\firefox.exe";
            options.UseLegacyImplementation = true;
            driver = new FirefoxDriver(options);
            baseURL = "http://localhost";
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


        protected void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }

        protected void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        protected void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        protected void InitNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        protected void FillGroupForm(GroupDate group)
        {
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }

        protected void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }



        protected void SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
        }

        protected void RemoveGroup()
        {
            driver.FindElement(By.XPath("(//input[@name='delete'])[2]")).Click();
        }

        protected void ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }



        protected void InitNewContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        protected void FillContactInfoData(ContactInfoData general)
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

        protected void SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }


        protected void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

    }
}
