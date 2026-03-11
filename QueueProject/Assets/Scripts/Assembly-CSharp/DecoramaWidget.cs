using UnityEngine;
using UnityEngine.UI;

public class DecoramaWidget : MonoBehaviour
{
	[Header("Config")]
	[SerializeField]
	private bool m_isPreview;

	[SerializeField]
	private bool m_toggleStateBasedOnCurrency;

	[SerializeField]
	private string m_lockedDecoramaName;

	[SerializeField]
	private Transform m_buildPosTransform;

	[Header("Elements")]
	[SerializeField]
	private Button m_nextButton;

	[SerializeField]
	private Button m_previousButton;

	[SerializeField]
	private GameObject m_decoramaTitleGO;

	[SerializeField]
	private Text m_decoramaTitleText;

	[SerializeField]
	private Button m_buildButton;

	[SerializeField]
	private RectTransform m_renderTextureTransform;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private DecoramaState GetState()
	{
		return default(DecoramaState);
	}

	private void UpdateState()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Config()
	{
	}

	private void Update()
	{
	}

	private void NextDecorama()
	{
	}

	private void PreviousDecorama()
	{
	}

	private void SetupVisuals(DecoramaState decoramastate)
	{
	}

	private void DecoramaEvents_OnDecoramaUIStateChangedEvent(DecoramaState decoramaState)
	{
	}

	private void DecoramaEvents_OnDecoramaUpdatedEvent(Decorama visibleDecorama)
	{
	}
}
