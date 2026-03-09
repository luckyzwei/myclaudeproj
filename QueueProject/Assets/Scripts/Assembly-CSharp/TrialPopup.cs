using System;
using KWCore.UI;

public class TrialPopup : PopUpBase
{
	private string m_trialId;

	private Action<bool> m_respondCallback;

	public void Config(string trialId, Action<bool> respondCallback)
	{
	}

	public void OnStartTrialPressed()
	{
	}

	public void OnRejectTrialPressed()
	{
	}
}
