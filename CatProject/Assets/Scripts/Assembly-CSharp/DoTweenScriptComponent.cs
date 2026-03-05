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
		originScale = transform.localScale;
		originPosition = transform.localPosition;
		originRotation = transform.localRotation;
		var cg = GetComponent<CanvasGroup>();
		if (cg != null)
			originColor = new Color(1f, 1f, 1f, cg.alpha);
		if (AutoPlay)
			Play();
	}

	private Sequence CreateSeq()
	{
		var s = DOTween.Sequence();
		if (Tweens == null) return s;
		for (int i = 0; i < Tweens.Count; i++)
		{
			var info = Tweens[i];
			if (info == null) continue;
			Tween tween = null;
			switch (info.TweenType)
			{
				case Type.Position:
					tween = transform.DOMove(info.To, info.Duration);
					break;
				case Type.LocalPosition:
					tween = transform.DOLocalMove(info.To, info.Duration);
					break;
				case Type.Alpha:
					var cg = GetComponent<CanvasGroup>();
					if (cg != null)
						tween = cg.DOFade(info.Value, info.Duration);
					break;
				case Type.MoveY:
					tween = transform.DOMoveY(info.To.y, info.Duration);
					break;
				case Type.MoveX:
					tween = transform.DOMoveX(info.To.x, info.Duration);
					break;
				case Type.DelayCallback:
					tween = DOVirtual.DelayedCall(info.Duration, () => info.Callback?.Invoke());
					break;
				case Type.LocalMoveY:
					tween = transform.DOLocalMoveY(info.To.y, info.Duration);
					break;
				case Type.LocalMoveX:
					tween = transform.DOLocalMoveX(info.To.x, info.Duration);
					break;
				case Type.Scale:
					tween = transform.DOScale(info.To, info.Duration);
					break;
				case Type.ScaleY:
					tween = transform.DOScaleY(info.To.y, info.Duration);
					break;
				case Type.ScaleX:
					tween = transform.DOScaleX(info.To.x, info.Duration);
					break;
				case Type.Rotation:
					tween = transform.DORotate(info.To, info.Duration);
					break;
				case Type.LocalRotation:
					tween = transform.DOLocalRotate(info.To, info.Duration);
					break;
			}
			if (tween != null)
			{
				if (info.customGraph && info.customCurve != null)
					tween.SetEase(info.customCurve);
				else
					tween.SetEase(info.EaseType);
				if (info.Delay > 0f)
					tween.SetDelay(info.Delay);
				if (info.Callback != null && info.TweenType != Type.DelayCallback)
					tween.OnComplete(() => info.Callback?.Invoke());
				s.Append(tween);
			}
		}
		switch (LoopType)
		{
			case Loop.Restart:
				s.SetLoops(-1, DG.Tweening.LoopType.Restart);
				break;
			case Loop.Yoyo:
				s.SetLoops(-1, DG.Tweening.LoopType.Yoyo);
				break;
		}
		return s;
	}

	public void SetId(string id)
	{
		if (seq != null)
			seq.SetId(id);
	}

	public void OnEnable()
	{
		if (OnEnablePlay)
			Play();
	}

	private void OnDisable()
	{
		if (seq != null && seq.IsActive())
			seq.Kill();
		seq = null;
	}

	public void Reset()
	{
		if (seq != null && seq.IsActive())
			seq.Kill();
		seq = null;
		ResetOriginTransform();
	}

	public void AddCallback(Action action)
	{
		if (seq != null)
			seq.OnComplete(() => action?.Invoke());
	}

	public Vector3 LastValue()
	{
		if (Tweens != null && Tweens.Count > 0)
			return Tweens[Tweens.Count - 1].To;
		return default(Vector3);
	}

	public void Play()
	{
		if (EnableResetTransform)
			ResetOriginTransform();
		if (seq != null && seq.IsActive())
			seq.Kill();
		seq = CreateSeq();
		seq.SetAutoKill(true);
		seq.Play();
	}

	public void PlayWithCallback(Action cb)
	{
		if (EnableResetTransform)
			ResetOriginTransform();
		if (seq != null && seq.IsActive())
			seq.Kill();
		seq = CreateSeq();
		seq.SetAutoKill(true);
		seq.OnComplete(() => cb?.Invoke());
		seq.Play();
	}

	public void Play(object id)
	{
		Play();
		if (seq != null)
			seq.SetId(id);
	}

	public void SetPlaySpeed(float playSpeed)
	{
		if (seq != null)
			seq.timeScale = playSpeed;
	}

	public float GetTweensMaxDuration()
	{
		if (Tweens == null || Tweens.Count == 0) return 0f;
		float max = 0f;
		for (int i = 0; i < Tweens.Count; i++)
		{
			if (Tweens[i] != null)
			{
				float total = Tweens[i].Duration + Tweens[i].Delay;
				if (total > max) max = total;
			}
		}
		return max;
	}

	public bool isPlaying()
	{
		return seq != null && seq.IsActive() && seq.IsPlaying();
	}

	public void Pause()
	{
		if (seq != null && seq.IsActive())
			seq.Pause();
	}

	public void ReverseInit()
	{
		if (Tweens == null || Tweens.Count == 0) return;
		var lastInfo = Tweens[Tweens.Count - 1];
		if (lastInfo == null) return;
		switch (lastInfo.TweenType)
		{
			case Type.LocalPosition:
				transform.localPosition = lastInfo.To;
				break;
			case Type.Position:
				transform.position = lastInfo.To;
				break;
			case Type.Scale:
				transform.localScale = lastInfo.To;
				break;
			case Type.Alpha:
				var cg = GetComponent<CanvasGroup>();
				if (cg != null)
					cg.alpha = lastInfo.Value;
				break;
		}
	}

	public void ResetOriginTransform()
	{
		transform.localPosition = originPosition;
		transform.localScale = originScale;
		transform.localRotation = originRotation;
		var cg = GetComponent<CanvasGroup>();
		if (cg != null)
			cg.alpha = originColor.a;
	}

	private void OnDestroy()
	{
		if (seq != null && seq.IsActive())
			seq.Kill();
		seq = null;
	}

	public Sequence GetSequence()
	{
		return seq;
	}

	public void InitSequence()
	{
		if (seq != null && seq.IsActive())
			seq.Kill();
		seq = CreateSeq();
		seq.SetAutoKill(false);
		seq.Pause();
	}
}
