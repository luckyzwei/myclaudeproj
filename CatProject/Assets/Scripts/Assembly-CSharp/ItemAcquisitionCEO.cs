using System;
using System.Collections.Generic;
using BizAcqDef;
using UnityEngine;
using UnityEngine.UI;

public class ItemAcquisitionCEO : MonoBehaviour
{
	[SerializeField]
	private Image CeoImage;

	[SerializeField]
	private Image GradeBgImage;

	[SerializeField]
	private Text DealPowerText;

	[SerializeField]
	private Text BuffDealPowerText;

	[SerializeField]
	private Image SkillIconImage;

	[SerializeField]
	private GameObject CeoObject;

	[SerializeField]
	private GameObject NullObject;

	[SerializeField]
	private GameObject CheckObject;

	[SerializeField]
	private GameObject DeadObject;

	[SerializeField]
	private Button SlotButton;

	[SerializeField]
	private GameObject BuffEffectRootObj;

	private float PlaySpeed;

	public Action<int, int> OnClickedSlotButtonEvent;

	private Dictionary<SkillEffectType, GameObject> BuffEffectMap;

	private List<ParticleSystem> BuffEffectParticleSystems;

	private List<DoTweenScriptComponent> BuffEffectDoTweenScriptComponents;

	private List<AutoDeactiveComponent> BuffEffectAutoDeactiveComponents;

	public int CeoIdx { get; private set; }

	public int DealPower { get; private set; }

	public int SkillLv { get; private set; }

	public int SlotIdx { get; private set; }

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public void SetData(BizAcqCharacterData characterData)
	{
	}

	public void SetData(int ceoIdx, int dealPower, int skillIdx, int skillLv, int slotIdx)
	{
	}

	public void SetPlaySpeed(float playSpeed)
	{
	}

	public void PlayBuffEffect(int dealPower_total, int dealPower_origin, SkillEffectType skillEffectType)
	{
	}

	public void SetIsCheck(bool isCheck)
	{
	}

	public void SetIsDead(bool isDead)
	{
	}

	public void SetEmpty()
	{
	}

	private void SetDealPowerText(int dealPower, Color textColor)
	{
	}

	private void SetSkillIcon(int skillIdx)
	{
	}

	private void OnClickedSlotButton()
	{
	}

	private void LoadBuffEffect(SkillEffectType skillEffectType)
	{
	}

	private void SetBuffEffectPlaySpeed(float playSpeed)
	{
	}

	private void CollectBuffEffectComponents(GameObject obj)
	{
	}

	private void ResetBuffEffect()
	{
	}
}
