using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LvvlStarterNetApi.Core.Models;
using LvvlStarterNetApi.Api;

namespace LvvlStarterNetApi.Tests
{
    [TestFixture]
    class PhoneTest
    {
        List<User> li;
        [Test]
        public void CheckPhone()
        {
            Program pobj = new Program();
            li = pobj.AllUsers();
            foreach (var x in li)
            {
                Assert.IsNotNull(x.UserId);
                Assert.IsNotNull(x.FirstName);
                Assert.IsNotNull(x.LastName);
                Assert.IsNotNull(x.EmailAddress);
                Assert.IsNotNull(x.Phones);
            }
        }
    }
}
