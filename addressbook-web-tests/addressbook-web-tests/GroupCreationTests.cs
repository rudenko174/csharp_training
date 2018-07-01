using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressBookTests 
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitNewGroupCreation();
            GroupDate group = new GroupDate("Dmytro");
            group.Header = "Text";
            group.Footer = "First";
            FillGroupForm(group);
            SubmitGroupCreation();
            GoToGroupsPage();
            Logout();
        }
    }
}
