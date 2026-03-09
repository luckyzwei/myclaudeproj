using Balancy;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MilestoneCell : MonoBehaviour
{
	private const string ANIM_AVAILABLE = "Available";

	private const string ANIM_COLLECTED = "Collected";

	[SerializeField]
	protected AnimatorHelper m_animatorHelper;

	[SerializeField]
	protected Image m_milestoneIcon;

	[SerializeField]
	protected TextMeshProUGUI m_milestoneName;

	public virtual void Configure(UnnyObject sprite, string name)
	{
	}

	public virtual void SetAvailable()
	{
	}

	public virtual void SetCollected()
	{
	}

	public virtual void Claim()
	{
	}
}
