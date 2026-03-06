using UniRx;
using UnityEngine;

public class SeasonalStatue : MonoBehaviour
{
	[SerializeField]
	private GameObject LockObj;

	[SerializeField]
	private GameObject UnlockObj;

	private InGameStatueUI statueUI;

	private CompositeDisposable Disposables;

	public void Init()
	{
		Disposables = new CompositeDisposable();
		if (LockObj != null) LockObj.SetActive(true);
		if (UnlockObj != null) UnlockObj.SetActive(false);
	}

	private void OnDestroy()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = null; }
	}

	private void OnDisable()
	{
		if (Disposables != null) { Disposables.Dispose(); Disposables = new CompositeDisposable(); }
	}

	public void OnClickStatue()
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null) return;
	}
}
