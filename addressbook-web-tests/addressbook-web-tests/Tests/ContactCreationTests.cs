using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
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

            app.Contacts.Create(general);
        }
    }
}