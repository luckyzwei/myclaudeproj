using System;
using System.Collections.Generic;
using UnityEngine;

public class TpImmersiveAdMobController : MonoBehaviour
{
	[SerializeField]
	private int AdIdx;

	[SerializeField]
	private float scale;

	[SerializeField]
	private GameObject screenObject;

	[Header("노애즈로 지워질때 대안으로 켜줄 오브젝트")]
	[SerializeField]
	private List<GameObject> alternativeObj;

	[Header("노애즈로 지워질때 같이 지워질 오브젝트")]
	[SerializeField]
	private List<GameObject> alternativeDesroyObj;

	[Header("컨텐츠 오픈 후 && 노애즈로 지워질때 대안으로 켜줄 오브젝트")]
	[SerializeField]
	private List<GameObject> alternativeOpenObj;

	[Header("맵 오브젝트인지 여부")]
	[SerializeField]
	private bool isMapObj;

	private bool isInit;

	public int adRefreshTime;

	private DateTime lastRefreshTime;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	private void ShowAd()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}
}
