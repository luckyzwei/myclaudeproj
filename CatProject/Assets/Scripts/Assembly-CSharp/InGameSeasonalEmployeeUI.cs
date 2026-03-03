using SeasonalDef;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/Seasonal/SeasonalEmployeeUI", true)]
[FloatingDepth(14)]
public class InGameSeasonalEmployeeUI : InGameFloatingUI
{
	[SerializeField]
	private Text MoodMessageText;

	[SerializeField]
	private Image MoodIconImage;

	[SerializeField]
	private Image MoodBgImage;

	[SerializeField]
	private Image MoodBgTailImage;

	[SerializeField]
	private GameObject MealObj;

	private E_EmployeeMoodState WorkerMoodState;

	private float ShowDuration;

	public float ShowRatio;

	public float ShowCoolTime;

	public float ElapsedShowCoolTime;

	private CompositeDisposable Disposables;

	public int WorkerIdx { get; private set; }

	public void SetAttachEmployee(WorkshopEmployee employee)
	{
	}

	public void ShowMealNotice()
	{
	}

	public void ShowMoodNotice()
	{
	}

	private void UpdateMood()
	{
	}

	private void SetMessageIcon(string iconKey)
	{
	}

	private void SetMoodBgImage(E_EmployeeMoodState moodState)
	{
	}

	private void SetMoodMessageText(string localizeKey)
	{
	}

	private void OnDestroy()
	{
	}

	public override void Hide()
	{
	}
}
