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
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void ReAddChildObserve()
	{
	}

	public virtual void UpdatePosition()
	{
	}
}
