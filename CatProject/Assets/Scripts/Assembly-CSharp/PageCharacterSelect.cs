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
	}

	public override void OnShowBefore()
	{
	}

	private void GotoChar(bool init = false)
	{
	}

	private void OnClickPrev()
	{
	}

	private void OnClickNext()
	{
	}

	private void OnClickSelect()
	{
	}
}
