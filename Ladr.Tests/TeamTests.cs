using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ladr.Library.Models;
using System;
using System.Collections.Generic;

namespace Ladr.Tests
{
    [TestClass]
    public class TeamTests
    {
        [TestMethod]
        public void InstanceTypeTest()
        {
            Team newTeam = new Team();
            Assert.IsInstanceOfType(newTeam, typeof(Team));
        }
        [TestMethod]
        public void TeamContainsMemberList()
        {
            Team newTeam = new Team();
            Assert.IsInstanceOfType(newTeam.GetMembers(), typeof(List<Member>));

        }
    }
}
