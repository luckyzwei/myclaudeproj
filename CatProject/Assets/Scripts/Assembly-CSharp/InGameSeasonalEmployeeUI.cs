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
		if (employee == null) return;
		WorkerIdx = employee.WorkerIdx;
		Disposables = new CompositeDisposable();
		ShowDuration = 3f;
		ElapsedShowCoolTime = 0f;
	}

	public void ShowMealNotice()
	{
		if (MealObj != null) MealObj.SetActive(true);
		Show();
	}

	public void ShowMoodNotice()
	{
		if (MealObj != null) MealObj.SetActive(false);
		UpdateMood();
		Show();
	}

	private void UpdateMood()
	{
		SetMoodBgImage(WorkerMoodState);
	}

	private void SetMessageIcon(string iconKey)
	{
	}

	private void SetMoodBgImage(E_EmployeeMoodState moodState)
	{
	}

	private void SetMoodMessageText(string localizeKey)
	{
		if (MoodMessageText != null)
			MoodMessageText.text = localizeKey;
	}

	private void OnDestroy()
	{
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	public override void Hide()
	{
		base.Hide();
		if (MealObj != null) MealObj.SetActive(false);
	}
}
