using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class RecyclerScrollEvents
{
	[Header("Events")]
	public UnityEvent OnUserScrollStartedEvent;

	public UnityEvent OnUserScrollEndedEvent;

	public UnityEvent<Vector2> OnScrollEvent;

	public UnityEvent OnAutoScrollStartedEvent;

	public UnityEvent OnAutoScrollEndedEvent;

	public UnityEvent<float> OnAutoScrollInProgressEvent;
}
