using System;
using UnityEngine;
using UnityEngine.UI;

public class TabToolbarButton : MonoBehaviour
{
	private const string ANIM_SELECTED = "Selected";

	private const string ANIM_DESELECTED = "DeSelected";

	[SerializeField]
	private Button m_button;

	[SerializeField]
	private bool m_isLocked;

	[Header("Additional Parameters")]
	[SerializeField]
	private bool m_requiresConnection;

	[Header("Visuals")]
	[SerializeField]
	protected Image m_icon;

	[SerializeField]
	private Sprite m_lockedSprite;

	[SerializeField]
	private GameObject m_lockPopUp;

	private AnimatorHelper m_animatorHelper;

	private int m_tabIndex;

	private Action<int> m_onButtonPressed;

	private bool m_isHighlighted;

	private bool m_init;

	private Sprite m_originalSprite;

	public int TabIndex => 0;

	protected void Awake()
	{
	}

	private void Start()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void OnButtonClicked()
	{
	}

	protected virtual void ShowLock()
	{
	}

	public virtual void Config(int tabIndex, Action<int> callback)
	{
	}

	public virtual void Highlight(bool highlighted, bool immediately = false)
	{
	}

	public bool IsLocked()
	{
		return false;
	}

	public virtual void SetLockStatus(bool locked)
	{
	}
}
