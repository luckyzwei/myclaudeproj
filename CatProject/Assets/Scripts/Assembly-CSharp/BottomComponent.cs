using UnityEngine;
using UnityEngine.UI;

public class BottomComponent : MonoBehaviour
{
	public Button btn;

	public Animator lockAni;

	public GameObject lockObj;

	public GameObject TimeObj;

	private bool lockState;

	public bool LockState { get { return lockState; } }

	public void Set(bool _lockState)
	{
		lockState = _lockState;
		if (lockState)
			Lock();
		else
			UnLock();
	}

	public void UnLock()
	{
		lockState = false;
		if (lockObj != null)
			lockObj.SetActive(false);
		if (lockAni != null)
			lockAni.SetTrigger("Unlock");
	}

	public void Lock()
	{
		lockState = true;
		if (lockObj != null)
			lockObj.SetActive(true);
	}
}
