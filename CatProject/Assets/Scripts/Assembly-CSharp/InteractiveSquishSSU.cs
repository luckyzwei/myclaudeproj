using UnityEngine;

public class InteractiveSquishSSU : MonoBehaviour
{
	[Header("Settings:")]
	public float squishSpeed;

	public bool staySquished;

	public float squishDuration;

	private Material mat;

	private float currentSquish;

	private float lastTriggerStayTime;

	private void Start()
	{
	}

	private void OnTriggerStay2D(Collider2D collision)
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private void Update()
	{
	}

	private void UpdateSquish()
	{
	}
}
