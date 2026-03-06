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
		var renderer = GetComponent<SpriteRenderer>();
		if (renderer != null)
			mat = renderer.material;
		currentSquish = 0f;
	}

	private void OnTriggerStay2D(Collider2D collision)
	{
		lastTriggerStayTime = Time.time;
		currentSquish = 1f;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		lastTriggerStayTime = Time.time;
		currentSquish = 1f;
	}

	private void Update()
	{
		UpdateSquish();
	}

	private void UpdateSquish()
	{
		if (!staySquished && currentSquish > 0f)
		{
			if (Time.time - lastTriggerStayTime > squishDuration)
			{
				currentSquish = Mathf.MoveTowards(currentSquish, 0f, squishSpeed * Time.deltaTime);
			}
		}
		if (mat != null)
			mat.SetFloat("_Squish", currentSquish);
	}
}
