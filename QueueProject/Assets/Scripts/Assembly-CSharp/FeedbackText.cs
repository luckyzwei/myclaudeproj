using UnityEngine.UI;
using UnityEngine;

public class FeedbackText : MonoBehaviour
{
	[SerializeField]
	private AnimatorHelper m_animatorHelper;

	[SerializeField]
	private Text m_text;

	[SerializeField]
	private string m_animationName;

	private void OnEnable()
	{
		if (m_animatorHelper != null && !string.IsNullOrEmpty(m_animationName))
			m_animatorHelper.Play(m_animationName);
	}

	public void Deactivate()
	{
		gameObject.SetActive(false);
	}

	public void Activate(string text)
	{
		if (m_text != null)
			m_text.text = text;
		gameObject.SetActive(true);
	}
}
