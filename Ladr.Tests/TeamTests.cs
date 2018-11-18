using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ladr.Library.Models;
using System;

namespace Ladr.Tests
{
    [TestClass]
    public class TeamTests
    {
        [TestMethod]
        public void InstanceTypeTest()
        {
            Team newTeam = new Team();
            Console.WriteLine("Boo!");
            Assert.IsInstanceOfType(newTeam, typeof(Team));
        }
        [TestMethod]
        public void TeamContainsMembers()
        {
            
        }
    }
}
