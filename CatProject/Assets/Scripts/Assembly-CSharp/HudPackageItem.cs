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
		disposables = new CompositeDisposable();
		if (Btn != null)
			Btn.onClick.AddListener(OnClickBtn);
	}

	public void SetManually(int idx, Action onExpired)
	{
		PackageIdx = idx;
		OnExpired = onExpired;
		UpdateSaleText();
	}

	public void Set(int idx)
	{
		PackageIdx = idx;
		UpdateSaleText();
	}

	private bool CheckRemainSameGroupPackage(int group)
	{
		// Check if there are remaining packages in the same group
		return false;
	}

	private void UpdateSaleText()
	{
		if (SaleRoot != null)
			SaleRoot.SetActive(false);
		if (TimeRoot != null)
			TimeRoot.SetActive(false);
	}

	private void OnDisable()
	{
		if (disposables != null)
			disposables.Clear();
	}

	private void OnDestroy()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = null;
		}
	}

	private void OnClickBtn()
	{
		// Open package shop page
	}
}
