using UnityEngine;
using UnityEngine.UI;

public class ItemFactoryProcessProduct : MonoBehaviour
{
	[SerializeField]
	private Text Name;

	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Image LockIcon;

	[SerializeField]
	private Text OwnCount;

	[SerializeField]
	private Text ProductCountPerHour;

	[SerializeField]
	private GameObject RunObj;

	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private Text LockText;

	[SerializeField]
	private Text UseOrMakeCount;

	private int ProductIdx;

	private bool isOpen;

	public void Set(int product, int useormakecount)
	{
		// Update display
	}

	private void Update()
	{
		// Update logic
	}
}
