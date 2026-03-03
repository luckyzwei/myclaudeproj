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
	}

	private void UpdateMood(EmployeeMoodSystem.Mood mood)
	{
	}

	public void UpdateShowMood()
	{
	}

	public void Refresh()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
