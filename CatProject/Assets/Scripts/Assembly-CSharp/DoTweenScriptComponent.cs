using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class DoTweenScriptComponent : MonoBehaviour
{
	private enum Type
	{
		Position = 0,
		LocalPosition = 1,
		Alpha = 2,
		MoveY = 3,
		MoveX = 4,
		DelayCallback = 5,
		LocalMoveY = 6,
		LocalMoveX = 7,
		Scale = 8,
		ScaleY = 9,
		ScaleX = 10,
		Rotation = 11,
		LocalRotation = 12
	}

	private enum Loop
	{
		Once = 0,
		Restart = 1,
		Yoyo = 2
	}

	[Serializable]
	private class DoTweenInfo
	{
		public Type TweenType;

		public float Value;

		public Vector3 To;

		public float Duration;

		public float Delay;

		public Ease EaseType;

		public bool customGraph;

		public AnimationCurve customCurve;

		public UnityEvent Callback;
	}

	[SerializeField]
	private List<DoTweenInfo> Tweens;

	[SerializeField]
	private Loop LoopType;

	[SerializeField]
	private bool AutoPlay;

	[SerializeField]
	private bool OnEnablePlay;

	[Header("트윈 다시 재생시 위치, 회전 초기화 안될때 체크.")]
	[SerializeField]
	[FormerlySerializedAs("DisableResetTransform")]
	private bool EnableResetTransform;

	private Sequence seq;

	private Color originColor;

	private Vector3 originScale;

	private Vector3 originPosition;

	private Quaternion originRotation;

	private void Awake()
	{
	}

	private Sequence CreateSeq()
	{
		return null;
	}

	public void SetId(string id)
	{
	}

	public void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Reset()
	{
	}

	public void AddCallback(Action action)
	{
	}

	public Vector3 LastValue()
	{
		return default(Vector3);
	}

	public void Play()
	{
	}

	public void PlayWithCallback(Action cb)
	{
	}

	public void Play(object id)
	{
	}

	public void SetPlaySpeed(float playSpeed)
	{
	}

	public float GetTweensMaxDuration()
	{
		return 0f;
	}

	public bool isPlaying()
	{
		return false;
	}

	public void Pause()
	{
	}

	public void ReverseInit()
	{
	}

	public void ResetOriginTransform()
	{
	}

	private void OnDestroy()
	{
	}

	public Sequence GetSequence()
	{
		return null;
	}

	public void InitSequence()
	{
	}
}
