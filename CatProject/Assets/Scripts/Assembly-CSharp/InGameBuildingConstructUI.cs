using Treeplla;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/Seasonal/BuildingConstructUI", false)]
[FloatingDepth(11)]
public class InGameBuildingConstructUI : InGameFloatingUI
{
	[SerializeField]
	private Button ConstructBtn;

	[SerializeField]
	private Text RemainTimeText;

	public UnityAction OnClickedConstructBtnAction;

	private void Awake()
	{
	}

	public void SetBuildingConstructInfo()
	{
	}

	public void OnClickedConstructBtn()
	{
	}
}
