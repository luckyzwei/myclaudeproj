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
		if (Icon != null && img != null)
			Icon.sprite = img;
		if (Name != null)
			Name.text = name ?? string.Empty;
		if (Ratio != null)
			Ratio.text = (ratio * 100f).ToString("F2") + "%";
		if (SpecialRewardObj != null)
			SpecialRewardObj.SetActive(isSpecialReward);
	}

	public void Set(string name, float ratio)
	{
		if (Name != null)
			Name.text = name ?? string.Empty;
		if (Ratio != null)
			Ratio.text = (ratio * 100f).ToString("F2") + "%";
	}

	public void SetTarotRatio(float ratio1, float ratio2, float ratio3)
	{
		if (Ratio != null)
			Ratio.text = (ratio1 * 100f).ToString("F2") + "%";
		if (Ratio2 != null)
			Ratio2.text = (ratio2 * 100f).ToString("F2") + "%";
		if (Ratio3 != null)
			Ratio3.text = (ratio3 * 100f).ToString("F2") + "%";
	}
}
