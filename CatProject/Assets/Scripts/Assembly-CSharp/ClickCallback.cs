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
		if (!string.IsNullOrEmpty(targetTagName) && clickedTag != targetTagName) return;
		OnCallback?.Invoke(touchPosition);
	}

	public void AddCallback(Action cb)
	{
		if (cb != null)
			OnCallback.AddListener(_ => cb());
	}

	public void ClearCallback()
	{
		OnCallback.RemoveAllListeners();
	}

	public void TutorialClick()
	{
		OnCallback?.Invoke(Vector2.zero);
	}
}
