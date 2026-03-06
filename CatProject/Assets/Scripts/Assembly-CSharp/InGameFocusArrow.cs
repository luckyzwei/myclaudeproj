using Treeplla;
using UnityEngine;

[UIPath("UI/InGame/FocusArrow", false, false)]
public class InGameFocusArrow : InGameFloatingUI
{
	[SerializeField]
	private float hideTime;

	private float deltaTime;

	public override void Show()
	{
		base.Show();
		deltaTime = 0f;
	}

	public override void Hide()
	{
		base.Hide();
		deltaTime = 0f;
	}

	protected override void Update()
	{
		base.Update();
		if (!isHide && hideTime > 0f)
		{
			deltaTime += Time.deltaTime;
			if (deltaTime >= hideTime)
			{
				Hide();
			}
		}
	}
}
