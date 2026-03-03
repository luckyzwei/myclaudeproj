using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class GameNotificationRegister : MonoBehaviour
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
	private Text reddotCount;

	[SerializeField]
	private bool reverse;

	private CompositeDisposable disposables;

	private void Awake()
	{
	}

	public void Init(int _targetIdx, int _targetSubIdx)
	{
	}

	public void Init(GameNotificationSystem.NotificationCategory _category, int _targetIdx, int _targetSubIdx, bool _reverse = false)
	{
	}

	public void SetReddot(GameObject reddot)
	{
	}

	public void UpdateRedDotPos(Vector3 worldPos)
	{
	}

	public void SetCategory(GameNotificationSystem.NotificationCategory _category)
	{
	}

	private void OnDestroy()
	{
	}

	public void RemoveRegist()
	{
	}

	public void UpdateActive()
	{
	}
}
