using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace WebAddressBookTests 
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupDate group = new GroupDate("Dmytro");
            group.Header = "Text";
            group.Footer = "First";

            List<GroupDate> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);

            List<GroupDate> newGroups = app.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupDate group = new GroupDate("");
            group.Header = "";
            group.Footer = "";

            List<GroupDate> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);

            List<GroupDate> newGroups = app.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
        }

        [Test]
        public void BadNameGroupCreationTest()
        {
            GroupDate group = new GroupDate("a'a");
            group.Header = "";
            group.Footer = "";

            List<GroupDate> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);

            List<GroupDate> newGroups = app.Groups.GetGroupList();
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
        }
    }
}
