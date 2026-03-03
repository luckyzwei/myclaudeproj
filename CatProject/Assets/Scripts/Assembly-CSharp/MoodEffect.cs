using UnityEngine;
using UnityEngine.UI;

[EffectPath("Effect/MoodEffect", false, true)]
public class MoodEffect : Effect
{
	[SerializeField]
	private Image Mood;

	public void UpdateMood(EmployeeMoodSystem.Mood mood)
	{
	}
}
