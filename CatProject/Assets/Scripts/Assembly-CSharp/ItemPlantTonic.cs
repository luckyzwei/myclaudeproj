using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemPlantTonic : MonoBehaviour
{
	[SerializeField]
	private Button Btn;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Count;

	[SerializeField]
	private GameObject SelectObj;

	public Action<int> ClickCb;

	public int Idx { get; private set; }

	private void Awake()
	{
		if (Btn != null) Btn.onClick.AddListener(OnClickItem);
	}

	public void Set(int idx, CompositeDisposable disposables)
	{
		Idx = idx;
	}

	public void Select(bool value)
	{
		if (SelectObj != null) SelectObj.SetActive(value);
	}

	private void OnClickItem()
	{
		ClickCb?.Invoke(Idx);
	}
}
