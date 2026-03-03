using System.Collections.Generic;
using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageFactoryProcess", false, false)]
public class PageFactoryProcess : UIBase
{
	[SerializeField]
	private Text StorageCount;

	[SerializeField]
	private List<ItemFactoryProcess> Process;

	[SerializeField]
	private Button BeforeBtn;

	[SerializeField]
	private Button AfterBtn;

	[SerializeField]
	private List<GameObject> MarkObjs;

	private int CurPage;

	private CompositeDisposable storage_disposables;

	protected override void Awake()
	{
	}

	public void Init()
	{
	}

	public void SetFocus(List<int> productIdxList)
	{
	}

	private void UpdatePage()
	{
	}

	private void OnClickBefore()
	{
	}

	private void OnClickAfter()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
