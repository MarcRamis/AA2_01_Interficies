using UnityEngine;
using UniRx;

public class ScoreView : MonoBehaviour
{
    private ScoreViewModel _scoreViewModel;

    public void SetViewModel(ScoreViewModel scoreViewModel)
    {
        _scoreViewModel = scoreViewModel;

        _scoreViewModel
        .isVisible
        .Subscribe((isVisible) =>
        {
            gameObject.SetActive(isVisible);
        });
    }
}
