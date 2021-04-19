namespace LvvlStarterNetApi.Core.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public int UserId { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public virtual User User { get; set; }
    }
}