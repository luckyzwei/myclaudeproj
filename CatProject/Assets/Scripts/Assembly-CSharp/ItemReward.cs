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
	}

	public void SetText(string text)
	{
	}

	public void SetLock(bool value)
	{
	}

	public void UnLock()
	{
	}

	public void Checked(bool value)
	{
	}

	public void SetEmpty()
	{
	}
}
