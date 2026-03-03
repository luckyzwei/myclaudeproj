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
	}

	public void Set(int idx, CompositeDisposable disposables)
	{
	}

	public void Select(bool value)
	{
	}

	private void OnClickItem()
	{
	}
}
