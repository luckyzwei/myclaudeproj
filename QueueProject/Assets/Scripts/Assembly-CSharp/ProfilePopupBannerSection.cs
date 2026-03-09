using System.Collections.Generic;
using UnityEngine;

public class ProfilePopupBannerSection : MonoBehaviour
{
	[SerializeField]
	private Transform m_container;

	[SerializeField]
	private ProfileBackgroundContainer m_prefab;

	private List<ProfileBackgroundContainer> m_buttons;

	private void Start()
	{
	}

	protected void CreateProfileImages()
	{
	}

	public void OnBannerClicked(string clientId)
	{
	}
}
