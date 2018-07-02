using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupDate newDate = new GroupDate("Zoo_last");
            newDate.Header = "222";
            newDate.Footer = "333";

            app.Groups.Modify(1, newDate);
        }
    }
}
