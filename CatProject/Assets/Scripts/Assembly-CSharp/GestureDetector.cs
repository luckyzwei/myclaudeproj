using UnityEngine;

public class GestureDetector : MonoBehaviour
{
	public enum State
	{
		None = 0,
		First = 1,
		Second = 2
	}

	private Vector2 fingerDownPosition;

	private float firstX;

	private float secondY;

	private float offsetX;

	private float offsetY;

	private State state;

	private void Awake()
	{
	}

	private void CheckFirstMove(Vector2 pos)
	{
	}

	private void CheckSecondMove(Vector2 pos)
	{
	}

	private void Complete()
	{
	}
}
