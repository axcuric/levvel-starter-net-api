namespace LvvlStarterNetApi.SharedKernel.Interfaces
{
    public interface IPhone
    {
        int PhoneId { get; set; }
        string PhoneNumber { get; set; }
        int UserId { get; set; }
    }
}
