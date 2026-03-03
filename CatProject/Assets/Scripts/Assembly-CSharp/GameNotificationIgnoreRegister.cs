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
	}

	public void Init()
	{
	}

	public void UpdateActive()
	{
	}

	public void UpdateRedDotPos(Vector3 worldPos)
	{
	}

	private void OnDestroy()
	{
	}
}
