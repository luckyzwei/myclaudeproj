using System;
using UnityEngine;
using UnityEngine.Events;

public class ClickCallback : MonoBehaviour
{
	[Serializable]
	public class ColliderClickedEvent : UnityEvent<Vector2>
	{
	}

	[HideInInspector]
	[SerializeField]
	private string targetTagName;

	public ColliderClickedEvent OnCallback;

	public void Click(string clickedTag, Vector2 touchPosition)
	{
	}

	public void AddCallback(Action cb)
	{
	}

	public void ClearCallback()
	{
	}

	public void TutorialClick()
	{
	}
}
