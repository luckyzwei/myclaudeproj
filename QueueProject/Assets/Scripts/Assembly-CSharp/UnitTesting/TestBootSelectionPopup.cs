using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnitTesting
{
	public class TestBootSelectionPopup
	{
		private UIDocument m_uiDocument;

		private GameObject m_uiGameObject;

		private VisualElement m_popupRoot;

		private readonly VisualElement m_parent;

		private const string POPUP_GAMEOBJECT_NAME = "BootSelectionPopupUI";

		public void Show(Action onFirstBootClicked, Action onCurrentBootClicked)
		{
		}

		public void Dispose()
		{
		}
	}
}
