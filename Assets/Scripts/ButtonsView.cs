using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class ButtonsView : MonoBehaviour
{
    [SerializeField] private Button _homeButton;
    [SerializeField] private Button _scoreButton;
    [SerializeField] private Button _settingsButton;

    private ButtonsViewModel _viewModel;

    public void SetViewModel(ButtonsViewModel viewModel)
    {
        _viewModel = viewModel;
    }
}
