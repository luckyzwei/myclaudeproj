using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemOfficeItem : MonoBehaviour
{
	[SerializeField]
	private Button Btn;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Level;

	[SerializeField]
	private GameObject NoHaveObj;

	[SerializeField]
	private GameObject SelectObj;

	[SerializeField]
	private GameObject UpgradableObj;

	public Action<int, int> ClickCb;

	private IDisposable Disposable;

	public int OfficeIdx { get; private set; }

	public int ItemIdx { get; private set; }

	public int ItemType { get; private set; }

	public int LevelValue { get; private set; }

	private void Awake()
	{
		if (Btn != null) Btn.onClick.AddListener(OnClickItem);
	}

	private void OnDestroy()
	{
		if (Disposable != null) { Disposable.Dispose(); Disposable = null; }
	}

	public void Set(int office, int type, int idx)
	{
		OfficeIdx = office;
		ItemType = type;
		ItemIdx = idx;
		LevelValue = 0;
		if (NoHaveObj != null) NoHaveObj.SetActive(false);
		SetUpgradableState();
	}

	private void SetUpgradableState()
	{
		if (UpgradableObj != null) UpgradableObj.SetActive(false);
	}

	public void Select(bool value)
	{
		if (SelectObj != null) SelectObj.SetActive(value);
	}

	private void OnClickItem()
	{
		ClickCb?.Invoke(ItemType, ItemIdx);
	}
}
