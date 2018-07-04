using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactInfoData newContactDate = new ContactInfoData("Zoo_New");
            newContactDate.Middlename = "Zoo_New";
            newContactDate.Lastname = "Zoo_New";

            app.Contacts.Modify(newContactDate);
        }
    }
}
