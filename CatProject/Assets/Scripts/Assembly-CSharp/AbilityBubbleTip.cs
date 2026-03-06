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
		AbilityIdx = abilityIdx;
		SetActive(isActive);
		if (!IsInitEvents) InitEvents();
	}

	public void SetActive(bool isActive)
	{
		if (RootObj != null) RootObj.SetActive(true);
		if (ActiveBtn != null) ActiveBtn.gameObject.SetActive(isActive);
		if (InactiveBtnObj != null) InactiveBtnObj.SetActive(!isActive);
	}

	private void InitEvents()
	{
		IsInitEvents = true;
		if (ActiveBtn != null) ActiveBtn.onClick.AddListener(() =>
		{
			var root = Treeplla.Singleton<GameRoot>.Instance;
			if (root == null) return;
		});
		if (InactiveBtn != null) InactiveBtn.onClick.AddListener(() =>
		{
			var root = Treeplla.Singleton<GameRoot>.Instance;
			if (root == null) return;
		});
	}
}
