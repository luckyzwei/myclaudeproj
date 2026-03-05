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
			if (list == null) return;
			float sectionTime = 0f;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i] != null)
				{
					list[i].Init(sectionTime, atlasType);
					sectionTime += list[i].frameTime;
				}
			}
			TotalPlayTime = sectionTime;
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
			sectionTime = _sectionTime;
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

	public string CurAniName { get { return curInfo != null ? curInfo.aniName : null; } }

	public void Awake()
	{
		Init();
	}

	[ExecuteInEditMode]
	public void Init()
	{
		if (infos == null) return;
		for (int i = 0; i < infos.Count; i++)
		{
			if (infos[i] != null) infos[i].Init();
		}
		if (!string.IsNullOrEmpty(OnAwakePlayAniName))
			Play(OnAwakePlayAniName);
		else if (IsRandomPlayer && infos.Count > 0)
			Play(infos[UnityEngine.Random.Range(0, infos.Count)].aniName);
	}

	public SpriteRenderer GetSpriteRenderer()
	{
		return srenderer;
	}

	public void ShowAni()
	{
		if (srenderer != null) srenderer.enabled = true;
		if (uiImg != null) uiImg.enabled = true;
	}

	public string GetFirstAniName()
	{
		if (infos != null && infos.Count > 0)
			return infos[0].aniName;
		return null;
	}

	public void SetUIMode(bool value, Image img = null)
	{
		UIMode = value;
		if (img != null) uiImg = img;
	}

	public void SetForceAniName(string aniName)
	{
		Play(aniName);
	}

	public void SetFever(bool value)
	{
		// Toggle fever animation state
	}

	private void OnEnable()
	{
		if (curInfo != null)
			isPlay = true;
	}

	private void Update()
	{
		if (!isPlay || curInfo == null) return;
		PlayFrame(Time.deltaTime);
	}

	[IteratorStateMachine(typeof(_003CWaitOneFrame_003Ed__30))]
	private IEnumerator WaitOneFrame(Action callback)
	{
		yield return null;
		callback?.Invoke();
	}

	public float GetAniPlayTime(string aniName)
	{
		if (infos == null) return 0f;
		for (int i = 0; i < infos.Count; i++)
		{
			if (infos[i] != null && infos[i].aniName == aniName)
				return infos[i].TotalPlayTime;
		}
		return 0f;
	}

	public void StopFirstSprite(string aniName)
	{
		if (infos == null) return;
		for (int i = 0; i < infos.Count; i++)
		{
			if (infos[i] != null && infos[i].aniName == aniName)
			{
				curInfo = infos[i];
				isPlay = false;
				if (curInfo.list != null && curInfo.list.Count > 0)
				{
					var sprite = curInfo.list[0].sprite;
					if (UIMode && uiImg != null) uiImg.sprite = sprite;
					else if (srenderer != null) srenderer.sprite = sprite;
				}
				break;
			}
		}
	}

	[ExecuteInEditMode]
	public void SetSprite(string aniName, Sprite[] sprites)
	{
		if (infos == null || sprites == null) return;
		for (int i = 0; i < infos.Count; i++)
		{
			if (infos[i] != null && infos[i].aniName == aniName && infos[i].list != null)
			{
				for (int j = 0; j < infos[i].list.Count && j < sprites.Length; j++)
					infos[i].list[j].sprite = sprites[j];
				break;
			}
		}
	}

	[ExecuteInEditMode]
	public void Play(string aniName)
	{
		if (infos == null) return;
		for (int i = 0; i < infos.Count; i++)
		{
			if (infos[i] != null && infos[i].aniName == aniName)
			{
				curInfo = infos[i];
				playListSpriteIdx = 0;
				deltaTime = 0f;
				isPlay = true;
				return;
			}
		}
	}

	[ExecuteInEditMode]
	public void PlayFrame(float timeDelta, Action OnLoopComplete = null)
	{
		if (curInfo == null || curInfo.list == null || curInfo.list.Count == 0) return;
		deltaTime += timeDelta;
		if (playListSpriteIdx < curInfo.list.Count)
		{
			curSpriteInfo = curInfo.list[playListSpriteIdx];
			if (curSpriteInfo != null && deltaTime >= curSpriteInfo.sectionTime + curSpriteInfo.frameTime)
			{
				playListSpriteIdx++;
				if (playListSpriteIdx >= curInfo.list.Count)
				{
					if (curInfo.loop)
					{
						playListSpriteIdx = 0;
						deltaTime = 0f;
						OnLoopComplete?.Invoke();
					}
					else
					{
						isPlay = false;
						if (!string.IsNullOrEmpty(curInfo.nextAniName))
							Play(curInfo.nextAniName);
						OnLoopComplete?.Invoke();
						return;
					}
				}
			}
		}
		if (playListSpriteIdx < curInfo.list.Count)
		{
			var spriteInfo = curInfo.list[playListSpriteIdx];
			if (spriteInfo != null && spriteInfo.sprite != null)
			{
				if (UIMode && uiImg != null)
				{
					uiImg.sprite = spriteInfo.sprite;
					if (UINativeSize) uiImg.SetNativeSize();
				}
				else if (srenderer != null)
					srenderer.sprite = spriteInfo.sprite;
				OnChangeSprite?.Invoke(spriteInfo.sprite);
			}
		}
	}
}
