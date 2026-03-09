using KWCore.UI;

namespace KWAds.UI
{
	[SortingLayer("RewardAdBlocker")]
	public class RewardAdBlocker : PopUpBase
	{
		public interface IDelegate
		{
			void RetryRewardVideo();

			void KillRewardAdBlocker();
		}

		private double m_closeTimer;

		private double m_pingTimer;

		private double m_overtimeTimer;

		private bool m_finished;

		private bool m_pendingRetry;

		private bool m_pendingFinish;

		private bool m_waitingOnShowAttemptCallback;

		private IDelegate m_delegate;

		public void Init(IDelegate del)
		{
		}

		public void Update()
		{
		}

		private void RetryShow()
		{
		}

		public void AdShowFailed()
		{
		}

		public void AdLoaded()
		{
		}

		public bool IsFinished()
		{
			return false;
		}
	}
}
