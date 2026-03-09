using UnityEngine;

[RequireComponent(typeof(TabToolbarButton))]
public class LockTabUntilLevel : MonoBehaviour
{
	[SerializeField]
	private int m_unlockLevel;

	private void Start()
	{
	}

	public void Refresh()
	{
	}

	protected virtual bool MustBeLocked()
	{
		return false;
	}
}
