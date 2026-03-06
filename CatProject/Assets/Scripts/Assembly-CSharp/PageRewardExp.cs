using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		base.Awake();
		if (CloseBtn != null) CloseBtn.onClick.AddListener(() => Hide());
		InitTheme();
	}

	public override void OnShowBefore()
	{
		if (EnableLvUpObj != null) EnableLvUpObj.SetActive(false);
		if (NothingObj != null) NothingObj.SetActive(false);
	}

	public override void OnShowAfter()
	{
		StartScroll();
	}

	public void SetRewardExp(BigInteger Exp, in int region, bool SetSpecialTheme = false)
	{
		if (SetSpecialTheme) UpdateSpecialTheme(true);

		bool hasExp = Exp > BigInteger.Zero;
		if (EnableLvUpObj != null) EnableLvUpObj.SetActive(hasExp);
		if (NothingObj != null) NothingObj.SetActive(!hasExp);

		Show();
	}

	private void StartScroll()
	{
		if (Scroll != null) Scroll.verticalNormalizedPosition = 1f;
	}

	private void InitTheme()
	{
		if (TileImg != null) originTile = TileImg.sprite;
		if (TileBgImg != null) originTileBgColor = TileBgImg.color;
	}

	public void UpdateSpecialTheme(bool isSetSpecialTheme)
	{
		if (!isSetSpecialTheme)
		{
			if (TileImg != null && originTile != null) TileImg.sprite = originTile;
			if (TileBgImg != null) TileBgImg.color = originTileBgColor;
		}
	}
}
