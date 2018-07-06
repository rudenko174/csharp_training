using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressBookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager)
            : base(manager)
        {
        }

        public ContactHelper Create(ContactInfoData general)
        {
            InitNewContactCreation();
            FillContactInfoData(general);
            SubmitContactCreation();
            //app.Auth.Logout();
            return this;
        }

        public ContactHelper Modify(ContactInfoData newContactDate)
        {
            manager.Navigator.GoToHomePage();
            IsContactOnThePage();
            InitContactModification();
            FillContactInfoData(newContactDate);
            SubmitContactModification();
            return this;
        }

        public ContactHelper Remove(int p)
        {
            manager.Navigator.GoToHomePage();
            IsContactOnThePage();
            driver.FindElements(By.XPath("//input[@name='selected[]']"))[0].Click();
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public void IsContactOnThePage()
        {
            if (!IsElementPresent(By.XPath("//img[@title='Edit']")))
            {
                Create(new ContactInfoData("Firstname"));
                manager.Navigator.GoToHomePage();
            }
        }

        public ContactHelper InitContactModification()
        {
            driver.FindElements(By.XPath("//img[@title='Edit']"))[0].Click();
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper InitNewContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ContactHelper FillContactInfoData(ContactInfoData general)
        {
            Type(By.Name("firstname"), general.Firstname);
            Type(By.Name("middlename"), general.Middlename);
            Type(By.Name("lastname"), general.Lastname);
            Type(By.Name("nickname"), general.Nickname);
            Type(By.Name("title"), general.Title);
            Type(By.Name("company"), general.Company);
            Type(By.Name("address"), general.Address);

            Type(By.Name("home"), general.Home);
            Type(By.Name("mobile"), general.Mobile);
            Type(By.Name("work"), general.Work);
            Type(By.Name("fax"), general.Fax);

            Type(By.Name("email"), general.Email);
            Type(By.Name("email2"), general.Email2);
            Type(By.Name("email3"), general.Email3);
            Type(By.Name("homepage"), general.Homepage);
            
            SetTime(By.Name("bday"), general.Birthday);
            SetTime(By.Name("bmonth"), general.Birthmonth);
            Type(By.Name("byear"), general.Birthyear);
            SetTime(By.Name("aday"), general.Anniversaryday);
            SetTime(By.Name("amonth"), general.Anniversarymonth);
            Type(By.Name("ayear"), general.Anniversaryyear);

            Type(By.Name("address2"), general.SecondaryAddress);
            Type(By.Name("phone2"), general.Phone);
            Type(By.Name("notes"), general.Notes);
            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
    }
}
