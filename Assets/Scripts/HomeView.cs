using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class HomeView : MonoBehaviour
{
    private HomeViewModel _homeViewModel;

    public void SetViewModel(HomeViewModel homeViewModel)
    {
        _homeViewModel = homeViewModel;

        _homeViewModel
            .isVisible
            .Subscribe((isVisible) =>
            {
                gameObject.SetActive(isVisible);
            });
    }
}