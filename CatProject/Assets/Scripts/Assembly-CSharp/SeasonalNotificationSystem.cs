using UniRx;

public class SeasonalNotificationSystem
{
	private bool IsEnabledSkillBookContents;

	private CompositeDisposable Disposables;

	public void OnStartGame()
	{
		Disposables = new CompositeDisposable();
		IsEnabledSkillBookContents = false;
	}

	public void OnExitGame()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
		IsEnabledSkillBookContents = false;
	}

	private void OnChangedCurrencyValue_ArcadeRouletteCoin()
	{
		if (Disposables == null) return;
	}

	private void OnChangedCurrencyValue_SkillBook()
	{
		IsEnabledSkillBookContents = true;
	}

	private void OnChangedMilestoneInfo()
	{
		if (Disposables == null) return;
	}
}
