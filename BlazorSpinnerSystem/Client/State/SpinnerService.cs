namespace BlazorSpinnerSystem.Client.State;

// SpinnerService.cs
public interface ISpinnerService
{
    event Action<bool> OnSpinnerChanged;

    void ShowSpinner();
    void HideSpinner();
}

public class SpinnerService : ISpinnerService
{
    public event Action<bool> OnSpinnerChanged;

    private bool _isVisible = false;

    public void ShowSpinner()
    {
        _isVisible = true;
        NotifyStateChanged();
    }

    public void HideSpinner()
    {
        _isVisible = false;
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnSpinnerChanged?.Invoke(_isVisible);
}
