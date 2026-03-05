using Treeplla;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class HUDMiniGameComponent : MonoBehaviour
{
	[SerializeField]
	private GameObject RootObj;

	[SerializeField]
	private Image MainIcon;

	[SerializeField]
	private Text RemainTimeText;

	[SerializeField]
	private Button EnterButton;

	private CompositeDisposable Disposables;

	public void Awake()
	{
		if (EnterButton != null)
			EnterButton.onClick.AddListener(OnClickedEnterButton);
	}

	public void Init()
	{
		Disposables?.Dispose();
		Disposables = new CompositeDisposable();

		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;

		var miniGameSystem = root.MiniGameSystem;
		if (miniGameSystem == null) return;

		OnOpenMiniGameContents();
	}

	public void ShowOpenTween(bool show, bool direct = false)
	{
		if (RootObj == null) return;

		if (direct)
		{
			RootObj.SetActive(show);
			return;
		}

		RootObj.SetActive(show);
	}

	private void OnOpenMiniGameContents()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null || root.MiniGameSystem == null) return;

		bool hasActiveMiniGame = root.MiniGameSystem.GetNowMiniGameBase() != null;
		ShowOpenTween(hasActiveMiniGame, true);
	}

	private void OnClickedEnterButton()
	{
		OpenMiniGameUI();
	}

	private void OpenMiniGameUI()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root == null) return;
		root.WaitAndOpenUICoroutine<PopupMiniGameOpen>();
	}
}
