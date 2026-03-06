using UnityEngine;

public class TutorialEntityClickWait : TutorialEntity
{
	[SerializeField]
	private bool mask;

	[SerializeField]
	protected RectTransform maskTrans;

	[SerializeField]
	private TutorialIdent id;

	[SerializeField]
	private GameObject clickobj;

	[SerializeField]
	private int targetIdx;

	[SerializeField]
	private int targetSubIdx;

	[SerializeField]
	private float paddingValue;

	[SerializeField]
	private float paddingAddYValue;

	[SerializeField]
	private Vector3 clickobjpadding;

	[SerializeField]
	private bool CallClickEvent;

	private Rect ClickAble;

	protected GameObject target;

	private bool checkUI;

	private bool isClicked;

	public override void StartEntity()
	{
		isClicked = false;
		checkUI = false;
	}

	public Rect RectTransformToScreenSpace(RectTransform _transform)
	{
		return default(Rect);
	}

	private void Update()
	{
		if (isClicked) return;
		if (Input.GetMouseButtonDown(0))
			Click();
	}

	private void Click()
	{
		isClicked = true;
		EndEntity();
	}
}
