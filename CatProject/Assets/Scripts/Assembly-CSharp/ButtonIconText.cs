using System;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class ButtonIconText : MonoBehaviour
{
	[SerializeField]
	private bool OneClick;

	[SerializeField]
	private Button btn;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Text text;

	[SerializeField]
	private HorizontalLayoutGroup layout;

	public Action OnClick;

	private int left;

	private int right;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void SetData(int rewardType, int rewardIdx, BigInteger rewardCnt, bool shortCnt = false)
	{
	}

	public void SetIcon(Sprite sprite)
	{
	}

	public void SetCnt(BigInteger rewardCnt, bool shortCnt = false)
	{
	}

	public void SetCnt(string cnt)
	{
	}

	public void SetBtnEnable(bool value)
	{
	}

	private void OnClickBtn()
	{
	}

	public Image GetImage()
	{
		return null;
	}

	public Text GetText()
	{
		return null;
	}

	public Button GetBtn()
	{
		return null;
	}

	private void CheckLayout()
	{
	}
}
