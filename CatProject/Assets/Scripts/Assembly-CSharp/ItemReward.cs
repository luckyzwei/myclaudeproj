using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UnityEngine;
using UnityEngine.UI;

public class ItemReward : MonoBehaviour
{
	[SerializeField]
	private Image rewardIcon;

	[SerializeField]
	private Text rewardText;

	[SerializeField]
	private Image frameBG;

	[SerializeField]
	private GameObject checkObj;

	[SerializeField]
	private GameObject lockObj;

	[SerializeField]
	private GameObject subIcon;

	public void Set(int rewardType, int rewardIdx, BigInteger rewardValue, bool isCheck, bool isLock)
	{
		if (rewardText != null) rewardText.text = ProjectUtility.GetThousandCommaText(rewardValue);
		Checked(isCheck);
		SetLock(isLock);
		if (subIcon != null) subIcon.SetActive(false);
	}

	public void SetText(string text)
	{
		if (rewardText != null) rewardText.text = text;
	}

	public void SetLock(bool value)
	{
		if (lockObj != null) lockObj.SetActive(value);
	}

	public void UnLock()
	{
		SetLock(false);
	}

	public void Checked(bool value)
	{
		if (checkObj != null) checkObj.SetActive(value);
	}

	public void SetEmpty()
	{
		if (rewardIcon != null) rewardIcon.gameObject.SetActive(false);
		if (rewardText != null) rewardText.text = "";
		if (checkObj != null) checkObj.SetActive(false);
		if (lockObj != null) lockObj.SetActive(false);
	}
}
