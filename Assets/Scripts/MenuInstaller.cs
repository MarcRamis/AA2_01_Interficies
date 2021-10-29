using UnityEngine;

public class MenuInstaller : MonoBehaviour
{
    [SerializeField] private RectTransform _canvasParent;

    [SerializeField] private HomeView _homeReviewPrefab;
    [SerializeField] private ScoreView _scoreReviewPrefab;
    [SerializeField] private SettingsView _settingsReviewPrefab;
    [SerializeField] private ButtonsView _buttonsPrefab;

    private void Awake()
    {
        var homeReviewView = Instantiate(_homeReviewPrefab,_canvasParent);
        var scoreReviewView = Instantiate(_scoreReviewPrefab,_canvasParent);
        var settingsReviewView = Instantiate(_settingsReviewPrefab, _canvasParent);
        var buttonsView = Instantiate(_buttonsPrefab, _canvasParent);

        var homeViewModel = new HomeViewModel();
        var scoreViewModel = new ScoreViewModel();
        var settingsViewModel = new SettingsViewModel();
        var buttonsViewModel = new ButtonsViewModel();

        homeReviewView.SetViewModel(homeViewModel);
        scoreReviewView.SetViewModel(scoreViewModel);
        settingsReviewView.SetViewModel(settingsViewModel);
        buttonsView.SetViewModel(buttonsViewModel);

        new ButtonsController(buttonsViewModel, homeViewModel, scoreViewModel, settingsViewModel);
    }
}
