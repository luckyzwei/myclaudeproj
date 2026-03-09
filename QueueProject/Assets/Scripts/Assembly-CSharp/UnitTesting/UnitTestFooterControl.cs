using System;
using UnityEngine.UIElements;

namespace UnitTesting
{
	public class UnitTestFooterControl
	{
		private Label m_ProgressStatusLabel;

		private Label m_ProgressValueLabel;

		private ProgressBar m_MainProgressBar;

		private Button m_RunButton;

		private Button m_ResetButton;

		public string ButtonText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsButtonEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ResetButtonVisible
		{
			set
			{
			}
		}

		public event Action ResetButtonClicked
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action RunButtonClicked
		{
			add
			{
			}
			remove
			{
			}
		}

		public UnitTestFooterControl(VisualElement root, string footerInstance)
		{
		}

		public void SetProgressStatus(string statusText)
		{
		}

		public void SetProgressValues(int current, int total)
		{
		}

		public void SetProgressPercent(float percent)
		{
		}
	}
}
