using UnityEngine;
using UnityEngine.UI;

public class ItemRatioInfo : MonoBehaviour
{
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Name;

	[SerializeField]
	private Text Ratio;

	[SerializeField]
	private Text Ratio2;

	[SerializeField]
	private Text Ratio3;

	[SerializeField]
	private GameObject SpecialRewardObj;

	public void Set(Sprite img, string name, float ratio, bool isSpecialReward)
	{
	}

	public void Set(string name, float ratio)
	{
	}

	public void SetTarotRatio(float ratio1, float ratio2, float ratio3)
	{
	}
}
