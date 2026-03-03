using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/CompanyNameUI", true)]
[FloatingDepth(0)]
public class InGameCompanyNameUI : InGameFloatingUI
{
	[SerializeField]
	private Text CompanyName;

	public void UpdateName()
	{
	}
}
