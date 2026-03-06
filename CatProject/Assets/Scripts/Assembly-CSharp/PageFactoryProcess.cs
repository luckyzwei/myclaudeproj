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
		base.Awake();
		storage_disposables = new CompositeDisposable();
		if (BeforeBtn != null) BeforeBtn.onClick.AddListener(OnClickBefore);
		if (AfterBtn != null) AfterBtn.onClick.AddListener(OnClickAfter);
	}

	public void Init()
	{
		CurPage = 0;
		UpdatePage();
	}

	public void SetFocus(List<int> productIdxList)
	{
		if (productIdxList == null || productIdxList.Count == 0) return;
		// Calculate which page contains the product and navigate to it
		UpdatePage();
	}

	private void UpdatePage()
	{
		if (Process == null) return;
		for (int i = 0; i < Process.Count; i++)
		{
			if (Process[i] != null)
				Process[i].gameObject.SetActive(true);
		}

		if (MarkObjs != null)
		{
			for (int i = 0; i < MarkObjs.Count; i++)
			{
				if (MarkObjs[i] != null)
					MarkObjs[i].SetActive(i == CurPage);
			}
		}

		if (BeforeBtn != null) BeforeBtn.gameObject.SetActive(CurPage > 0);
		if (AfterBtn != null) AfterBtn.gameObject.SetActive(Process != null && CurPage < Process.Count - 1);
	}

	private void OnClickBefore()
	{
		if (CurPage <= 0) return;
		CurPage--;
		UpdatePage();
	}

	private void OnClickAfter()
	{
		if (Process == null || CurPage >= Process.Count - 1) return;
		CurPage++;
		UpdatePage();
	}

	private void OnDestroy()
	{
		if (storage_disposables != null) { storage_disposables.Dispose(); storage_disposables = null; }
	}

	private void OnDisable()
	{
		if (storage_disposables != null) { storage_disposables.Dispose(); storage_disposables = new CompositeDisposable(); }
	}
}
