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
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToGroupsPage();
            groupHelper.InitNewGroupCreation();
            GroupDate group = new GroupDate("Dmytro");
            group.Header = "Text";
            group.Footer = "First";
            groupHelper.FillGroupForm(group);
            groupHelper.SubmitGroupCreation();
            navigator.GoToGroupsPage();
            loginHelper.Logout();
        }
    }
}
