using UniRx;
using UnityEngine.UI;

public class ButtonsViewModel
{
    public readonly ReactiveCommand HomeButtonPressed;
    public readonly ReactiveCommand ScoreButtonPressed;
    public readonly ReactiveCommand SettingsButtonPressed;

    public readonly ReactiveProperty<UnityEngine.Color> HomeColor;
    public readonly ReactiveProperty<UnityEngine.Color> ScoreColor;
    public readonly ReactiveProperty<UnityEngine.Color> SettingsColor;

    public readonly Image HomeImage;

    public ButtonsViewModel()
    {
        HomeButtonPressed = new ReactiveCommand();
        ScoreButtonPressed = new ReactiveCommand();
        SettingsButtonPressed = new ReactiveCommand();
        HomeColor = new ReactiveProperty<UnityEngine.Color>();
        ScoreColor = new ReactiveProperty<UnityEngine.Color>();
        SettingsColor = new ReactiveProperty<UnityEngine.Color>();
    }
}
