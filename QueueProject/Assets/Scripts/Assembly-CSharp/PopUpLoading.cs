using KWCore.UI;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PopUpLoading : PopUpBase
{
	public const string PREFAB_NAME = "Prefabs/Popups/PopUp-LoadingScreen";

	private const float FADE_OUT_TIME = 0.5f;

	[SerializeField]
	private Image m_fillBarImage;

	[SerializeField]
	private TextMeshProUGUI m_loadingText;

	[SerializeField]
	private TextMeshProUGUI m_tipText;

	[SerializeField]
	private CanvasGroup m_group;

	[SerializeField]
	private bool m_autoClose;

	private UnityEvent m_popupClosedEvent;

	private bool m_finished;

	private float m_timer;

	private bool m_isRegistered;

	public void Config(string loadingText, float staticLoadAmount, string tipText = null)
	{
	}

	private void SetLoadingText(string text)
	{
	}

	private void SetTipText(string text)
	{
	}

	private void SetLoadingPercentage(float percentage)
	{
	}

	public virtual void Config(UnityAction popupClosedCallback)
	{
	}

	private void Update()
	{
	}

	public virtual void Close()
	{
	}

	public void FadeOut()
	{
	}
}
