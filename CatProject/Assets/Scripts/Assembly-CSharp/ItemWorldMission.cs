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
	}

	public void SetInfo(int idx, int regionIdx, PageRichAchieve pageOwner)
	{
	}

	private void ChangeState()
	{
	}

	private bool IsCheckLockMission(int regionIdx, int missionIdx)
	{
		return false;
	}

	private void SetImg()
	{
	}

	private void SetDesc()
	{
	}

	private void SetButtons(bool isReceived, bool isClearAble, bool isLock)
	{
	}

	private void SetStateObj(bool isLock, bool isReceived)
	{
	}

	private void SetSlider(bool isReceived)
	{
	}

	private void OnClickMove()
	{
	}

	private void OnClickClear()
	{
	}

	public void PlayUnlockAni()
	{
	}

	public Sprite GetMissionImg()
	{
		return null;
	}

	public string GetRichMissionDescText()
	{
		return null;
	}
}
