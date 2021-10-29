using UnityEngine;

public class MenuInstaller : MonoBehaviour
{
    [SerializeField] private RectTransform _canvasParent;

    [SerializeField] private HomeView _homeReviewPrefab;
    [SerializeField] private ScoreView _scoreReviewPrefab;
    [SerializeField] private SettingsView _settingsReviewPrefab;
    
    private void Awake()
    {
        var homeReviewView = Instantiate(_homeReviewPrefab,_canvasParent);
        var scoreReviewView = Instantiate(_scoreReviewPrefab,_canvasParent);
        var settingsReviewView = Instantiate(_settingsReviewPrefab, _canvasParent);
    }
}
