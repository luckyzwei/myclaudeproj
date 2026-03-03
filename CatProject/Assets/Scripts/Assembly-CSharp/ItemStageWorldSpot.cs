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
	}

	public void SetStage(int stage)
	{
	}

	private void OnClickStage()
	{
	}

	public Transform GetPlayingIconPos()
	{
		return null;
	}

	public void SetNextStageStatus()
	{
	}

	public void ShowLockObj(bool value)
	{
	}

	public void ShowUnlockObj(bool value)
	{
	}

	public void ShowPlayingIcon(bool value)
	{
	}

	public void ShowParticle1(bool value)
	{
	}

	public void ShowParticle2(bool value)
	{
	}

	public void ShowPlayingIcon()
	{
	}

	public void ShowName(bool show)
	{
	}
}
