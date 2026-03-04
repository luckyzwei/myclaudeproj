using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SpriteAnimation : MonoBehaviour
{
	[Serializable]
	public class AnimationInfo
	{
		public string aniName;

		public string nextAniName;

		public bool loop;

		public Config.AtlasType atlasType;

		public List<AniSpriteInfo> list;

		public float TotalPlayTime { get; private set; }

		public void Init()
		{
		}
	}

	[Serializable]
	public class AniSpriteInfo
	{
		public float frameTime;

		public Sprite sprite;

		public float sectionTime { get; private set; }

		public void Init(float _sectionTime, Config.AtlasType type)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitOneFrame_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action callback;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWaitOneFrame_003Ed__30(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public Transform UINotiPosition;

	[SerializeField]
	private SpriteRenderer srenderer;

	[SerializeField]
	private Image uiImg;

	[SerializeField]
	private bool IsRandomPlayer;

	[SerializeField]
	private List<AnimationInfo> infos;

	[SerializeField]
	private string OnAwakePlayAniName;

	private int playListSpriteIdx;

	private float deltaTime;

	private float limitTime;

	private AnimationInfo curInfo;

	private AniSpriteInfo curSpriteInfo;

	private bool isPlay;

	public bool UIMode;

	public bool UINativeSize;

	private Animator managerAni;

	public Action<Sprite> OnChangeSprite;

	public string CurAniName { get { return null; } }

	public void Awake()
	{
	}

	[ExecuteInEditMode]
	public void Init()
	{
	}

	public SpriteRenderer GetSpriteRenderer()
	{
		return null;
	}

	public void ShowAni()
	{
	}

	public string GetFirstAniName()
	{
		return null;
	}

	public void SetUIMode(bool value, Image img = null)
	{
	}

	public void SetForceAniName(string aniName)
	{
	}

	public void SetFever(bool value)
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitOneFrame_003Ed__30))]
	private IEnumerator WaitOneFrame(Action callback)
	{
		yield break;
	}

	public float GetAniPlayTime(string aniName)
	{
		return 0f;
	}

	public void StopFirstSprite(string aniName)
	{
	}

	[ExecuteInEditMode]
	public void SetSprite(string aniName, Sprite[] sprites)
	{
	}

	[ExecuteInEditMode]
	public void Play(string aniName)
	{
	}

	[ExecuteInEditMode]
	public void PlayFrame(float timeDelta, Action OnLoopComplete = null)
	{
	}
}
