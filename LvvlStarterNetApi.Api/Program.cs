using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LvvlStarterNetApi.Core.Models;

namespace LvvlStarterNetApi.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public string Login(string UserId, string Password)
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Password))
            {
                return "Userid could not be Empty.";
            }
            /*else {  
                if (UserId == "Admin" && Password == "Admin") {  
                    return "Welcome Admin.";  
                }  
                return "Incorrect UserId or Password.";  
            } */
            return "Welcome Admin.";
        }
        public List<User> AllUsers()
        {
            List<User> li = new List<User>();
            li.Add(new User
            {
                UserId = 100,
                FirstName = "Cloud",
                LastName = "Seventh",
                EmailAddress = "omni-slash@ff7.com"//, //Phones = 1093425  
            });
            li.Add(new User
            {
                UserId = 101,
                FirstName = "Light",
                LastName = "Yagami",
                EmailAddress = "kira@deathnote.com"//, //Phones = 1093425  
            });
            li.Add(new User
            {
                UserId = 106,
                FirstName = "Terra",
                LastName = "Esper",
                EmailAddress = "magi.tek@ff6.com"//, //Phones = 1093425  
            });
            return li;
        }
        public List<User> getDetails(int id)
        {
            List<User> li1 = new List<User>();
            Program p = new Program();
            var li = p.AllUsers();
            foreach (var x in li)
            {
                if (x.UserId == id)
                {
                    li1.Add(x);
                }
            }
            return li1;
        }
        public List<Phone> AllPhones()
        {
            List<Phone> li = new List<Phone>();
            li.Add(new Phone
            {
                //User = "Isaac",
                UserId = 101,
                PhoneId = 10,
                PhoneNumber = "132458569"
            });
            li.Add(new Phone
            {
                //User = "Isaac",
                UserId = 102,
                PhoneId = 12,
                PhoneNumber = "138858569"
            });
            li.Add(new Phone
            {
                //User = "Isaac",
                UserId = 103,
                PhoneId = 13,
                PhoneNumber = "936358569"
            });
            return li;
        }
    }
}
