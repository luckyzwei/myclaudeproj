using System;
using UnityEngine;
using UnityEngine.UI;

public class HUDSeasonalWorkerMood : MonoBehaviour
{
	[SerializeField]
	private GameObject RootObj;

	[SerializeField]
	private Button MoodBtn;

	[SerializeField]
	private Text BadMoodWorkerCountText;

	private IDisposable Disposable;

	private void Awake()
	{
		if (MoodBtn != null) MoodBtn.onClick.AddListener(OnClickWorkersMood);
	}

	public void Init()
	{
		if (RootObj != null) RootObj.SetActive(true);
		UpdateEmployeesMood();
	}

	public void Reset()
	{
		if (Disposable != null) { Disposable.Dispose(); Disposable = null; }
		if (RootObj != null) RootObj.SetActive(false);
	}

	private void UpdateEmployeesMood()
	{
		// Update display
	}

	private void OnClickWorkersMood()
	{
		// Handle click
	}
}
