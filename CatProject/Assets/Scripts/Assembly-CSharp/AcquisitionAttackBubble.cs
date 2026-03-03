using System;
using DG.Tweening;
using UnityEngine;

public class AcquisitionAttackBubble : MonoBehaviour
{
	[SerializeField]
	private Animator Animator;

	[SerializeField]
	private GameObject AttackWordObj;

	[SerializeField]
	private GameObject AttackTargetObj;

	[SerializeField]
	private Ease AttackEaseType;

	private Vector3 AttackWordOriginPos;

	private Sequence MoveSequence;

	private Action OnMoveComplete;

	private float PlaySpeed;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void Reset()
	{
	}

	public void PlayShow()
	{
	}

	public void PlayHide(Action onComplete = null)
	{
	}

	public void OnTriggerAttackWord(float moveTime)
	{
	}

	public void SetPlaySpeed(float speed)
	{
	}

	private void KillSequence()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
