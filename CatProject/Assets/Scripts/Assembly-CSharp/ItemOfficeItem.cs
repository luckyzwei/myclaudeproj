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
	}

	private void OnDestroy()
	{
	}

	public void Set(int office, int type, int idx)
	{
	}

	private void SetUpgradableState()
	{
	}

	public void Select(bool value)
	{
	}

	private void OnClickItem()
	{
	}
}
