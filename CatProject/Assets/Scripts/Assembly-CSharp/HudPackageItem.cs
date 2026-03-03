using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class HudPackageItem : MonoBehaviour
{
	[SerializeField]
	private Button Btn;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private GameObject TimeRoot;

	[SerializeField]
	private Text TimeText;

	[SerializeField]
	private GameObject SaleRoot;

	[SerializeField]
	private Text SaleText;

	[SerializeField]
	private bool isHUD;

	public Action OnExpired;

	private CompositeDisposable disposables;

	public int PackageIdx { get; private set; }

	private void Awake()
	{
	}

	public void SetManually(int idx, Action onExpired)
	{
	}

	public void Set(int idx)
	{
	}

	private bool CheckRemainSameGroupPackage(int group)
	{
		return false;
	}

	private void UpdateSaleText()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClickBtn()
	{
	}
}
