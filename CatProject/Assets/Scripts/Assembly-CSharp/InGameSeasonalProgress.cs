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
		if (progressImg != null)
			progressImg.fillAmount = UnityEngine.Mathf.Clamp01(value);
	}

	public void SetProgressState(E_ProgressState progressState)
	{
		ProgressState = progressState;
		if (ProgressObj != null) ProgressObj.SetActive(progressState == E_ProgressState.Progress);
		if (PauseObj != null) PauseObj.SetActive(progressState == E_ProgressState.Pause);
	}
}
