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
		BuffEffectMap = new Dictionary<SkillEffectType, GameObject>();
		BuffEffectParticleSystems = new List<ParticleSystem>();
		BuffEffectDoTweenScriptComponents = new List<DoTweenScriptComponent>();
		BuffEffectAutoDeactiveComponents = new List<AutoDeactiveComponent>();

		if (SlotButton != null) SlotButton.onClick.AddListener(OnClickedSlotButton);
	}

	private void OnDisable()
	{
		ResetBuffEffect();
	}

	public void SetData(BizAcqCharacterData characterData)
	{
		if (characterData == null)
		{
			SetEmpty();
			return;
		}
		int skillIdx = characterData.SkillData != null ? characterData.SkillData.SkillIdx : 0;
		int skillLv = characterData.SkillData != null ? characterData.SkillData.SkillLevel : 0;
		SetData(characterData.CeoIdx, characterData.DealPower, skillIdx, skillLv, characterData.TeamIdx);
	}

	public void SetData(int ceoIdx, int dealPower, int skillIdx, int skillLv, int slotIdx)
	{
		CeoIdx = ceoIdx;
		DealPower = dealPower;
		SkillLv = skillLv;
		SlotIdx = slotIdx;

		if (CeoObject != null) CeoObject.SetActive(true);
		if (NullObject != null) NullObject.SetActive(false);
		if (DeadObject != null) DeadObject.SetActive(false);
		if (CheckObject != null) CheckObject.SetActive(false);

		SetDealPowerText(dealPower, Color.white);
		SetSkillIcon(skillIdx);
	}

	public void SetPlaySpeed(float playSpeed)
	{
		PlaySpeed = playSpeed;
		SetBuffEffectPlaySpeed(playSpeed);
	}

	public void PlayBuffEffect(int dealPower_total, int dealPower_origin, SkillEffectType skillEffectType)
	{
		Color textColor = dealPower_total >= dealPower_origin ? Color.green : Color.red;
		SetDealPowerText(dealPower_total, textColor);
		DealPower = dealPower_total;

		LoadBuffEffect(skillEffectType);
	}

	public void SetIsCheck(bool isCheck)
	{
		if (CheckObject != null) CheckObject.SetActive(isCheck);
	}

	public void SetIsDead(bool isDead)
	{
		if (DeadObject != null) DeadObject.SetActive(isDead);
		if (CeoObject != null && isDead) CeoObject.SetActive(false);
	}

	public void SetEmpty()
	{
		CeoIdx = 0;
		DealPower = 0;
		SkillLv = 0;
		if (CeoObject != null) CeoObject.SetActive(false);
		if (NullObject != null) NullObject.SetActive(true);
		if (DeadObject != null) DeadObject.SetActive(false);
		if (CheckObject != null) CheckObject.SetActive(false);
	}

	private void SetDealPowerText(int dealPower, Color textColor)
	{
		if (DealPowerText != null)
		{
			DealPowerText.text = dealPower.ToString();
			DealPowerText.color = textColor;
		}
	}

	private void SetSkillIcon(int skillIdx)
	{
		if (SkillIconImage == null) return;
		// Load skill icon by skillIdx
	}

	private void OnClickedSlotButton()
	{
		OnClickedSlotButtonEvent?.Invoke(CeoIdx, SlotIdx);
	}

	private void LoadBuffEffect(SkillEffectType skillEffectType)
	{
		if (skillEffectType == SkillEffectType.None) return;
		if (BuffEffectMap.ContainsKey(skillEffectType))
		{
			var fx = BuffEffectMap[skillEffectType];
			if (fx != null) { fx.SetActive(false); fx.SetActive(true); }
			return;
		}
		// Load and instantiate buff effect prefab
	}

	private void SetBuffEffectPlaySpeed(float playSpeed)
	{
		for (int i = 0; i < BuffEffectParticleSystems.Count; i++)
		{
			if (BuffEffectParticleSystems[i] != null)
			{
				var main = BuffEffectParticleSystems[i].main;
				main.simulationSpeed = playSpeed;
			}
		}
	}

	private void CollectBuffEffectComponents(GameObject obj)
	{
		if (obj == null) return;
		var particles = obj.GetComponentsInChildren<ParticleSystem>(true);
		BuffEffectParticleSystems.AddRange(particles);
		var doTweens = obj.GetComponentsInChildren<DoTweenScriptComponent>(true);
		BuffEffectDoTweenScriptComponents.AddRange(doTweens);
		var autoDeactives = obj.GetComponentsInChildren<AutoDeactiveComponent>(true);
		BuffEffectAutoDeactiveComponents.AddRange(autoDeactives);
	}

	private void ResetBuffEffect()
	{
		foreach (var kvp in BuffEffectMap)
		{
			if (kvp.Value != null) kvp.Value.SetActive(false);
		}
	}
}
