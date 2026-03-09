using UnityEngine;

[CreateAssetMenu(fileName = "Screen Transition Animations", menuName = "Kwalee/KWGameCore/Screen Transition", order = 2)]
public class ScreenTransitionData : ScriptableObject
{
	[Header("Intro")]
	public bool hasIntro;

	public string introAnimation;

	public float waitBeforeIntroTime;

	[Header("Outro")]
	public bool hasOutro;

	public string outroAnimation;

	public float stayAliveAfterOutroTime;
}
