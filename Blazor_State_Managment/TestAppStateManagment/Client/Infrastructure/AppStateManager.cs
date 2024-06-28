using Microsoft.AspNetCore.Components;
using TestAppStateManagment.Shared;

namespace TestAppStateManagment.Client.Infrastructure;

public class AppStateManager
{
    public List<User> Users { get; set; } = new();

    public event Action<ComponentBase, string> StateChanged;

    public event Action<ComponentBase, string, List<User>> SetUsers;

    public void SetState(ComponentBase component)
    {
        StateChanged?.Invoke(component, "setState");
    }

    public void SetUsersState(ComponentBase component, List<User> setUsers)
    {
        if(setUsers != null)
        {
            SetUsers?.Invoke(component, "setUsers", setUsers);
        }
    }
}
