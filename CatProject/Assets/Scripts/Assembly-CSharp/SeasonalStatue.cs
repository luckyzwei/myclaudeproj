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
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	public void OnClickStatue()
	{
	}
}
