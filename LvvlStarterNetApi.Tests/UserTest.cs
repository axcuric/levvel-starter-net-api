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
    class UserTest
    {
        List<User> li;
        [Test]
        public void CheckUser()
        {
            Program pobj = new Program();
            li = pobj.AllUsers();
            foreach (var x in li)
            {
                Assert.IsNotNull(x.UserId);
                Assert.IsNotNull(x.FirstName);
                Assert.IsNotNull(x.LastName);
                Assert.IsNotNull(x.EmailAddress);
                //Assert.IsNotNull(x.Phones);
            }
        }
        //[Test]
        //public void TestLogin()
        //{
        //    Program pobj = new Program();
        //    string x = pobj.Login("Ajit", "1234");
        //    string y = pobj.Login("", "");
        //    string z = pobj.Login("Admin", "Admin");
        //    Assert.AreEqual("Userid or password could not be Empty.", y);
        //    Assert.AreEqual("Incorrect UserId or Password.", x);
        //    Assert.AreEqual("Welcome Admin.", z);
        //}

        [Test]
        public void getUserPhone()
        {
            Program pobj = new Program();
            var p = pobj.getDetails(100);
            foreach (var x in p)
            {
                Assert.AreEqual(x.UserId, 100);
                Assert.AreEqual(x.FirstName, "Bharat");
            }
        }
    }
}
