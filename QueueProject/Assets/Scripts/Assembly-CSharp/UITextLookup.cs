using System.Collections;
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
		ForceApplyLocalisation();
	}

	private void OnEnable()
	{
		// Timeline 动画可能在同帧的 LateUpdate 覆盖文本
		// 延迟一帧重新应用本地化
		ForceApplyLocalisation();
		if (Application.isPlaying)
			StartCoroutine(DelayedLookup());
	}

	private IEnumerator DelayedLookup()
	{
		yield return null; // 等一帧，让 Timeline 先执行
		ForceApplyLocalisation();
	}

	public void SetText(string key)
	{
		m_stringKey = key;
		ForceApplyLocalisation();
	}

	private void ForceApplyLocalisation()
	{
		if (string.IsNullOrEmpty(m_stringKey)) return;

		string localised = Kwalee.GetLocalisedText(m_stringKey);
		if (string.IsNullOrEmpty(localised))
			localised = m_stringKey; // Fallback to key

		var text = GetComponent<Text>();
		if (text != null)
		{
			text.text = localised;
			m_delegate?.OnTextLocalised();
		}
	}
}
