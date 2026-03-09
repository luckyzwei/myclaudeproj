using System;
using UnityEngine;

public class ButtonAvatarPickQueens : ButtonAvatarPickContainer
{
	[SerializeField]
	private GameObject m_notificationBadge;

	[SerializeField]
	private GameObject m_tick;

	private bool m_isNew;

	public override void Configure(AvatarData avatarData, Action<AvatarData> callback)
	{
	}

	public override void OnButtonPressed()
	{
	}

	protected override void OnPlayerProfileChanged(PublicProfile profile)
	{
	}
}
