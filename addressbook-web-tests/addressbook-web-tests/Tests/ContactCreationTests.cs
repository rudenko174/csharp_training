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

            GeneralInfoData general = new GeneralInfoData("Firstname")
            {
                Middlename = "Middlename",
                Lastname = "Lastname",
                Nickname = "Nickname",
                Title = "Title",
                Company = "Company",
                Address = "Address"
            };

            TelephoneData telephones = new TelephoneData
            {
                Home = "Home",
                Mobile = "Mobile",
                Work = "Work",
                Fax = "Fax"
            };

            MailData mails = new MailData
            {
                Email = "E-mail",
                Email2 = "E-mail2",
                Email3 = "E-mail3",
                Homepage = "Homepage"
            };

            BirthDayAndAnniversaryData DDMMYY = new BirthDayAndAnniversaryData
            {
                Birthday = "1",
                Birthmonth = "January",
                Birthyear = "1999",
                Anniversaryday = "1",
                Anniversarymonth = "January",
                Anniversaryyear = "1999"
            };

            SecondaryInfoData secondaryinfo = new SecondaryInfoData
            {
                address = "Address",
                phone = "Phone",
                notes = "Notes"
            };

            app.Navigator.InitNewContactCreation();
            app.Contac.FillGeneralInfo(general);
            app.Contac.FillTelephone(telephones);
            app.Contac.FillMail(mails);
            app.Contac.FillBirthDayAndAnniversary(DDMMYY);
            app.Contac.FillSecondaryInfo(secondaryinfo);
            app.Contac.SubmitContactCreation();
            app.Auth.Logout();
        }
    }
}