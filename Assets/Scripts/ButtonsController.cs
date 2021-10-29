using UniRx;

public class ButtonsController
{
    private readonly HomeViewModel _homeViewModel;

    public ButtonsController(HomeViewModel viewModel)
    {
        _homeViewModel = viewModel;

        _homeViewModel
            .ScoreButonPressed
            .Subscribe((_) =>
            {
            });
    }
}
