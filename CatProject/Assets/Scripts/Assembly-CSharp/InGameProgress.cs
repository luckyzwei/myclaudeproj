using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/Progress", true)]
[FloatingDepth(5)]
public class InGameProgress : InGameFloatingUI
{
	[SerializeField]
	private Image progressImg;

	public void UpdateValue(float value)
	{
		// Update display
	}
}
