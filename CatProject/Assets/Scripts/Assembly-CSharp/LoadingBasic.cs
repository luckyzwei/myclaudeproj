using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Page/LoadingBasic", false, false)]
public class LoadingBasic : Loading
{
	[Serializable]
	private class SpecialTheme
	{
		public int SpecialDayIdx;

		public List<GameObject> DecoObjs;
	}

	[CompilerGenerated]
	private sealed class _003CWaitStageLoad_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadingBasic _003C_003E4__this;

		public Action action;

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
		public _003CWaitStageLoad_003Ed__31(int _003C_003E1__state)
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

	[SerializeField]
	private List<GameObject> RandObj;

	[SerializeField]
	private GameObject immersiveADRect;

	[SerializeField]
	private Text loadingBarText;

	[SerializeField]
	private Slider loadingBar;

	[SerializeField]
	private GameObject loadingBarRoot;

	[SerializeField]
	private Button TapBtn;

	[SerializeField]
	private GameObject charRoot;

	[SerializeField]
	private GameObject ADRoot;

	[Header("[SpecialDay Theme]")]
	[SerializeField]
	protected Image TileImg;

	[SerializeField]
	protected Image TileBgImg;

	[SerializeField]
	private List<SpecialTheme> SpecialDayDecoList;

	private Sprite originTile;

	private Color originTileBgColor;

	private float loadingStartTime;

	private bool StageLoadComplete;

	private bool AdLoad;

	private int gamestart_loading_time;

	private static bool bWaitAd;

	public bool ADState { get; private set; }

	protected override void OnEnable()
	{
		base.OnEnable();
		StageLoadComplete = false;
		AdLoad = false;
		loadingStartTime = Time.realtimeSinceStartup;
		// 랜덤 배경 오브젝트 선택
		if (RandObj != null && RandObj.Count > 0)
		{
			int randIdx = UnityEngine.Random.Range(0, RandObj.Count);
			for (int i = 0; i < RandObj.Count; i++)
			{
				if (RandObj[i] != null)
					RandObj[i].SetActive(i == randIdx);
			}
		}
		if (loadingBar != null)
		{
			loadingBar.value = 0f;
			if (loadingBarRoot != null)
				loadingBarRoot.SetActive(true);
		}
		if (TapBtn != null)
			TapBtn.gameObject.SetActive(false);
		InitTheme();
		UpdateSpecialTheme();
	}

	protected virtual void OnDisable()
	{
		SetDefaultTheme();
	}

	protected override void Awake()
	{
		base.Awake();
		if (TapBtn != null)
			TapBtn.onClick.AddListener(OnClickTap);
		if (TileImg != null)
			originTile = TileImg.sprite;
		if (TileBgImg != null)
			originTileBgColor = TileBgImg.color;
		// 설정에서 로딩 광고 시간 로드
		gamestart_loading_time = 3;
	}

	private void OnClickTap()
	{
		// 탭하면 로딩 스킵 (스테이지 로드 완료 후에만)
		if (!StageLoadComplete) return;
		Hide(false);
	}

	protected override void Update()
	{
		base.Update();
		// 로딩 바 업데이트
		if (loadingBar != null && !StageLoadComplete)
		{
			float elapsed = Time.realtimeSinceStartup - loadingStartTime;
			float progress = Mathf.Clamp01(elapsed / gamestart_loading_time);
			loadingBar.value = progress;
			if (loadingBarText != null)
				loadingBarText.text = Mathf.RoundToInt(progress * 100f) + "%";
		}
	}

	public override void Hide()
	{
		Hide(true, null);
	}

	public override void Hide(bool Immediately = true, Action action = null)
	{
		if (TapBtn != null)
			TapBtn.gameObject.SetActive(false);
		base.Hide(Immediately, action);
	}

	public void WaitStageLoadHide()
	{
		StageLoadComplete = true;
		StartCoroutine(WaitStageLoad(() =>
		{
			// 탭 버튼 또는 자동 숨기기
			if (TapBtn != null)
				TapBtn.gameObject.SetActive(true);
			else
				Hide(false);
		}));
	}

	[IteratorStateMachine(typeof(_003CWaitStageLoad_003Ed__31))]
	private IEnumerator WaitStageLoad(Action action)
	{
		// 최소 로딩 시간 대기
		float elapsed = Time.realtimeSinceStartup - loadingStartTime;
		if (elapsed < gamestart_loading_time)
		{
			yield return new WaitForSecondsRealtime(gamestart_loading_time - elapsed);
		}
		// 로딩 바 100%로 설정
		if (loadingBar != null)
			loadingBar.value = 1f;
		if (loadingBarText != null)
			loadingBarText.text = "100%";
		yield return null;
		action?.Invoke();
	}

	private bool CheckShowLoadingAds()
	{
		// 로딩 중 광고 표시 여부 확인
		if (immersiveADRect == null) return false;
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return false;
		// 광고 조건 확인 (레벨, 시간 등)
		return false;
	}

	private void InitTheme()
	{
		// 스페셜 데이 테마 초기화
		if (SpecialDayDecoList == null) return;
		for (int i = 0; i < SpecialDayDecoList.Count; i++)
		{
			var theme = SpecialDayDecoList[i];
			if (theme == null || theme.DecoObjs == null) continue;
			for (int j = 0; j < theme.DecoObjs.Count; j++)
			{
				if (theme.DecoObjs[j] != null)
					theme.DecoObjs[j].SetActive(false);
			}
		}
	}

	public void UpdateSpecialTheme()
	{
		// 현재 스페셜 데이에 맞는 테마 적용
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		int specialDayIdx = root.SpecialDaySystem != null ? root.SpecialDaySystem.CurIdx : -1;
		if (specialDayIdx < 0)
		{
			SetDefaultTheme();
			return;
		}
		if (SpecialDayDecoList == null) return;
		for (int i = 0; i < SpecialDayDecoList.Count; i++)
		{
			var theme = SpecialDayDecoList[i];
			if (theme == null) continue;
			bool isActive = theme.SpecialDayIdx == specialDayIdx;
			if (theme.DecoObjs != null)
			{
				for (int j = 0; j < theme.DecoObjs.Count; j++)
				{
					if (theme.DecoObjs[j] != null)
						theme.DecoObjs[j].SetActive(isActive);
				}
			}
		}
	}

	private void SetDefaultTheme()
	{
		// 기본 테마로 복원
		if (TileImg != null && originTile != null)
			TileImg.sprite = originTile;
		if (TileBgImg != null)
			TileBgImg.color = originTileBgColor;
	}
}
