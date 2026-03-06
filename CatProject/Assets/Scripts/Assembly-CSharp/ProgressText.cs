using UnityEngine;
using UnityEngine.UI;

public class ProgressText : MonoBehaviour
{
	[SerializeField]
	private Text ValueText;

	[SerializeField]
	private Slider ProgressSlider;

	public void SetText(string text)
	{
		if (ValueText != null) ValueText.text = text;
	}

	public void SetProgress(float value)
	{
		if (ProgressSlider != null) ProgressSlider.value = value;
	}
}
