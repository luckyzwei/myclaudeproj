using UnityEngine;

public class ImageRotator : MonoBehaviour
{
	private enum Axis
	{
		z = 0,
		x = 1,
		y = 2
	}

	[SerializeField]
	private float m_rotationSpeed;

	[SerializeField]
	private Axis m_axis;

	private Vector3 m_direction;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
