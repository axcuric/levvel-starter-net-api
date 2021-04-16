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
        List<Phone> li;
        [Test]
        public void CheckPhone()
        {
            Program pobj = new Program();
            li = pobj.AllPhones();
            foreach (var x in li)
            {
                Assert.IsNotNull(x.UserId);
                //Assert.IsNotNull(x.User);
                Assert.IsNotNull(x.PhoneId);
                Assert.IsNotNull(x.PhoneNumber);
            }
        }
    }
}
