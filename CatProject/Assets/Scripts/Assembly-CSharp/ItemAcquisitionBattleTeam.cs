using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BizAcqDef;
using Coffee.UIExtensions;
using DG.Tweening;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class ItemAcquisitionBattleTeam : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass87_0
	{
		public ItemAcquisitionBattleTeam _003C_003E4__this;

		public string sequenceId;

		public Action endCallback;

		internal bool _003CChangeCeoAnimation_003Eb__0()
		{
			return false;
		}

		internal void _003CChangeCeoAnimation_003Eb__2(float x)
		{
		}

		internal void _003CChangeCeoAnimation_003Eb__3()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CChangeCeoAnimation_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemAcquisitionBattleTeam _003C_003E4__this;

		public Action endCallback;

		private _003C_003Ec__DisplayClass87_0 _003C_003E8__1;

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
		public _003CChangeCeoAnimation_003Ed__87(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CEvadeAnimationCoroutine_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemAcquisitionBattleTeam _003C_003E4__this;

		public Action endCallback;

		private bool _003ChasTriggeredPreEndCallback_003E5__2;

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
		public _003CEvadeAnimationCoroutine_003Ed__84(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CSkillAnimationCoroutine_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemAcquisitionBattleTeam _003C_003E4__this;

		public Action endCallback;

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
		public _003CSkillAnimationCoroutine_003Ed__80(int _003C_003E1__state)
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
	private List<DoTweenScriptComponent> DoTweenScriptComponents;

	[SerializeField]
	private List<Animator> BattleAnimators;

	[SerializeField]
	private List<UIParticle> UIParticles;

	[SerializeField]
	private List<AutoDeactiveComponent> AutoDeactiveComponents;

	[SerializeField]
	private List<GameObject> StageBgList;

	[SerializeField]
	private GameObject BattleCeoRoot;

	[SerializeField]
	private GameObject BattleCeoHudRoot;

	[SerializeField]
	private Text CeoNameText;

	[SerializeField]
	private SliderTextComponent TeamTotalHpGauge;

	[SerializeField]
	private SliderTextComponent BattleCeoHpGauge;

	[SerializeField]
	private GameObject BattleCeoHpDecoObj;

	[SerializeField]
	private AcquisitionAttackBubble AttackBubble;

	[SerializeField]
	private Text AttackBubbleText;

	[SerializeField]
	private GameObject AttackDecoObj;

	[SerializeField]
	private GameObject DamageObj;

	[SerializeField]
	private Text DamageText;

	[SerializeField]
	private GameObject HealFxObj;

	[SerializeField]
	private GameObject HealObj;

	[SerializeField]
	private Text HealText;

	[SerializeField]
	private GameObject MissObj;

	[SerializeField]
	private AutoPlayBubble NotHappenObj;

	[SerializeField]
	private List<ItemAcquisitionCEO> TeamCeoList;

	[SerializeField]
	private List<AutoPlayBubble> TeamCeoSkillToolTipList;

	[SerializeField]
	private List<GameObject> SkillActiveObjList;

	[SerializeField]
	private Animator SkillBgAnimator;

	[SerializeField]
	private Text SkillDescText;

	[SerializeField]
	private Image SkillIconImage;

	[SerializeField]
	private Button ScreenLockObj;

	[Header("데미지 연출 파라미터 - 개별 설정필요한 경우 아니면 원본 프리팹 수정을 부탁드립니다.")]
	[Space(5f)]
	[Header("데미지 받았을때 적용되는 머터리얼")]
	[SerializeField]
	private Material DamageMaterial;

	[Header("데미지 받았을때 변경되는 컬러")]
	[SerializeField]
	private Color DamageColor;

	[Header("플레이 시작 딜레이 시간 - Obj_Text")]
	[SerializeField]
	private float AttackDecoObj_StartDelayTimeSec;

	[Header("플레이 시작 딜레이 시간 - Color Change")]
	[SerializeField]
	private float ColorChange_StartDelayTimeSec;

	[Header("플레이 시작 딜레이 시간 - Text_Damage")]
	[SerializeField]
	private float TextDamage_StartDelayTimeSec;

	[Header("플레이 시작 딜레이 시간 - Character Animation")]
	[SerializeField]
	private float CharacterAnimation_StartDelayTimeSec;

	[Header("플레이 시작 딜레이 시간 - Damage Shake")]
	[SerializeField]
	private float DamageShake_StartDelayTimeSec;

	[Header("플레이 시간 - 지정된 컬러로 변경")]
	[SerializeField]
	private float ColorChange_PlayTimeSec;

	[Header("플레이 시간 - 원래 컬러로 변경")]
	[SerializeField]
	private float ColorReturn_PlayTimeSec;

	[Header("데미지 받았을때 캐릭터가 한번 흔들리는데 걸리는 시간")]
	[SerializeField]
	private float DamageShakeDuration;

	[Header("데미지 받았을때 캐릭터가 한번 흔들리는데 이동하는 거리")]
	[SerializeField]
	private float DamageShakeDistance;

	[Header("스킬 사용시 커지는 크기")]
	[SerializeField]
	private float SkillScale;

	[Header("스킬 사용시 커지기 전 잠시 대기하는 시간")]
	[SerializeField]
	private float SkillScaleStartWaitTime;

	[Header("스킬 사용시 커지는 시간")]
	[SerializeField]
	private float SkillScaleTime;

	[Header("스킬 사용시 커지고 잠시 대기하는 시간")]
	[SerializeField]
	private float SkillScaleWaitTime;

	[Header("스킬 사용시 작아지는 시간")]
	[SerializeField]
	private float SkillScaleReturnTime;

	private int CurrentCeoIdx;

	private int CurrentTeamIdx;

	private GameObject BattleCeoObj;

	private Animator BattleCeoAnimator;

	private Vector3 Ceo_OriginalPosition;

	private float PlaySpeed;

	private string CEO_PREFAB_NAME;

	private const float ANIMATION_DURATION = 0.3f;

	private const float FADE_DURATION = 0.5f;

	private const int ATTACK_BUBBLE_TOTAL_TEXT_COUNT = 70;

	private const int ATTACK_BUBBLE_TOTAL_KILL_TEXT_COUNT = 20;

	private const string ATTACK_BUBBLE_PLAYER_TEXT = "str_acquisition_user_bubble_";

	private const string ATTACK_BUBBLE_PLAYER_KILL_TEXT = "str_acquisition_user_final_bubble_";

	private const string ATTACK_BUBBLE_ENEMY_TEXT = "str_acquisition_rival_bubble_";

	private const string ATTACK_BUBBLE_ENEMY_KILL_TEXT = "str_acquisition_rival_final_bubble_";

	private int AttackBubbleTextIdx;

	private const string ATTACK_ANIM_NAME = "Attack";

	private const string DAMAGE_ANIM_NAME = "Hit";

	private const string SKILL_ANIM_NAME = "Skill";

	private const string SKILL_BG_ANIM_NAME = "Hide";

	private const string EVADE_SKILL_NAME = "Avoid";

	private Dictionary<string, Sequence> AnimationSequences;

	private List<Image> CeoImages;

	private CompositeDisposable Disposables;

	public TeamType TeamType { get; private set; }

	private void Awake()
	{
		AnimationSequences = new Dictionary<string, Sequence>();
		CeoImages = new List<Image>();
		Disposables = new CompositeDisposable();
		AttackBubbleTextIdx = 0;
		PlaySpeed = 1f;
		if (ScreenLockObj != null) ScreenLockObj.onClick.AddListener(OnClickedScreenLock);
	}

	private void OnDisable()
	{
		KillAllSequences();
	}

	private void OnDestroy()
	{
		KillAllSequences();
		if (Disposables != null)
		{
			Disposables.Dispose();
			Disposables = null;
		}
	}

	public void Set(BizAcqTeamData teamData)
	{
		if (teamData == null) return;
		TeamType = teamData.TeamType;
		CurrentTeamIdx = 0;
		ResetUIState();
		ResetData();
		SetTeamCeoList(teamData);
		SetCurrentCeoInfo(teamData);
		SetTeamHpInfo(teamData, true);
		if (teamData.CurrentCharacter != null)
		{
			CurrentCeoIdx = teamData.CurrentCharacter.CeoIdx;
			LoadCeoPrefab(CurrentCeoIdx);
			SetCeoHpGauge(teamData.CurrentCharacter, true);
		}
		SetStageBg(0);
	}

	private Sequence CreateSequence(string id)
	{
		KillSequence(id);
		var seq = DOTween.Sequence();
		AnimationSequences[id] = seq;
		return seq;
	}

	private void KillSequence(string id)
	{
		if (AnimationSequences != null && AnimationSequences.TryGetValue(id, out var seq))
		{
			seq?.Kill();
			AnimationSequences.Remove(id);
		}
	}

	private void KillAllSequences()
	{
		if (AnimationSequences == null) return;
		foreach (var kvp in AnimationSequences)
			kvp.Value?.Kill();
		AnimationSequences.Clear();
	}

	public void PlaySkillAnimation(int skillIdx, int skillLevel, Action endCallback)
	{
		SetSkillInfo(skillIdx, skillLevel);
		StartCoroutine(SkillAnimationCoroutine(endCallback));
	}

	[IteratorStateMachine(typeof(_003CSkillAnimationCoroutine_003Ed__80))]
	private IEnumerator SkillAnimationCoroutine(Action endCallback)
	{
		// Show skill UI
		if (SkillBgAnimator != null) SkillBgAnimator.SetTrigger(SKILL_ANIM_NAME);
		for (int i = 0; i < SkillActiveObjList?.Count; i++)
			if (SkillActiveObjList[i] != null) SkillActiveObjList[i].SetActive(true);

		// Scale up CEO
		if (BattleCeoObj != null)
		{
			yield return new WaitForSeconds(SkillScaleStartWaitTime / PlaySpeed);
			BattleCeoObj.transform.DOScale(SkillScale, SkillScaleTime / PlaySpeed);
			yield return new WaitForSeconds(SkillScaleTime / PlaySpeed);
			yield return new WaitForSeconds(SkillScaleWaitTime / PlaySpeed);
			BattleCeoObj.transform.DOScale(1f, SkillScaleReturnTime / PlaySpeed);
			yield return new WaitForSeconds(SkillScaleReturnTime / PlaySpeed);
		}

		// Hide skill UI
		if (SkillBgAnimator != null) SkillBgAnimator.SetTrigger(SKILL_BG_ANIM_NAME);
		for (int i = 0; i < SkillActiveObjList?.Count; i++)
			if (SkillActiveObjList[i] != null) SkillActiveObjList[i].SetActive(false);

		endCallback?.Invoke();
	}

	public void PlayAttackAnimation(bool isKill, Action endCallback)
	{
		SetAttackBubbleText(isKill);
		if (AttackBubble != null) AttackBubble.PlayShow();

		if (BattleCeoAnimator != null) BattleCeoAnimator.SetTrigger(ATTACK_ANIM_NAME);
		if (AttackDecoObj != null)
		{
			AttackDecoObj.SetActive(false);
			AttackDecoObj.SetActive(true);
		}

		var seq = CreateSequence("Attack");
		seq.AppendInterval(ANIMATION_DURATION / PlaySpeed);
		seq.AppendCallback(() =>
		{
			if (AttackBubble != null) AttackBubble.PlayHide();
			endCallback?.Invoke();
		});
	}

	public void PlayDamageAnimation(int damageValue, Action endCallback)
	{
		// Show damage text
		if (DamageObj != null)
		{
			DamageObj.SetActive(false);
			DamageObj.SetActive(true);
		}
		if (DamageText != null) DamageText.text = damageValue.ToString();

		// Play hit animation
		if (BattleCeoAnimator != null) BattleCeoAnimator.SetTrigger(DAMAGE_ANIM_NAME);

		// Color change + shake
		var seq = CreateSequence("Damage");
		seq.AppendInterval(ColorChange_StartDelayTimeSec / PlaySpeed);
		seq.AppendCallback(() => SetCeoColors(DamageColor));
		seq.AppendInterval(ColorChange_PlayTimeSec / PlaySpeed);
		seq.AppendCallback(() => ResetCeoColors());
		seq.AppendInterval(ColorReturn_PlayTimeSec / PlaySpeed);

		// Shake
		if (BattleCeoObj != null)
		{
			seq.Insert(DamageShake_StartDelayTimeSec / PlaySpeed,
				BattleCeoObj.transform.DOShakePosition(DamageShakeDuration / PlaySpeed, DamageShakeDistance));
		}

		seq.AppendCallback(() =>
		{
			UpdateHpInfo();
			endCallback?.Invoke();
		});
	}

	public void PlayEvadeAnimation(Action endCallback)
	{
		StartCoroutine(EvadeAnimationCoroutine(endCallback));
	}

	[IteratorStateMachine(typeof(_003CEvadeAnimationCoroutine_003Ed__84))]
	private IEnumerator EvadeAnimationCoroutine(Action endCallback)
	{
		if (BattleCeoAnimator != null) BattleCeoAnimator.SetTrigger(EVADE_SKILL_NAME);
		if (MissObj != null)
		{
			MissObj.SetActive(false);
			MissObj.SetActive(true);
		}
		yield return new WaitForSeconds(ANIMATION_DURATION / PlaySpeed);
		endCallback?.Invoke();
	}

	public void PlayDeadAnimation(Action endCallback)
	{
		var seq = CreateSequence("Dead");
		seq.AppendCallback(() => SetCeoAlpha(1f));
		seq.Append(DOTween.To(() => 1f, x => SetCeoAlpha(x), 0f, FADE_DURATION / PlaySpeed));
		seq.AppendCallback(() =>
		{
			if (BattleCeoObj != null) BattleCeoObj.SetActive(false);
			endCallback?.Invoke();
		});
	}

	public void PlayChangeCeoAnimation(Action endCallback)
	{
		StartCoroutine(ChangeCeoAnimation(endCallback));
	}

	[IteratorStateMachine(typeof(_003CChangeCeoAnimation_003Ed__87))]
	private IEnumerator ChangeCeoAnimation(Action endCallback)
	{
		string sequenceId = "ChangeCeo";
		// Fade out current CEO
		var fadeOutSeq = CreateSequence(sequenceId);
		fadeOutSeq.Append(DOTween.To(() => 1f, x => SetCeoAlpha(x), 0f, FADE_DURATION / PlaySpeed));
		yield return new WaitForSeconds(FADE_DURATION / PlaySpeed);

		// Load new CEO
		var teamData = new BizAcqTeamData(TeamType);
		// The actual new CEO is set via external call before this
		if (BattleCeoObj != null) BattleCeoObj.SetActive(false);

		UpdateCeoInfo();

		// Fade in new CEO
		if (BattleCeoObj != null) BattleCeoObj.SetActive(true);
		SetCeoAlpha(0f);
		var fadeInSeq = CreateSequence(sequenceId);
		fadeInSeq.Append(DOTween.To(() => 0f, x => SetCeoAlpha(x), 1f, FADE_DURATION / PlaySpeed));
		yield return new WaitForSeconds(FADE_DURATION / PlaySpeed);

		endCallback?.Invoke();
	}

	public void PlayBuffEffect(BattleCommand command, List<BizAcqCharacterData> targetList)
	{
		if (command == null || targetList == null) return;
		if (HealFxObj != null && command.EffectValue > 0)
		{
			HealFxObj.SetActive(false);
			HealFxObj.SetActive(true);
		}
		if (HealObj != null && command.EffectValue > 0)
		{
			HealObj.SetActive(false);
			HealObj.SetActive(true);
			if (HealText != null) HealText.text = "+" + command.EffectValue;
		}
		UpdateHpInfo();
	}

	public void PlayNotHappenAnimation(SkillEffectType skillEffectType, Action endCallback)
	{
		if (NotHappenObj != null)
		{
			NotHappenObj.SetBubbleText(skillEffectType.ToString());
			NotHappenObj.PlayShowImmediately();
		}
		var seq = CreateSequence("NotHappen");
		seq.AppendInterval(ANIMATION_DURATION / PlaySpeed);
		seq.AppendCallback(() =>
		{
			if (NotHappenObj != null) NotHappenObj.PlayHide();
			endCallback?.Invoke();
		});
	}

	public Vector3 GetAttackTargetPos()
	{
		if (BattleCeoObj != null) return BattleCeoObj.transform.position;
		return default(Vector3);
	}

	public void SetPlaySpeed(float speed)
	{
		PlaySpeed = Mathf.Max(0.1f, speed);
		if (TeamCeoList != null)
		{
			for (int i = 0; i < TeamCeoList.Count; i++)
				if (TeamCeoList[i] != null) TeamCeoList[i].SetPlaySpeed(PlaySpeed);
		}
		if (AttackBubble != null) AttackBubble.SetPlaySpeed(PlaySpeed);
	}

	private void ResetUIState()
	{
		if (DamageObj != null) DamageObj.SetActive(false);
		if (HealObj != null) HealObj.SetActive(false);
		if (HealFxObj != null) HealFxObj.SetActive(false);
		if (MissObj != null) MissObj.SetActive(false);
		if (AttackDecoObj != null) AttackDecoObj.SetActive(false);
		if (BattleCeoHudRoot != null) BattleCeoHudRoot.SetActive(true);
		for (int i = 0; i < SkillActiveObjList?.Count; i++)
			if (SkillActiveObjList[i] != null) SkillActiveObjList[i].SetActive(false);
	}

	private void ResetData()
	{
		CurrentCeoIdx = 0;
		CurrentTeamIdx = 0;
		AttackBubbleTextIdx = 0;
		KillAllSequences();
		CeoImages.Clear();
	}

	private void LoadCeoPrefab(int ceoIdx)
	{
		// Load CEO character prefab into BattleCeoRoot
		if (BattleCeoRoot == null) return;
		// Destroy existing
		if (BattleCeoObj != null) UnityEngine.Object.Destroy(BattleCeoObj);
		// TODO: Load from Addressables using ceoIdx resource path
		// BattleCeoObj = Instantiate(prefab, BattleCeoRoot.transform);
		// BattleCeoAnimator = BattleCeoObj.GetComponent<Animator>();
		// Ceo_OriginalPosition = BattleCeoObj.transform.localPosition;
		// CeoImages = new List<Image>(BattleCeoObj.GetComponentsInChildren<Image>());
	}

	private void SetCeoColors(Color color)
	{
		if (CeoImages == null) return;
		for (int i = 0; i < CeoImages.Count; i++)
		{
			if (CeoImages[i] != null && CeoImages[i].material != null)
				CeoImages[i].material = DamageMaterial;
		}
	}

	private void ResetCeoColors()
	{
		if (CeoImages == null) return;
		for (int i = 0; i < CeoImages.Count; i++)
		{
			if (CeoImages[i] != null)
				CeoImages[i].material = null;
		}
	}

	private void SetCeoAlpha(float alpha)
	{
		if (CeoImages == null) return;
		for (int i = 0; i < CeoImages.Count; i++)
		{
			if (CeoImages[i] != null)
			{
				var c = CeoImages[i].color;
				c.a = alpha;
				CeoImages[i].color = c;
			}
		}
	}

	private void SetTeamCeoList(BizAcqTeamData teamData)
	{
		if (TeamCeoList == null || teamData == null) return;
		var characters = teamData.Characters;
		for (int i = 0; i < TeamCeoList.Count; i++)
		{
			if (TeamCeoList[i] == null) continue;
			if (characters != null && i < characters.Count && characters[i] != null)
			{
				TeamCeoList[i].gameObject.SetActive(true);
				TeamCeoList[i].SetData(characters[i]);
				int ceoIdx = characters[i].CeoIdx;
				int slotIdx = i;
				// Click binding is done elsewhere
			}
			else
			{
				TeamCeoList[i].SetEmpty();
			}
		}
	}

	private void OnClickedTeamCeo(int ceoIdx, int slotIdx)
	{
		// Show tooltip for team CEO skill
		if (TeamCeoSkillToolTipList != null && slotIdx >= 0 && slotIdx < TeamCeoSkillToolTipList.Count)
		{
			if (TeamCeoSkillToolTipList[slotIdx] != null)
				TeamCeoSkillToolTipList[slotIdx].PlayShowImmediately();
		}
	}

	private void OnClickedScreenLock()
	{
		// Hide any open tooltips
		if (TeamCeoSkillToolTipList != null)
		{
			for (int i = 0; i < TeamCeoSkillToolTipList.Count; i++)
				if (TeamCeoSkillToolTipList[i] != null)
					TeamCeoSkillToolTipList[i].PlayHide();
		}
	}

	private void SetCurrentCeoInfo(BizAcqTeamData teamData)
	{
		if (teamData == null) return;
		var current = teamData.CurrentCharacter;
		if (current == null) return;
		if (CeoNameText != null) CeoNameText.text = current.CeoIdx.ToString();
		SetCeoHpGauge(current, true);
	}

	private void SetCeoHpGauge(BizAcqCharacterData ceoData, bool isForceSet)
	{
		if (BattleCeoHpGauge == null || ceoData == null) return;
		BattleCeoHpGauge.SetValue(ceoData.CurrentHp, ceoData.MaxHp_Origin, isForceSet);
		if (BattleCeoHpDecoObj != null)
			BattleCeoHpDecoObj.SetActive(ceoData.CurrentHp > 0);
	}

	private void SetTeamHpInfo(BizAcqTeamData teamData, bool isForceSet)
	{
		if (TeamTotalHpGauge == null || teamData == null) return;
		var hpInfo = teamData.GetTeamHpInfo();
		TeamTotalHpGauge.SetValue(hpInfo.Item1, hpInfo.Item2, isForceSet);
	}

	private void UpdateHpInfo()
	{
		// Refresh HP gauges with current data
		// This relies on external team data reference, called during animation callbacks
	}

	private void UpdateCeoInfo()
	{
	}

	private void SetSkillInfo(int skillIdx, int skillLevel)
	{
		if (SkillDescText != null) SkillDescText.text = "";
		if (SkillIconImage != null)
		{
			// Set skill icon from skill index
		}
	}

	private void SetAttackBubbleText(bool isKill)
	{
		if (AttackBubbleText == null) return;
		string prefix;
		int maxCount;
		if (TeamType == BizAcqDef.TeamType.Player)
		{
			prefix = isKill ? ATTACK_BUBBLE_PLAYER_KILL_TEXT : ATTACK_BUBBLE_PLAYER_TEXT;
			maxCount = isKill ? ATTACK_BUBBLE_TOTAL_KILL_TEXT_COUNT : ATTACK_BUBBLE_TOTAL_TEXT_COUNT;
		}
		else
		{
			prefix = isKill ? ATTACK_BUBBLE_ENEMY_KILL_TEXT : ATTACK_BUBBLE_ENEMY_TEXT;
			maxCount = isKill ? ATTACK_BUBBLE_TOTAL_KILL_TEXT_COUNT : ATTACK_BUBBLE_TOTAL_TEXT_COUNT;
		}
		int idx = UnityEngine.Random.Range(0, maxCount);
		AttackBubbleText.text = prefix + idx;
	}

	private void SetStageBg(int stageIdx)
	{
		if (StageBgList == null) return;
		int bgIdx = GetBackgroundIndex(stageIdx);
		for (int i = 0; i < StageBgList.Count; i++)
		{
			if (StageBgList[i] != null)
				StageBgList[i].SetActive(i == bgIdx);
		}
	}

	private int GetBackgroundIndex(int stageIdx)
	{
		if (StageBgList == null || StageBgList.Count == 0) return 0;
		return stageIdx % StageBgList.Count;
	}
}
