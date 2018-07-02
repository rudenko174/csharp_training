using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactInfoData newContactDate = new ContactInfoData("Zoo_New");
            newContactDate.Middlename = "222";
            newContactDate.Lastname = "333";

            app.Contacts.Modify(1, newContactDate);
        }
    }
}
