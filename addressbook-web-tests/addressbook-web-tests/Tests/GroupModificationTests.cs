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
            newDate.Header = null;
            newDate.Footer = null;

            app.Groups.Modify(1, newDate);
        }
    }
}
