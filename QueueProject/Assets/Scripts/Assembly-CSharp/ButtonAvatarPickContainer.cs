using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonAvatarPickContainer : MonoBehaviour
{
	[SerializeField]
	private AvatarContainer m_avataContainer;

	[SerializeField]
	private Button m_button;

	protected AvatarData m_avatarData;

	private Action<AvatarData> m_callback;

	private void ValidateButtonReference()
	{
	}

	private void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public virtual void Configure(AvatarData avatarData, Action<AvatarData> callback)
	{
	}

	public virtual void OnButtonPressed()
	{
	}

	protected virtual void OnPlayerProfileChanged(PublicProfile profile)
	{
	}
}
