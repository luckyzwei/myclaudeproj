using UnityEngine;

public class LifeHeart : MonoBehaviour
{
	private const int VIBRATO = 1;

	private const float DURATION = 0.25f;

	private const float DELAY = 0.05f;

	[SerializeField]
	private GameObject m_activeLifeObject;

	private void Awake()
	{
	}

	public void SetLifeActive(bool active, int index)
	{
	}
}
