using UniRx;
using UnityEngine.UI;

public class ButtonsViewModel
{
    public readonly ReactiveCommand HomeButtonPressed;
    public readonly ReactiveCommand ScoreButtonPressed;
    public readonly ReactiveCommand SettingsButtonPressed;

    public readonly ReactiveProperty<UnityEngine.Color> Color;

    public readonly Image HomeImage;

    public ButtonsViewModel()
    {
        HomeButtonPressed = new ReactiveCommand();
        ScoreButtonPressed = new ReactiveCommand();
        SettingsButtonPressed = new ReactiveCommand();
        Color = new ReactiveProperty<UnityEngine.Color>();
    }
}
