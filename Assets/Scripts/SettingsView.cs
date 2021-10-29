using UnityEngine;
using UniRx;

public class SettingsView : MonoBehaviour
{
    private SettingsViewModel _settingsViewModel;

    public void SetViewModel(SettingsViewModel settingsViewModel)
    {
        _settingsViewModel = settingsViewModel;

        _settingsViewModel
            .isVisible
            .Subscribe((isVisible)=>
            {
                gameObject.SetActive(isVisible);
            });
    }
}
