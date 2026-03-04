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
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void Set(BizAcqTeamData teamData)
	{
	}

	private Sequence CreateSequence(string id)
	{
		return null;
	}

	private void KillSequence(string id)
	{
	}

	private void KillAllSequences()
	{
	}

	public void PlaySkillAnimation(int skillIdx, int skillLevel, Action endCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CSkillAnimationCoroutine_003Ed__80))]
	private IEnumerator SkillAnimationCoroutine(Action endCallback)
	{
		yield break;
	}

	public void PlayAttackAnimation(bool isKill, Action endCallback)
	{
	}

	public void PlayDamageAnimation(int damageValue, Action endCallback)
	{
	}

	public void PlayEvadeAnimation(Action endCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CEvadeAnimationCoroutine_003Ed__84))]
	private IEnumerator EvadeAnimationCoroutine(Action endCallback)
	{
		yield break;
	}

	public void PlayDeadAnimation(Action endCallback)
	{
	}

	public void PlayChangeCeoAnimation(Action endCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CChangeCeoAnimation_003Ed__87))]
	private IEnumerator ChangeCeoAnimation(Action endCallback)
	{
		yield break;
	}

	public void PlayBuffEffect(BattleCommand command, List<BizAcqCharacterData> targetList)
	{
	}

	public void PlayNotHappenAnimation(SkillEffectType skillEffectType, Action endCallback)
	{
	}

	public Vector3 GetAttackTargetPos()
	{
		return default(Vector3);
	}

	public void SetPlaySpeed(float speed)
	{
	}

	private void ResetUIState()
	{
	}

	private void ResetData()
	{
	}

	private void LoadCeoPrefab(int ceoIdx)
	{
	}

	private void SetCeoColors(Color color)
	{
	}

	private void ResetCeoColors()
	{
	}

	private void SetCeoAlpha(float alpha)
	{
	}

	private void SetTeamCeoList(BizAcqTeamData teamData)
	{
	}

	private void OnClickedTeamCeo(int ceoIdx, int slotIdx)
	{
	}

	private void OnClickedScreenLock()
	{
	}

	private void SetCurrentCeoInfo(BizAcqTeamData teamData)
	{
	}

	private void SetCeoHpGauge(BizAcqCharacterData ceoData, bool isForceSet)
	{
	}

	private void SetTeamHpInfo(BizAcqTeamData teamData, bool isForceSet)
	{
	}

	private void UpdateHpInfo()
	{
	}

	private void UpdateCeoInfo()
	{
	}

	private void SetSkillInfo(int skillIdx, int skillLevel)
	{
	}

	private void SetAttackBubbleText(bool isKill)
	{
	}

	private void SetStageBg(int stageIdx)
	{
	}

	private int GetBackgroundIndex(int stageIdx)
	{
		return 0;
	}
}
