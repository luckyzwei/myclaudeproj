using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemEmployeeMood : MonoBehaviour
{
	[SerializeField]
	private Image CharIcon;

	[SerializeField]
	private Image MoodIcon;

	[SerializeField]
	private Text Name;

	[SerializeField]
	private GameObject BuffDebuffRoot;

	[SerializeField]
	private GameObject DebuffRoot;

	[SerializeField]
	private GameObject BuffRoot;

	[SerializeField]
	private List<GameObject> Debuffs;

	private int OfficeIdx;

	private int Seat;

	private CompositeDisposable disposables;

	public void Set(int office, int seat)
	{
		OfficeIdx = office;
		Seat = seat;
		disposables = new CompositeDisposable();
		UpdateShowMood();
	}

	private void UpdateMood(EmployeeMoodSystem.Mood mood)
	{
		if (BuffDebuffRoot != null) BuffDebuffRoot.SetActive(true);
		if (BuffRoot != null) BuffRoot.SetActive(false);
		if (DebuffRoot != null) DebuffRoot.SetActive(false);
	}

	public void UpdateShowMood()
	{
		// Update display
	}

	public void Refresh()
	{
		UpdateShowMood();
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}

	private void OnDisable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}
}
