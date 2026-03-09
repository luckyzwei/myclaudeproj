using System.Collections.Generic;
using UnityEngine;

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
	}

	private void Awake()
	{
	}

	public void SetText(string key)
	{
	}

	private void LookupText()
	{
	}

	private void SetLocalisedText(string value)
	{
	}
}
