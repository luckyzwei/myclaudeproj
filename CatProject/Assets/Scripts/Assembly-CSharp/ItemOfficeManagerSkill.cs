using UnityEngine;
using UnityEngine.UI;

public class ItemOfficeManagerSkill : MonoBehaviour
{
	[SerializeField]
	private ItemCeoOfficeSKill MainSkill;

	[SerializeField]
	private Button ArrowBtn;

	[SerializeField]
	private Animator ScrollAnim;

	[SerializeField]
	private Transform SkillRoot;

	[SerializeField]
	private GameObject AllEffectSkillItem;

	[SerializeField]
	private Button InfoCloseBtn;

	private bool isFold;

	private void Awake()
	{
		if (ArrowBtn != null) ArrowBtn.onClick.AddListener(OnClickArrow);
		if (InfoCloseBtn != null) InfoCloseBtn.onClick.AddListener(OnClickCloseInfo);
	}

	public void Set(int officeIdx)
	{
		if (MainSkill != null) MainSkill.gameObject.SetActive(true);
		isFold = true;
		if (ScrollAnim != null) ScrollAnim.SetBool("Fold", isFold);
	}

	private void OpenInfoCloseDim()
	{
		if (InfoCloseBtn != null) InfoCloseBtn.gameObject.SetActive(true);
	}

	private void OnClickArrow()
	{
		isFold = !isFold;
		if (ScrollAnim != null) ScrollAnim.SetBool("Fold", isFold);
	}

	private void OnClickCloseInfo()
	{
		isFold = true;
		if (ScrollAnim != null) ScrollAnim.SetBool("Fold", true);
	}
}
