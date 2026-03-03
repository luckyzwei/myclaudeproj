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
	}

	public void Set(int product)
	{
	}

	public void UpdateCount()
	{
	}

	public void SetSelect(bool value)
	{
	}

	private void OnClickSelect()
	{
	}

	public void ClearDisposable()
	{
	}

	private void OnDestroy()
	{
	}
}
