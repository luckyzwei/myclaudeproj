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
	}

	public void Init(GameNotificationSystem.NotificationCategory category, int _targetIdx, int _targetSubIdx)
	{
	}

	public void Add(GameNotificationSystem.NotificationCategory _category, int _targetIdx, int _targetSubIdx, bool _reverse)
	{
	}

	public void Clear()
	{
	}

	public virtual void UpdateActive()
	{
	}

	public void UpdateRedDotPos(Vector3 worldPos)
	{
	}

	private void OnDestroy()
	{
	}
}
