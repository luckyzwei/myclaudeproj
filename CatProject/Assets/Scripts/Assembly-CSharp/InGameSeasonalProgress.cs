using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[FloatUIPath("UI/InGame/SeasonalCooltime", true)]
[FloatingDepth(5)]
public class InGameSeasonalProgress : InGameFloatingUI
{
	public enum E_ProgressState
	{
		None = 0,
		Progress = 1,
		Pause = 2
	}

	[SerializeField]
	private Image progressImg;

	[SerializeField]
	private GameObject ProgressObj;

	[SerializeField]
	private GameObject PauseObj;

	public E_ProgressState ProgressState { get; private set; }

	public void UpdateValue(float value)
	{
	}

	public void SetProgressState(E_ProgressState progressState)
	{
	}
}
