using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/OpenSlotBonus", true)]
[FloatingDepth(2)]
public class InGameOpenSlotBonus : InGameFloatingUI
{
	[SerializeField]
	private Image imgIcon;

	[SerializeField]
	private Text textValue;

	public Image GetIcon => null;

	public void Init(Vector2 pos)
	{
	}
}
