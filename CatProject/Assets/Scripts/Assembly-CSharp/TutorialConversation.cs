using UnityEngine;
using UnityEngine.UI;

public class TutorialConversation : MonoBehaviour
{
	[Header("Audience")]
	[SerializeField]
	private GameObject AudienceRoot;

	[SerializeField]
	private Image AudienceImg;

	[Header("Ceo")]
	[SerializeField]
	private GameObject CeoRoot;

	[SerializeField]
	private Image CeoImg;

	[Header("Common")]
	[SerializeField]
	private Text Name;

	[SerializeField]
	private Text Line;

	public void Set(Config.AudienceType type, string scriptkey, bool showImg = true, bool showAni = false)
	{
	}

	public void SetText(Config.AudienceType type, string script)
	{
	}
}
