using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
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
		if (btn != null)
			btn.onClick.AddListener(OnClickBtn);
		if (layout != null)
		{
			left = layout.padding.left;
			right = layout.padding.right;
		}
	}

	private void OnEnable()
	{
		CheckLayout();
	}

	public void SetData(int rewardType, int rewardIdx, BigInteger rewardCnt, bool shortCnt = false)
	{
		// Would load icon sprite from atlas based on rewardType/rewardIdx
		SetCnt(rewardCnt, shortCnt);
	}

	public void SetIcon(Sprite sprite)
	{
		if (icon != null)
			icon.sprite = sprite;
	}

	public void SetCnt(BigInteger rewardCnt, bool shortCnt = false)
	{
		if (text != null)
		{
			if (shortCnt)
				text.text = ProjectUtility.GetShortBigInteger(rewardCnt);
			else
				text.text = rewardCnt.ToString();
		}
	}

	public void SetCnt(string cnt)
	{
		if (text != null)
			text.text = cnt;
	}

	public void SetBtnEnable(bool value)
	{
		if (btn != null)
			btn.interactable = value;
	}

	private void OnClickBtn()
	{
		if (OneClick && btn != null)
			btn.interactable = false;
		OnClick?.Invoke();
	}

	public Image GetImage()
	{
		return icon;
	}

	public Text GetText()
	{
		return text;
	}

	public Button GetBtn()
	{
		return btn;
	}

	private void CheckLayout()
	{
		if (layout == null) return;
		bool hasIcon = icon != null && icon.gameObject.activeSelf;
		if (!hasIcon)
		{
			layout.padding.left = 0;
			layout.padding.right = 0;
		}
		else
		{
			layout.padding.left = left;
			layout.padding.right = right;
		}
	}
}
