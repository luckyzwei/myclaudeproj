using UnityEngine;

public class PaintObject : MonoBehaviour
{
	[SerializeField]
	private Renderer m_renderer;

	private float m_rotationSpeed;

	private Vector3 m_rotationAxis;

	public void Config(float speed, Material material)
	{
	}

	private void Update()
	{
	}
}
