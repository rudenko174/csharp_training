using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            List<GroupDate> oldGroups = app.Groups.GetGroupList();

            app.Groups.Remove(0);

            List<GroupDate> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt()
            Assert.AreEqual(oldGroups.Count + 1, newGroups.Count);
        }
    }
}