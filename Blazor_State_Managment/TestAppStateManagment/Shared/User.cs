namespace TestAppStateManagment.Shared;

public class User : BaseEntity
{
    public string username { get; set; }
    public string full_name { get; set; }
    public string email { get; set; }
}