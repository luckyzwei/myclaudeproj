using UniRx;
using UnityEngine;

public class TpRunner : MonoBehaviour
{
	public static TpRunner _TpRunner;

	public static TpResponseQueue _responseQueue;

	public static TpGameStats _gameStats;

	public static CompositeDisposable loadSceneDisposable;

	public static CompositeDisposable unloadSceneDisposable;

	public static CompositeDisposable applicaitonPausedDisposable;

	protected void Awake()
	{
	}

	protected void Start()
	{
	}

	protected void Update()
	{
	}

	public TpObject GameObjectToTpObject(GameObject TpGameObject, Camera camera = null)
	{
		return null;
	}

	public static GameObject[] GetDontDestroyOnLoadObjects()
	{
		return null;
	}

	public static GameObject GetGameObject(int objectId)
	{
		return null;
	}

	public static void AddNotificationListener(TpNotificationType notificationType, Subject<object> subject)
	{
	}

	public static void RemoveNotificationListener(TpNotificationType commandParamsNotificationType)
	{
	}
}
