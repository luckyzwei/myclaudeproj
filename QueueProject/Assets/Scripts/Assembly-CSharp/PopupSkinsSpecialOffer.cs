using System;
using Balancy.Models;
using UnityEngine;

public class PopupSkinsSpecialOffer : PopupSpecialOffer
{
	public new const string PREFAB_NAME = "Prefabs/Popups/PopUp-SpecialOffer-Skins";

	[SerializeField]
	private StarterPackOfferTimer m_timer;

	public new void Config(KwaleeOffer kwaleeOffer, Action callback = null, bool buttonPressed = false, string source = "")
	{
	}

	protected override void SpawnRewardsCells()
	{
	}
}
