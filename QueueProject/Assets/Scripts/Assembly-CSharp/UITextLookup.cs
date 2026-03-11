using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class UITextLookup : MonoBehaviour
{
	public interface IDelegate
	{
		void OnTextLocalised();
	}

	[TextLookup(null, true)]
	[SerializeField]
	private string m_stringKey;

	public static readonly List<string> SUPPORTED_TEXT_COMPONENTS;

	private string m_prevStringKey;

	private IDelegate m_delegate;

	public void SetDelegate(IDelegate iDelegate)
	{
		m_delegate = iDelegate;
	}

	private void Awake()
	{
		LookupText();
	}

	public void SetText(string key)
	{
		m_stringKey = key;
		LookupText();
	}

	private void LookupText()
	{
		if (string.IsNullOrEmpty(m_stringKey)) return;
		if (m_stringKey == m_prevStringKey) return;
		m_prevStringKey = m_stringKey;

		string localised = Kwalee.GetLocalisedText(m_stringKey);
		if (string.IsNullOrEmpty(localised))
			localised = m_stringKey; // Fallback to key

		SetLocalisedText(localised);
	}

	private void SetLocalisedText(string value)
	{
		if (string.IsNullOrEmpty(value)) return;

		var text = GetComponent<Text>();
		if (text != null)
		{
			text.text = value;
			m_delegate?.OnTextLocalised();
		}
	}
}
