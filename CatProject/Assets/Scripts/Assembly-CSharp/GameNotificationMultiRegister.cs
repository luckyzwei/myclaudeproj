using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class GameNotificationMultiRegister : MonoBehaviour
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
	private List<Data> listNoti;

	private CompositeDisposable disposables;

	private void Awake()
	{
		disposables = new CompositeDisposable();
		if (listNoti != null)
		{
			for (int i = 0; i < listNoti.Count; i++)
			{
				if (listNoti[i] != null && listNoti[i].awakeRegit)
				{
					// Register notification for awake items
				}
			}
		}
	}

	public void Init(GameNotificationSystem.NotificationCategory category, int _targetIdx, int _targetSubIdx)
	{
		Clear();
		Add(category, _targetIdx, _targetSubIdx, false);
	}

	public void Add(GameNotificationSystem.NotificationCategory _category, int _targetIdx, int _targetSubIdx, bool _reverse)
	{
		if (listNoti == null)
			listNoti = new List<Data>();
		var data = new Data
		{
			category = _category,
			targetIdx = _targetIdx,
			targetSubIdx = _targetSubIdx,
			reverse = _reverse,
			on = false
		};
		listNoti.Add(data);
		UpdateActive();
	}

	public void Clear()
	{
		if (listNoti != null)
		{
			for (int i = 0; i < listNoti.Count; i++)
			{
				if (listNoti[i] != null && listNoti[i].disposables != null)
				{
					listNoti[i].disposables.Dispose();
					listNoti[i].disposables = null;
				}
			}
			listNoti.Clear();
		}
		if (redDot != null)
			redDot.SetActive(false);
	}

	public virtual void UpdateActive()
	{
		if (listNoti == null || redDot == null) return;
		bool anyOn = false;
		for (int i = 0; i < listNoti.Count; i++)
		{
			if (listNoti[i] != null)
			{
				bool isOn = listNoti[i].on;
				if (listNoti[i].reverse) isOn = !isOn;
				if (isOn) { anyOn = true; break; }
			}
		}
		redDot.SetActive(anyOn);
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
		Clear();
	}
}
