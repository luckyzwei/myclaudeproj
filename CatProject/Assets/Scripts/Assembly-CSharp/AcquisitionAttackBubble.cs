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
		if (AttackWordObj != null)
			AttackWordOriginPos = AttackWordObj.transform.localPosition;
		PlaySpeed = 1f;
	}

	public void Init()
	{
		if (AttackWordObj != null) AttackWordObj.SetActive(false);
		if (AttackTargetObj != null) AttackTargetObj.SetActive(false);
		KillSequence();
	}

	public void Reset()
	{
		KillSequence();
		if (AttackWordObj != null)
		{
			AttackWordObj.transform.localPosition = AttackWordOriginPos;
			AttackWordObj.SetActive(false);
		}
		if (AttackTargetObj != null) AttackTargetObj.SetActive(false);
	}

	public void PlayShow()
	{
		gameObject.SetActive(true);
		if (Animator != null) Animator.Play("Show");
	}

	public void PlayHide(Action onComplete = null)
	{
		OnMoveComplete = onComplete;
		if (Animator != null) Animator.Play("Hide");
		OnMoveComplete?.Invoke();
	}

	public void OnTriggerAttackWord(float moveTime)
	{
		if (AttackWordObj == null || AttackTargetObj == null) return;
		AttackWordObj.SetActive(true);
		AttackWordObj.transform.localPosition = AttackWordOriginPos;
		KillSequence();
		MoveSequence = DOTween.Sequence();
		MoveSequence.Append(
			AttackWordObj.transform.DOLocalMove(AttackTargetObj.transform.localPosition, moveTime / PlaySpeed)
				.SetEase(AttackEaseType));
		MoveSequence.OnComplete(() =>
		{
			AttackWordObj.SetActive(false);
			OnMoveComplete?.Invoke();
		});
	}

	public void SetPlaySpeed(float speed)
	{
		PlaySpeed = speed > 0f ? speed : 1f;
	}

	private void KillSequence()
	{
		if (MoveSequence != null)
		{
			MoveSequence.Kill();
			MoveSequence = null;
		}
	}

	private void OnDestroy()
	{
		KillSequence();
	}

	private void OnDisable()
	{
		KillSequence();
	}
}
