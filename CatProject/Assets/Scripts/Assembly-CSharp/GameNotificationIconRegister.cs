using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class GameNotificationIconRegister : MonoBehaviour
{
	[SerializeField]
	private bool awakeRegit;

	[SerializeField]
	private GameNotificationSystem.NotificationCategory category;

	[SerializeField]
	private int targetIdx;

	[SerializeField]
	private int targetSubIdx;

	[SerializeField]
	private GameObject redDot;

	[SerializeField]
	private Image reddotIcon;

	[SerializeField]
	private Text reddotCount;

	[SerializeField]
	private bool reverse;

	private CompositeDisposable disposables;

	private void Awake()
	{
		disposables = new CompositeDisposable();
		if (awakeRegit)
			Init(targetIdx, targetSubIdx);
	}

	public void Init(int _targetIdx, int _targetSubIdx)
	{
		targetIdx = _targetIdx;
		targetSubIdx = _targetSubIdx;
		UpdateActive();
	}

	public void Init(GameNotificationSystem.NotificationCategory _category, int _targetIdx, int _targetSubIdx, bool _reverse = false)
	{
		category = _category;
		targetIdx = _targetIdx;
		targetSubIdx = _targetSubIdx;
		reverse = _reverse;
		UpdateActive();
	}

	public void SetReddot(GameObject _reddot)
	{
		redDot = _reddot;
	}

	public void UpdateRedDotPos(Vector3 worldPos)
	{
		if (redDot != null)
			redDot.transform.position = worldPos;
	}

	public void SetCategory(GameNotificationSystem.NotificationCategory _category)
	{
		category = _category;
	}

	private void OnDestroy()
	{
		RemoveRegist();
	}

	public void RemoveRegist()
	{
		if (disposables != null)
		{
			disposables.Dispose();
			disposables = new CompositeDisposable();
		}
	}

	public void UpdateActive()
	{
		bool active = false;
		if (reverse) active = !active;
		if (redDot != null) redDot.SetActive(active);
	}

	private void SetIcon(int idx)
	{
	}
}
