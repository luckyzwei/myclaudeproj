using System;
using UniRx;
using UnityEngine;

public class GameNotificationIgnoreRegister : MonoBehaviour
{
	[Serializable]
	public class Data
	{
		public bool awakeRegit;

		public GameNotificationSystem.NotificationCategory category;

		public int targetIdx;

		public int targetSubIdx;

		public bool reverse;

		[HideInInspector]
		public bool on;

		public IDisposable disposables;
	}

	[SerializeField]
	private GameObject redDot;

	[SerializeField]
	private Data notiData;

	[SerializeField]
	private Data ignoreData;

	private CompositeDisposable disposables;

	private void Awake()
	{
		disposables = new CompositeDisposable();
	}

	public void Init()
	{
		UpdateActive();
	}

	public void UpdateActive()
	{
		if (redDot == null) return;
		bool showNoti = notiData != null && notiData.on;
		bool showIgnore = ignoreData != null && ignoreData.on;
		if (notiData != null && notiData.reverse) showNoti = !showNoti;
		if (ignoreData != null && ignoreData.reverse) showIgnore = !showIgnore;
		redDot.SetActive(showNoti && !showIgnore);
	}

	public void UpdateRedDotPos(Vector3 worldPos)
	{
		if (redDot != null)
			redDot.transform.position = worldPos;
	}

	private void OnDestroy()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
		if (notiData != null && notiData.disposables != null)
		{
			notiData.disposables.Dispose();
			notiData.disposables = null;
		}
		if (ignoreData != null && ignoreData.disposables != null)
		{
			ignoreData.disposables.Dispose();
			ignoreData.disposables = null;
		}
	}
}
