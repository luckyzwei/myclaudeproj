using UnityEngine;
using UnityEngine.UI;

public class ShopContentsManager : IShopContents
{
	[SerializeField]
	private Button infoBtn;

	private void Awake()
	{
		if (infoBtn != null)
			infoBtn.onClick.AddListener(OnClickInfo);
	}

	public override void Init()
	{
		base.Init();
	}

	private void OnClickInfo()
	{
	}
}
