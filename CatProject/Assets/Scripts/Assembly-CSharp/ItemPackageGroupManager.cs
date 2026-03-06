using UnityEngine;
using UnityEngine.UI;

public class ItemPackageGroupManager : ItemPackageGroup
{
	[SerializeField]
	private Text boonText;

	[SerializeField]
	private Image buffIcon;

	[SerializeField]
	private Text buffText;

	[SerializeField]
	private Text lvDescText;

	public override void Set(int packageIdx)
	{
		base.Set(packageIdx);
	}
}
