using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemFactoryStorage : MonoBehaviour
{
	[SerializeField]
	private Button Btn;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Count;

	[SerializeField]
	private GameObject SelectObj;

	private CompositeDisposable disposables;

	public Action<int> SelectCb;

	public int ProductIdx { get; private set; }

	private void Awake()
	{
		disposables = new CompositeDisposable();
		if (Btn != null) Btn.onClick.AddListener(OnClickSelect);
	}

	public void Set(int product)
	{
		ProductIdx = product;
		UpdateCount();
		SetSelect(false);
	}

	public void UpdateCount()
	{
		if (Count != null) Count.text = "0";
	}

	public void SetSelect(bool value)
	{
		if (SelectObj != null) SelectObj.SetActive(value);
	}

	private void OnClickSelect()
	{
		SelectCb?.Invoke(ProductIdx);
	}

	public void ClearDisposable()
	{
		if (disposables != null) { disposables.Dispose(); disposables = new CompositeDisposable(); }
	}

	private void OnDestroy()
	{
		if (disposables != null) { disposables.Dispose(); disposables = null; }
	}
}
