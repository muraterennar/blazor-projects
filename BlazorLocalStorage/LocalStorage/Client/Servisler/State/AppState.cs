namespace LocalStorage.Client.Servisler.State;

public interface IStringStateService
{
    string MyString { get; set; }
}


public class AppState : IStringStateService
{
    public string MyString { get; set; }
}
