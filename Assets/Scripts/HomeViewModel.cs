using UniRx;

public class HomeViewModel
{
    public readonly ReactiveProperty<bool> isVisible;

    public HomeViewModel()
    {
        isVisible = new ReactiveProperty<bool>();
    }
}
