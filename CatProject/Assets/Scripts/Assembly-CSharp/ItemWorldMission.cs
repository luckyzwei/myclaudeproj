using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemWorldMission : MonoBehaviour
{
	[Header("State")]
	[SerializeField]
	private GameObject obj_lock;

	[SerializeField]
	private GameObject obj_recevied;

	[Header("Buttons")]
	[SerializeField]
	private Button btn_move;

	[SerializeField]
	private Button btn_clear;

	[Header("Mission Info")]
	[SerializeField]
	private Image img_mission;

	[SerializeField]
	private Text text_mission_desc;

	[SerializeField]
	private Text text_slider_value;

	[SerializeField]
	private Slider slider_mission;

	[Header("Animator")]
	[SerializeField]
	private Animator ani_unlock;

	[Header("Reddot")]
	[SerializeField]
	private GameObject reddot;

	private int regionIdx;

	public int missionIdx;

	private E_RichAchieveMissionClearType mission_clear_type;

	private WeakReference<PageRichAchieve> pageUI;

	private void Awake()
	{
		if (btn_move != null) btn_move.onClick.AddListener(OnClickMove);
		if (btn_clear != null) btn_clear.onClick.AddListener(OnClickClear);
	}

	public void SetInfo(int idx, int regionIdx, PageRichAchieve pageOwner)
	{
		missionIdx = idx;
		this.regionIdx = regionIdx;
		if (pageOwner != null) pageUI = new WeakReference<PageRichAchieve>(pageOwner);

		SetImg();
		SetDesc();
		ChangeState();
	}

	private void ChangeState()
	{
		bool isLock = IsCheckLockMission(regionIdx, missionIdx);
		bool isReceived = false; // Check from user data
		bool isClearAble = false; // Check if mission is completable

		SetStateObj(isLock, isReceived);
		SetButtons(isReceived, isClearAble, isLock);
		SetSlider(isReceived);

		if (reddot != null) reddot.SetActive(isClearAble && !isReceived && !isLock);
	}

	private bool IsCheckLockMission(int regionIdx, int missionIdx)
	{
		// Check if mission is locked based on region progress
		return false;
	}

	private void SetImg()
	{
		if (img_mission == null) return;
		// Load mission image
	}

	private void SetDesc()
	{
		if (text_mission_desc != null) text_mission_desc.text = "";
	}

	private void SetButtons(bool isReceived, bool isClearAble, bool isLock)
	{
		if (btn_move != null) btn_move.gameObject.SetActive(!isReceived && !isClearAble && !isLock);
		if (btn_clear != null) btn_clear.gameObject.SetActive(!isReceived && isClearAble && !isLock);
	}

	private void SetStateObj(bool isLock, bool isReceived)
	{
		if (obj_lock != null) obj_lock.SetActive(isLock);
		if (obj_recevied != null) obj_recevied.SetActive(isReceived);
	}

	private void SetSlider(bool isReceived)
	{
		if (slider_mission == null) return;
		if (isReceived)
		{
			slider_mission.value = 1f;
			if (text_slider_value != null) text_slider_value.text = "";
		}
		else
		{
			slider_mission.value = 0f;
			if (text_slider_value != null) text_slider_value.text = "0/0";
		}
	}

	private void OnClickMove()
	{
	}

	private void OnClickClear()
	{
		// Claim mission reward
		PageRichAchieve page;
		if (pageUI != null && pageUI.TryGetTarget(out page))
		{
			page.RedrawRewardState();
		}
		ChangeState();
	}

	public void PlayUnlockAni()
	{
		if (ani_unlock != null) ani_unlock.SetTrigger("Unlock");
	}

	public Sprite GetMissionImg()
	{
		if (img_mission != null) return img_mission.sprite;
		return null;
	}

	public string GetRichMissionDescText()
	{
		if (text_mission_desc != null) return text_mission_desc.text;
		return string.Empty;
	}
}
