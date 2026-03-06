using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupRewardExpInfo", false, false)]
public class PopupRewardExpInfo : UIBase
{
	[SerializeField]
	private ScrollRect Scroll;

	[SerializeField]
	private GameObject Item;

	[SerializeField]
	private GameObject EnableLvUpObj;

	[SerializeField]
	private GameObject NothingObj;

	public void SetRewardExp(BigInteger Exp)
	{
		// Update display
	}
}
