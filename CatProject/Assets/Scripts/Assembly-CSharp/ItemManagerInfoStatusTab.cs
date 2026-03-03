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
	}

	public void Set(int managerIdx)
	{
	}

	public void Reset()
	{
	}

	public void Refresh()
	{
	}

	public void ManagerReinforceTutorial()
	{
	}

	private void OnClickInfo()
	{
	}
}
