using UnityEngine;

public class TutorialEntityClickAny : TutorialEntity
{
	[SerializeField]
	private RectTransform ClickAble;

	[SerializeField]
	private float TouchLockTime;

	private float dTime;

	public override void StartEntity()
	{
		dTime = 0f;
	}

	private void Update()
	{
		dTime += Time.deltaTime;
		if (dTime >= TouchLockTime && Input.GetMouseButtonDown(0))
			Click();
	}

	private void Click()
	{
		EndEntity();
	}
}
