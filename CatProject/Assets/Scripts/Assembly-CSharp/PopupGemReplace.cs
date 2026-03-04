using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupGemReplace", false, false)]
public class PopupGemReplace : UIBase
{
	[Header("PopupGemReplace")]
	[SerializeField]
	private ItemArticle rewardItemArticle;

	[SerializeField]
	private Text gemCountText;

	private BigInteger gemCount;

	public override void OnShowBefore()
	{
	}

	public void Set(int tarotIdx)
	{
	}
}
