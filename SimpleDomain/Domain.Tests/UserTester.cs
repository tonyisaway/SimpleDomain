using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class UserTester
    {
        [Test]
        public void CanCreateUser()
        {
            var user = new User();
        }

        [Test]
        public void UserHasIdentifier()
        {
            var user = new User();
            int id = user.Id;
        }

        [Test]
        public void UserHasPublicName()
        {
            var user = new User();
            string publicName = user.PublicName;
        }
    }
}
