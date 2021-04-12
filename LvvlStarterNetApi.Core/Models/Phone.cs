using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.Core.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public int PhoneNumberTypeId { get; set; }
        public int UserId { get; set; }

        public virtual PhoneNumberType PhoneNumberType { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public virtual User User { get; set; }
    }
}
