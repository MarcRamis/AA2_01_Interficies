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
            
            _viewModel.HomeColor.Subscribe((newColor) =>
            {
                _homeImage.DOColor(newColor, 1f);
            });

            _viewModel.ScoreColor.Subscribe((newColor) =>
            {
                _scoreImage.DOColor(newColor, 1f);
            });

            _viewModel.SettingsColor.Subscribe((newColor) =>
            {
                _settingsImage.DOColor(newColor, 1f);

            });

        });
        _scoreButton.onClick.AddListener(() =>
        {
            _viewModel.ScoreButtonPressed.Execute();

            _viewModel.HomeColor.Subscribe((newColor) =>
            {
                _homeImage.DOColor(newColor, 1f);
            });

            _viewModel.ScoreColor.Subscribe((newColor) =>
            {
                _scoreImage.DOColor(newColor, 1f);
            });

            _viewModel.SettingsColor.Subscribe((newColor) =>
            {
                _settingsImage.DOColor(newColor, 1f);

            });

        });
        _settingsButton.onClick.AddListener(() =>
        {
            _viewModel.SettingsButtonPressed.Execute();

            _viewModel.HomeColor.Subscribe((newColor) =>
            {
                _homeImage.DOColor(newColor, 1f);
            });

            _viewModel.ScoreColor.Subscribe((newColor) =>
            {
                _scoreImage.DOColor(newColor, 1f);
            });

            _viewModel.SettingsColor.Subscribe((newColor) =>
            {
                _settingsImage.DOColor(newColor, 1f);

            });
        });
    }

}
