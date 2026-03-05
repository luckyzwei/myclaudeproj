using System;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/InGame/Progress", false, false)]
public class InGameFarmProgress : InGameFloatingUI
{
	[SerializeField]
	private Image progressImg;

	[SerializeField]
	private Image autoProgressImg;

	[SerializeField]
	private Image productImg;

	[SerializeField]
	private GameObject AutoObject;

	[SerializeField]
	private GameObject NonAutoObject;

	[SerializeField]
	private Text productPrice;

	[SerializeField]
	private Button FacilityUIBtn;

	[SerializeField]
	private GameObject LvUpObj;

	[SerializeField]
	private GameObject FullLvUpObj;

	public Action clickAction;

	private bool auto;

	private void Awake()
	{
		if (FacilityUIBtn != null)
			FacilityUIBtn.onClick.AddListener(OnClickBtn);
	}

	public void UpdateValue(float value)
	{
		float clamped = Mathf.Clamp01(value);
		if (auto)
		{
			if (autoProgressImg != null)
				autoProgressImg.fillAmount = clamped;
		}
		else
		{
			if (progressImg != null)
				progressImg.fillAmount = clamped;
		}
	}

	public void SetProductImg(Sprite img)
	{
		if (productImg != null)
			productImg.sprite = img;
	}

	public void SetPrice(string value)
	{
		if (productPrice != null)
			productPrice.text = value;
	}

	public void SetAuto(bool value)
	{
		auto = value;
		if (AutoObject != null)
			AutoObject.SetActive(auto);
		if (NonAutoObject != null)
			NonAutoObject.SetActive(!auto);
	}

	public void SetLvUpEnable(int step)
	{
		if (LvUpObj != null)
			LvUpObj.SetActive(step > 0);
		if (FullLvUpObj != null)
			FullLvUpObj.SetActive(step >= 2);
	}

	private void OnClickBtn()
	{
		clickAction?.Invoke();
	}
}
