using System;
using UnityEngine;
using UnityEngine.UI;

public class CalendarCell : MonoBehaviour
{
	private const string ANIM_LOCKED = "Locked";

	private const string ANIM_COMPLETED = "Completed";

	private const string ANIM_UNLOCKED = "Unlocked";

	private const string ANIM_HIGHLIGHTED = "Highlighted";

	private const string ANIM_DISABLED = "Disabled";

	private const string ANIM_FAILED = "Lose";

	[SerializeField]
	protected Text m_cellText;

	[SerializeField]
	protected AnimatorHelper m_animatorHelper;

	[SerializeField]
	protected Button m_button;

	private Action<DCDate> m_onSelectedCallBack;

	protected DCDate m_dcDate;

	private void Start()
	{
	}

	public virtual void Config(DCDate dcDate, Action<DCDate> onSelected)
	{
	}

	protected virtual void CellSelected()
	{
	}

	public virtual void SelectedCell()
	{
	}

	public virtual void CompletedCell()
	{
	}

	public virtual void AvailableCell()
	{
	}

	public virtual void FailedCell()
	{
	}

	public virtual void DisableCell()
	{
	}

	public virtual void UnavailableCell()
	{
	}
}
