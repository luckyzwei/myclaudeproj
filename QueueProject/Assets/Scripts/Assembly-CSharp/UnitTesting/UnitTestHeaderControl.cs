using System;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements;

namespace UnitTesting
{
	public class UnitTestHeaderControl
	{
		private readonly Button m_backButton;

		private readonly Label m_titleLabel;

		public string Title
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action BackButtonClicked
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public UnitTestHeaderControl(VisualElement root, string headerInstance)
		{
		}

		public void SetHeaderTitle(string title)
		{
		}

		private void OnBackButtonClickedInternally()
		{
		}
	}
}
