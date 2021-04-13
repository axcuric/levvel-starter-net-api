using LvvlStarterNetApi.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.Infrastructure.Context.Data
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CliDbExampleContext(
                serviceProvider.GetRequiredService<DbContextOptions<CliDbExampleContext>>()))
            {
                // Look for any board games.
                //if (context..BoardGames.Any())
                //{
                //    return;   // Data was already seeded
                //}

                #region Users 
                context.Users.AddRange(
                    new User
                    {
                        UserId = 1,
                        FirstName = "Ken",
                        LastName = "Sánchez",
                        EmailAddress = "ken0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 2,
                        FirstName = "Terri",
                        LastName = "Duffy",
                        EmailAddress = "terri0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 3,
                        FirstName = "Roberto",
                        LastName = "Tamburello",
                        EmailAddress = "roberto0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 4,
                        FirstName = "Rob",
                        LastName = "Walters",
                        EmailAddress = "rob0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 5,
                        FirstName = "Gail",
                        LastName = "Erickson",
                        EmailAddress = "gail0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 6,
                        FirstName = "Jossef",
                        LastName = "Goldberg",
                        EmailAddress = "jossef0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 7,
                        FirstName = "Dylan",
                        LastName = "Miller",
                        EmailAddress = "dylan0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 8,
                        FirstName = "Diane",
                        LastName = "Margheim",
                        EmailAddress = "diane1@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 9,
                        FirstName = "Gigi",
                        LastName = "Matthew",
                        EmailAddress = "gigi0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 10,
                        FirstName = "Michael",
                        LastName = "Raheem",
                        EmailAddress = "michael6@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 11,
                        FirstName = "Ovidiu",
                        LastName = "Cracium",
                        EmailAddress = "ovidiu0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 12,
                        FirstName = "Thierry",
                        LastName = "DHers",
                        EmailAddress = "thierry0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 13,
                        FirstName = "Janice",
                        LastName = "Galvin",
                        EmailAddress = "janice0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 14,
                        FirstName = "Michael",
                        LastName = "Sullivan",
                        EmailAddress = "michael8@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 15,
                        FirstName = "Sharon",
                        LastName = "Salavaria",
                        EmailAddress = "sharon0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 16,
                        FirstName = "David",
                        LastName = "Bradley",
                        EmailAddress = "david0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 17,
                        FirstName = "Kevin",
                        LastName = "Brown",
                        EmailAddress = "kevin0@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 18,
                        FirstName = "John",
                        LastName = "Wood",
                        EmailAddress = "john5@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 19,
                        FirstName = "Mary",
                        LastName = "Dempsey",
                        EmailAddress = "mary2@adventure-works.com"
                    },
                    new User
                    {
                        UserId = 20,
                        FirstName = "Wanida",
                        LastName = "Benshoof",
                        EmailAddress = "wanida0@adventure-works.com"
                    }
                    );
                #endregion

                context.Phones.AddRange(

                    new Phone { PhoneId = 1, PhoneNumber = "697-555-0142", PhoneNumberTypeId = 1, UserId = 1 },
                    new Phone
                    {
                        PhoneId = 2,
                        PhoneNumber = "819-555-0175",
                        PhoneNumberTypeId = 3,
                        UserId = 2
                    },
                    new Phone
                    {
                        PhoneId = 3,
                        PhoneNumber = "212-555-0187",
                        PhoneNumberTypeId = 1,
                        UserId = 3
                    },
                    new Phone
                    {
                        PhoneId = 4,
                        PhoneNumber = "612-555-0100",
                        PhoneNumberTypeId = 1,
                        UserId = 4
                    },
                    new Phone
                    {
                        PhoneId = 5,
                        PhoneNumber = "849-555-0139",
                        PhoneNumberTypeId = 1,
                        UserId = 5
                    },
                    new Phone
                    {
                        PhoneId = 6,
                        PhoneNumber = "122-555-0189",
                        PhoneNumberTypeId = 3,
                        UserId = 6
                    },
                    new Phone
                    {
                        PhoneId = 7,
                        PhoneNumber = "181-555-0156",
                        PhoneNumberTypeId = 3,
                        UserId = 7
                    },
                    new Phone
                    {
                        PhoneId = 8,
                        PhoneNumber = "815-555-0138",
                        PhoneNumberTypeId = 1,
                        UserId = 8
                    },
                    new Phone
                    {
                        PhoneId = 9,
                        PhoneNumber = "185-555-0186",
                        PhoneNumberTypeId = 1,
                        UserId = 9
                    },
                    new Phone
                    {
                        PhoneId = 10,
                        PhoneNumber = "330-555-2568",
                        PhoneNumberTypeId = 3,
                        UserId = 10
                    },
                    new Phone
                    {
                        PhoneId = 11,
                        PhoneNumber = "719-555-0181",
                        PhoneNumberTypeId = 1,
                        UserId = 11
                    },
                    new Phone
                    {
                        PhoneId = 12,
                        PhoneNumber = "168-555-0183",
                        PhoneNumberTypeId = 3,
                        UserId = 12
                    },
                    new Phone
                    {
                        PhoneId = 13,
                        PhoneNumber = "473-555-0117",
                        PhoneNumberTypeId = 3,
                        UserId = 13
                    },
                    new Phone
                    {
                        PhoneId = 14,
                        PhoneNumber = "465-555-0156",
                        PhoneNumberTypeId = 1,
                        UserId = 14
                    },
                    new Phone
                    {
                        PhoneId = 15,
                        PhoneNumber = "970-555-0138",
                        PhoneNumberTypeId = 1,
                        UserId = 15
                    },
                    new Phone
                    {
                        PhoneId = 16,
                        PhoneNumber = "913-555-0172",
                        PhoneNumberTypeId = 3,
                        UserId = 16
                    },
                    new Phone
                    {
                        PhoneId = 17,
                        PhoneNumber = "150-555-0189",
                        PhoneNumberTypeId = 1,
                        UserId = 17
                    },
                    new Phone
                    {
                        PhoneId = 18,
                        PhoneNumber = "486-555-0150",
                        PhoneNumberTypeId = 3,
                        UserId = 18
                    },
                    new Phone
                    {
                        PhoneId = 19,
                        PhoneNumber = "124-555-0114",
                        PhoneNumberTypeId = 1,
                        UserId = 19
                    },
                    new Phone
                    {
                        PhoneId = 20,
                        PhoneNumber = "708-555-0141",
                        PhoneNumberTypeId = 3,
                        UserId = 20
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
