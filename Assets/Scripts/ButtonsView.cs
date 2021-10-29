using UnityEngine;
using UniRx;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonsView : MonoBehaviour
{
    [SerializeField] private Button _homeButton;
    [SerializeField] private Button _scoreButton;
    [SerializeField] private Button _settingsButton;

    [SerializeField] private Image _homeImage;
    [SerializeField] private Image _scoreImage;
    [SerializeField] private Image _settingsImage;

    private ButtonsViewModel _viewModel;

    public void SetViewModel(ButtonsViewModel viewModel)
    {
        _viewModel = viewModel;

        _homeButton.onClick.AddListener(() => 
        {
            _viewModel.HomeButtonPressed.Execute();
            SetSelectedImageColorButton();
        });
        _scoreButton.onClick.AddListener(() =>
        {
            _viewModel.ScoreButtonPressed.Execute();
        });
        _settingsButton.onClick.AddListener(() =>
        {
            _viewModel.SettingsButtonPressed.Execute();
        });
    }

    public void SetInitialImageColorButton()
    {
        _homeImage.DOColor(Color.white, 1f);
    }

    public void SetSelectedImageColorButton()
    {
        _homeImage.DOColor(new Color(0,0,255), 1f);
    }
}
