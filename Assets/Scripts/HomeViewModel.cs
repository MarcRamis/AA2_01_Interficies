using UniRx;

public class HomeViewModel
{
    public readonly ReactiveCommand ScoreButonPressed;
    public readonly ReactiveCommand SettingsButonPressed;

    public HomeViewModel()
    {
        ScoreButonPressed = new ReactiveCommand();
        SettingsButonPressed = new ReactiveCommand();
    }
}
