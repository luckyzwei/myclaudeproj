using System.Numerics;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/PageRewardExp", false, false)]
public class PageRewardExp : UIBase
{
	[SerializeField]
	private ScrollRect Scroll;

	[SerializeField]
	private GameObject Item;

	[SerializeField]
	private Button CloseBtn;

	[SerializeField]
	private GameObject EnableLvUpObj;

	[SerializeField]
	private GameObject NothingObj;

	[Header("SpecialDay Theme")]
	[SerializeField]
	private Image TileImg;

	[SerializeField]
	private Image TileBgImg;

	private Sprite originTile;

	private Color originTileBgColor;

	protected override void Awake()
	{
	}

	public override void OnShowBefore()
	{
	}

	public override void OnShowAfter()
	{
	}

	public void SetRewardExp(BigInteger Exp, in int region, bool SetSpecialTheme = false)
	{
	}

	private void StartScroll()
	{
	}

	private void InitTheme()
	{
	}

	public void UpdateSpecialTheme(bool isSetSpecialTheme)
	{
	}
}
