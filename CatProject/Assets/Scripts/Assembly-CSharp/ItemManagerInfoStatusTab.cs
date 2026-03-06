using UnityEngine;
using UnityEngine.UI;

public class ItemManagerInfoStatusTab : MonoBehaviour, ITabToggleTab
{
	[Header("Main Button")]
	[SerializeField]
	private Button InfoBtn;

	[SerializeField]
	private ItemManagerInfoOffice ManagerInfoOffice;

	[SerializeField]
	private ItemManagerInfoAcquisition ManagerInfoAcquisition;

	private int ManagerIdx;

	private bool IsMaxLevel;

	private void Awake()
	{
		if (InfoBtn != null) InfoBtn.onClick.AddListener(OnClickInfo);
	}

	public void Set(int managerIdx)
	{
		ManagerIdx = managerIdx;
		IsMaxLevel = false;
		Refresh();
	}

	public void Reset()
	{
		ManagerIdx = -1;
		IsMaxLevel = false;
	}

	public void Refresh()
	{
		if (ManagerInfoOffice != null) ManagerInfoOffice.gameObject.SetActive(true);
		if (ManagerInfoAcquisition != null) ManagerInfoAcquisition.gameObject.SetActive(true);
	}

	public void ManagerReinforceTutorial()
	{
		// TODO
	}

	private void OnClickInfo()
	{
		// Handle click
	}
}
