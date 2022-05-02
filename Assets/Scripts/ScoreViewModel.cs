using UniRx;

public class ScoreViewModel
{
    public readonly ReactiveProperty<bool> isVisible;

    public ScoreViewModel()
    {
        isVisible = new ReactiveProperty<bool>();
    }
}
