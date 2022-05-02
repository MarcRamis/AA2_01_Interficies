using UniRx;

public class SettingsViewModel 
{
    public readonly ReactiveProperty<bool> isVisible;

    public SettingsViewModel()
    {
        isVisible = new ReactiveProperty<bool>();
    }
}
