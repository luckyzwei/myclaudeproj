using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemManagerCardMin : MonoBehaviour
{
	[Header("ItemManagerCardMin")]
	[SerializeField]
	private Button ManagerBtn;

	[Header("Info")]
	[SerializeField]
	private Image ManagerFrame;

	[SerializeField]
	private Image ManagerImg;

	[SerializeField]
	private Text ManagerLevel;

	[SerializeField]
	private Image AbilityIcon;

	[SerializeField]
	private Text AbilityValue;

	[Space(5f)]
	[SerializeField]
	private GameObject ManagerHireRoot;

	[SerializeField]
	private Image ManagerHireIcon;

	[SerializeField]
	private Text ManagerHireText;

	[Space(10f)]
	[SerializeField]
	private Button infoBtn;

	[SerializeField]
	private GameObject managerSelect;

	private int curManagerIdx;

	private Action onClickCb;

	public GameObject ManagerSelect { get { return null; } }

	private void Awake()
	{
	}

	private void OnClickManager()
	{
	}

	private void OnClickInfo()
	{
	}

	public void Set(int idx, int level, Action cb = null)
	{
	}

	private void UpdateValue()
	{
	}

	public void SetAbilityTextColor(bool isLevel)
	{
	}
}
