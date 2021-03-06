using UniRx;
using DG.Tweening;

public class ButtonsController
{
    private readonly ButtonsViewModel _buttonsViewModel;
    
    private readonly HomeViewModel _homeViewModel;
    private readonly ScoreViewModel _scoreViewModel;
    private readonly SettingsViewModel _settingsViewModel;

    public ButtonsController(ButtonsViewModel viewModel, HomeViewModel homeViewModel, ScoreViewModel scoreViewModel, SettingsViewModel settingsViewModel)
    {
        _buttonsViewModel = viewModel;
        _homeViewModel = homeViewModel;
        _scoreViewModel = scoreViewModel;
        _settingsViewModel = settingsViewModel;

        _homeViewModel.isVisible.Value = true;

        _buttonsViewModel
            .HomeButtonPressed
            .Subscribe((_) =>
            {
                _homeViewModel.isVisible.Value = true;
                _scoreViewModel.isVisible.Value = false;
                _settingsViewModel.isVisible.Value = false;
                _buttonsViewModel.HomeColor.Value = new UnityEngine.Color(0, 0, 255);
                _buttonsViewModel.ScoreColor.Value = new UnityEngine.Color(0.38f, 0.44f, 1.0f);
                _buttonsViewModel.SettingsColor.Value = new UnityEngine.Color(0.38f, 0.44f, 1.0f);
            });
        _buttonsViewModel
            .ScoreButtonPressed
            .Subscribe((_) =>
            {
                _homeViewModel.isVisible.Value = false;
                _scoreViewModel.isVisible.Value = true;
                _settingsViewModel.isVisible.Value = false;
                _buttonsViewModel.HomeColor.Value = new UnityEngine.Color(0.38f, 0.44f, 1.0f);
                _buttonsViewModel.ScoreColor.Value = new UnityEngine.Color(0, 0, 255);
                _buttonsViewModel.SettingsColor.Value = new UnityEngine.Color(0.38f, 0.44f, 1.0f);
            });
        _buttonsViewModel
            .SettingsButtonPressed
            .Subscribe((_) =>
            {
                _homeViewModel.isVisible.Value = false;
                _scoreViewModel.isVisible.Value = false;
                _settingsViewModel.isVisible.Value = true;
                _buttonsViewModel.HomeColor.Value = new UnityEngine.Color(0.38f, 0.44f, 1.0f);
                _buttonsViewModel.ScoreColor.Value = new UnityEngine.Color(0.38f, 0.44f, 1.0f);
                _buttonsViewModel.SettingsColor.Value = new UnityEngine.Color(0, 0, 255);
            });
    }
}
