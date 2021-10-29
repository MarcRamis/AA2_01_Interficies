using UniRx;

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

        _buttonsViewModel
            .ScoreButtonPressed
            .Subscribe((_) =>
            {
            });
    }
}
