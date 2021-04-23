using LvvlStarterNetApi.SharedKernel.Interfaces;
using System.Collections.Generic;

namespace LvvlStarterNetApi.Core.Models
{
    public partial class User : IUser
    {
        public User()
        {
            Phones = new HashSet<Phone>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
    }
}