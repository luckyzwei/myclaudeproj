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
	}

	public void Init()
	{
	}

	public void ShowOpenTween(bool show, bool direct = false)
	{
	}

	private void OnOpenMiniGameContents()
	{
	}

	private void OnClickedEnterButton()
	{
	}

	private void OpenMiniGameUI()
	{
	}
}
