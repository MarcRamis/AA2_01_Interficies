using UniRx;

public class ButtonsViewModel
{
    public readonly ReactiveCommand HomeButtonPressed;
    public readonly ReactiveCommand ScoreButtonPressed;
    public readonly ReactiveCommand SettingsButtonPressed;

    public ButtonsViewModel()
    {
        HomeButtonPressed = new ReactiveCommand();
        ScoreButtonPressed = new ReactiveCommand();
        SettingsButtonPressed = new ReactiveCommand();
    }
}
