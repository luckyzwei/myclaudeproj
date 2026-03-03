using UnityEngine;
using UnityEngine.UI;

public class BottomComponent : MonoBehaviour
{
	public Button btn;

	public Animator lockAni;

	public GameObject lockObj;

	public GameObject TimeObj;

	private bool lockState;

	public bool LockState => false;

	public void Set(bool _lockState)
	{
	}

	public void UnLock()
	{
	}

	public void Lock()
	{
	}
}
