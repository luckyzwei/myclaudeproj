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
		state = State.None;
	}

	private void CheckFirstMove(Vector2 pos)
	{
		offsetX = pos.x - fingerDownPosition.x;
		if (Mathf.Abs(offsetX) > 50f)
		{
			firstX = offsetX;
			state = State.Second;
		}
	}

	private void CheckSecondMove(Vector2 pos)
	{
		offsetY = pos.y - fingerDownPosition.y;
		if (Mathf.Abs(offsetY) > 50f)
		{
			secondY = offsetY;
			Complete();
		}
	}

	private void Complete()
	{
		state = State.None;
	}
}
