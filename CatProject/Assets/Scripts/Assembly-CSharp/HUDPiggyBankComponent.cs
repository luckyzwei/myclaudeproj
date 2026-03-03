using UnityEngine;
using UnityEngine.UI;

public class HUDPiggyBankComponent : MonoBehaviour
{
	[Header("PiggyBank")]
	[SerializeField]
	private Button PiggyBtn;

	[SerializeField]
	private Text PiggyCount;

	[SerializeField]
	private Image PiggyIcon;

	[SerializeField]
	private GameObject PiggyReddot;

	[SerializeField]
	private DoTweenScriptComponent PiggyTween;

	[SerializeField]
	private GameObject ParentsObj;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetPiggyBank()
	{
	}

	public void UpdatePiggyValue()
	{
	}

	private void OnClickPiggyBankBtn()
	{
	}
}
