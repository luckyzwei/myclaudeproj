using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemStageWorldSpot : MonoBehaviour
{
	[SerializeField]
	private Button stageBtn;

	[SerializeField]
	private GameObject lockObject;

	[SerializeField]
	private GameObject lockNextObject;

	[SerializeField]
	private GameObject lockOverObject;

	[SerializeField]
	private GameObject unlockObject;

	[SerializeField]
	private GameObject playingObject;

	[SerializeField]
	private GameObject playingIcon;

	[SerializeField]
	public Animator Anim;

	[SerializeField]
	private Text Name;

	[SerializeField]
	private Transform EnterUITrans;

	[SerializeField]
	private GameObject Particle1;

	[SerializeField]
	private GameObject Particle2;

	private bool isLock;

	public Action<int, Transform> OnClick;

	public int Stage { get; private set; }

	private void Awake()
	{
		if (stageBtn != null) stageBtn.onClick.AddListener(OnClickStage);
	}

	public void SetStage(int stage)
	{
		Stage = stage;
		isLock = true;
		ShowLockObj(true);
		ShowUnlockObj(false);
		ShowPlayingIcon(false);
	}

	private void OnClickStage()
	{
		if (isLock) return;
		OnClick?.Invoke(Stage, EnterUITrans != null ? EnterUITrans : transform);
	}

	public Transform GetPlayingIconPos()
	{
		if (playingIcon != null) return playingIcon.transform;
		return transform;
	}

	public void SetNextStageStatus()
	{
		isLock = false;
		ShowLockObj(false);
		ShowUnlockObj(true);
		if (lockNextObject != null) lockNextObject.SetActive(true);
	}

	public void ShowLockObj(bool value)
	{
		if (lockObject != null) lockObject.SetActive(value);
		if (lockOverObject != null) lockOverObject.SetActive(false);
	}

	public void ShowUnlockObj(bool value)
	{
		if (unlockObject != null) unlockObject.SetActive(value);
		isLock = !value;
	}

	public void ShowPlayingIcon(bool value)
	{
		if (playingObject != null) playingObject.SetActive(value);
		if (playingIcon != null) playingIcon.SetActive(value);
	}

	public void ShowParticle1(bool value)
	{
		if (Particle1 != null) Particle1.SetActive(value);
	}

	public void ShowParticle2(bool value)
	{
		if (Particle2 != null) Particle2.SetActive(value);
	}

	public void ShowPlayingIcon()
	{
		ShowPlayingIcon(true);
	}

	public void ShowName(bool show)
	{
		if (Name != null) Name.gameObject.SetActive(show);
	}
}
