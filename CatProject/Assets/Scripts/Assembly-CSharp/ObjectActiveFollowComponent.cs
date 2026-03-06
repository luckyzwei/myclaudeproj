using System;
using UnityEngine;

public class ObjectActiveFollowComponent : MonoBehaviour
{
	public Action ActiveCb;

	private void OnEnable()
	{
		ActiveCb?.Invoke();
	}

	private void OnDisable()
	{
		// Cleanup on disable
	}
}
