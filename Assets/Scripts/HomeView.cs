using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class HomeView : MonoBehaviour
{
    [SerializeField] private Button _homeButton;
    [SerializeField] private Button _scoreButton;
    [SerializeField] private Button _settingsButton;

    private HomeViewModel _viewModel;

    public void SetViewModel(HomeViewModel viewmodel)
    {
        _viewModel = viewmodel;

        _homeButton.onClick.AddListener(() =>
        {
            _viewModel.add
        });
    }
}
