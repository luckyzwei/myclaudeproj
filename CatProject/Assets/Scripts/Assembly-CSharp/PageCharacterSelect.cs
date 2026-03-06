using System.Collections.Generic;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PageCharacterSelect", false, false)]
public class PageCharacterSelect : UIBase
{
	[SerializeField]
	private Button SelectBtn;

	[SerializeField]
	private Transform CharRoot;

	[SerializeField]
	private List<Animator> Cats;

	[SerializeField]
	private Button LeftBtn;

	[SerializeField]
	private Button RightBtn;

	private int CurIdx;

	private float x_term;

	private int click_cnt;

	protected override void Awake()
	{
		base.Awake();
		if (SelectBtn != null) SelectBtn.onClick.AddListener(OnClickSelect);
		if (LeftBtn != null) LeftBtn.onClick.AddListener(OnClickPrev);
		if (RightBtn != null) RightBtn.onClick.AddListener(OnClickNext);
	}

	public override void OnShowBefore()
	{
		CurIdx = 0;
		click_cnt = 0;
		GotoChar(true);
	}

	private void GotoChar(bool init = false)
	{
		if (Cats == null) return;
		for (int i = 0; i < Cats.Count; i++)
		{
			if (Cats[i] != null)
				Cats[i].gameObject.SetActive(i == CurIdx);
		}
		if (LeftBtn != null) LeftBtn.gameObject.SetActive(CurIdx > 0);
		if (RightBtn != null) RightBtn.gameObject.SetActive(Cats != null && CurIdx < Cats.Count - 1);
	}

	private void OnClickPrev()
	{
		if (CurIdx <= 0) return;
		CurIdx--;
		click_cnt++;
		GotoChar();
	}

	private void OnClickNext()
	{
		if (Cats == null || CurIdx >= Cats.Count - 1) return;
		CurIdx++;
		click_cnt++;
		GotoChar();
	}

	private void OnClickSelect()
	{
		// Confirm character selection
		Hide();
	}
}
