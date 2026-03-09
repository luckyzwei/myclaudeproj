using TMPro;
using UnityEngine;

public class FeedbackText : MonoBehaviour
{
	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private TMP_Text m_text;

	[SerializeField]
	private string m_animationName;

	private void OnEnable()
	{
	}

	public void Deactivate()
	{
	}

	public void Activate(string text)
	{
	}
}
