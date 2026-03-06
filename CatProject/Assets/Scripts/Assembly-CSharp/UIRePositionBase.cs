using UniRx;
using UnityEngine;

[AddComponentMenu(null)]
public class UIRePositionBase : MonoBehaviour
{
	[SerializeField]
	protected float startPadding;

	[SerializeField]
	protected float spacing;

	[SerializeField]
	protected bool isReverse;

	[SerializeField]
	protected bool isSetSize;

	protected RectTransform myRectTr;

	protected bool isInit;

	private int childCount;

	private CompositeDisposable disposable;

	private void Start()
	{
		myRectTr = GetComponent<RectTransform>();
		isInit = true;
		ReAddChildObserve();
		UpdatePosition();
	}

	private void OnEnable()
	{
		if (isInit)
			UpdatePosition();
	}

	private void OnDestroy()
	{
		if (disposable != null)
		{
			disposable.Dispose();
			disposable = null;
		}
	}

	private void OnDisable()
	{
		if (disposable != null)
		{
			disposable.Dispose();
			disposable = null;
		}
	}

	private void ReAddChildObserve()
	{
		if (disposable != null)
			disposable.Dispose();
		disposable = new CompositeDisposable();
		childCount = transform.childCount;
	}

	public virtual void UpdatePosition()
	{
		// Virtual base - override in subclass
	}
}
