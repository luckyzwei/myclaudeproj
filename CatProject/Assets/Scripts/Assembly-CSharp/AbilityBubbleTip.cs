using UnityEngine;
using UnityEngine.UI;

public class AbilityBubbleTip : MonoBehaviour
{
	[SerializeField]
	private Text Desc;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Button ActiveBtn;

	[SerializeField]
	private Button InactiveBtn;

	[SerializeField]
	private GameObject RootObj;

	[SerializeField]
	private GameObject InactiveBtnObj;

	private bool IsInitEvents;

	private int AbilityIdx;

	public void Set(int abilityIdx, bool isActive)
	{
	}

	public void SetActive(bool isActive)
	{
	}

	private void InitEvents()
	{
	}
}
