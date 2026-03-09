using System;
using Balancy.Models.LiveOps.Store;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(StorePageDisplay))]
[RequireComponent(typeof(Button))]
public class StorePageTab : MonoBehaviour
{
	private StorePageDisplay m_pageDisplay;

	private Button m_button;

	private Action<Page> m_onPressedCallback;

	private Page m_storePage;

	internal Page StorePage => null;

	private void Awake()
	{
	}

	public void Config(Page page, Action<Page> onPressed)
	{
	}

	public void OnPressed()
	{
	}

	public void Toggle(Page selectedPage)
	{
	}
}
