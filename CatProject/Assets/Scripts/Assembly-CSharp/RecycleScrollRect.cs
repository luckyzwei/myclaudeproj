using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RecycleScrollRect : ScrollRect
{
	[Serializable]
	public class AnimParams
	{
		public bool AnimateSequentially;

		public float FirstDelay;

		public float PlayDuration;

		public float OverShootValue;

		public Action DataUpdateAction;

		public Action OnComplete;

		[Header("Sound")]
		[SerializeField]
		public string ItemMoveSound;
	}

	[CompilerGenerated]
	private sealed class _003CFocusToIndexCoroutine_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecycleScrollRect _003C_003E4__this;

		public Vector2 anchoredPosition;

		private float _003CelapsedTime_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CFocusToIndexCoroutine_003Ed__52(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRemoveFirstItemAnimation_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RecycleScrollRect _003C_003E4__this;

		public AnimParams animParams;

		private List<Vector3> _003CtargetPositions_003E5__2;

		private LinkedListNode<GameObject> _003Cslot_003E5__3;

		private Animator _003Canimator_003E5__4;

		private List<Vector3> _003CoriginalPositions_003E5__5;

		private int _003Ci_003E5__6;

		private float _003CelapsedTime_003E5__7;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CRemoveFirstItemAnimation_003Ed__54(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private GameObject SlotObject;

	[SerializeField]
	private int DivCnt;

	[SerializeField]
	private int widthSpace;

	[SerializeField]
	private int heightSpace;

	[SerializeField]
	private int startWidthSpace;

	[SerializeField]
	private int startHeightSpace;

	[SerializeField]
	private float BottomYPadding;

	[SerializeField]
	private Vector2 SlotSize;

	[SerializeField]
	private bool Reverse;

	[SerializeField]
	private TextAnchor childAlignment;

	private Action<int, GameObject> OnDragIndex;

	private Action<GameObject> OnClickSlot;

	private GameObject SlotObjectT;

	private LinkedList<GameObject> SlotList;

	private LinkedListNode<GameObject> SlotCurIndex;

	private int dataIndex;

	private float slotWidth;

	private float slotHeight;

	private int horizontalCnt;

	private int verticalCnt;

	private bool IsAnimating;

	private Coroutine AnimationCoroutine;

	public int dataSize { get; private set; }

	public int lineCount { get; private set; }

	public int DIV
	{
		get
		{
			return (DivCnt > 0) ? DivCnt : 1;
		}
	}

	protected override void Awake()
	{
		base.Awake();
		SlotList = new LinkedList<GameObject>();
		onValueChanged.AddListener(delegate
		{
			// Scroll value changed - handled in LateUpdate
		});
	}

	public void GenerateList(int _dataSize)
	{
		dataSize = _dataSize;
		Init();
	}

	public void SetSlotObject(GameObject _slot, int _dataSize)
	{
		SlotObjectT = _slot;
		dataSize = _dataSize;
		Init();
	}

	private void Init()
	{
		if (SlotList == null)
		{
			SlotList = new LinkedList<GameObject>();
		}
		foreach (GameObject slot in SlotList)
		{
			if (slot != null)
			{
				Destroy(slot);
			}
		}
		SlotList.Clear();

		GameObject slotTemplate = (SlotObjectT != null) ? SlotObjectT : SlotObject;
		if (slotTemplate == null)
		{
			return;
		}

		if (SlotSize != Vector2.zero)
		{
			slotWidth = SlotSize.x;
			slotHeight = SlotSize.y;
		}
		else
		{
			RectTransform slotRect = slotTemplate.GetComponent<RectTransform>();
			if (slotRect != null)
			{
				slotWidth = slotRect.rect.width;
				slotHeight = slotRect.rect.height;
			}
		}

		RectTransform viewportRect = viewport != null ? viewport : GetComponent<RectTransform>();
		float viewWidth = viewportRect.rect.width;
		float viewHeight = viewportRect.rect.height;

		int div = DIV;
		horizontalCnt = div;
		verticalCnt = Mathf.CeilToInt(viewHeight / (slotHeight + heightSpace)) + 1;

		lineCount = Mathf.CeilToInt((float)dataSize / div);

		int totalSlots = horizontalCnt * (verticalCnt + 1);
		if (totalSlots > dataSize)
		{
			totalSlots = dataSize;
		}

		dataIndex = 0;

		for (int i = 0; i < totalSlots; i++)
		{
			GameObject slot = Instantiate(slotTemplate, content);
			slot.SetActive(true);
			RectTransform rt = slot.GetComponent<RectTransform>();
			rt.anchorMin = new Vector2(0f, 1f);
			rt.anchorMax = new Vector2(0f, 1f);
			rt.pivot = new Vector2(0f, 1f);
			rt.sizeDelta = new Vector2(slotWidth, slotHeight);
			SlotList.AddLast(slot);

			// Add click listener
			Button btn = slot.GetComponent<Button>();
			if (btn != null)
			{
				GameObject captured = slot;
				btn.onClick.AddListener(delegate
				{
					if (OnClickSlot != null)
					{
						OnClickSlot(captured);
					}
				});
			}
		}

		CalculatePosition(true);

		SetPosition();

		SlotAllEvent();
	}

	public void CalculatePosition(bool forceUpdate = false)
	{
		int div = DIV;
		lineCount = Mathf.CeilToInt((float)dataSize / div);

		float contentHeight = startHeightSpace + lineCount * (slotHeight + heightSpace) - heightSpace + BottomYPadding;
		float contentWidth = startWidthSpace * 2f + div * (slotWidth + widthSpace) - widthSpace;

		RectTransform contentRect = content;
		if (contentRect != null)
		{
			contentRect.sizeDelta = new Vector2(contentRect.sizeDelta.x, contentHeight);
		}
	}

	public Vector2 GetContentsAnchoredPosition()
	{
		return content.anchoredPosition;
	}

	public void SetContentsAnchoredPosition(Vector2 anchoredPosition)
	{
		content.anchoredPosition = anchoredPosition;
	}

	private void SetPosition()
	{
		if (SlotList == null || SlotList.Count == 0)
		{
			return;
		}

		int div = DIV;
		int index = dataIndex;
		LinkedListNode<GameObject> node = SlotList.First;

		while (node != null)
		{
			int col = index % div;
			int row = index / div;

			float xPos;
			if (childAlignment == TextAnchor.MiddleCenter || childAlignment == TextAnchor.UpperCenter || childAlignment == TextAnchor.LowerCenter)
			{
				RectTransform viewportRect = viewport != null ? viewport : GetComponent<RectTransform>();
				float totalWidth = div * slotWidth + (div - 1) * widthSpace;
				float offsetX = (viewportRect.rect.width - totalWidth) * 0.5f;
				xPos = offsetX + col * (slotWidth + widthSpace);
			}
			else
			{
				xPos = startWidthSpace + col * (slotWidth + widthSpace);
			}

			float yPos;
			if (Reverse)
			{
				yPos = -(startHeightSpace + (lineCount - 1 - row) * (slotHeight + heightSpace));
			}
			else
			{
				yPos = -(startHeightSpace + row * (slotHeight + heightSpace));
			}

			RectTransform rt = node.Value.GetComponent<RectTransform>();
			rt.anchoredPosition = new Vector2(xPos, yPos);
			node.Value.SetActive(index < dataSize);

			index++;
			node = node.Next;
		}
	}

	protected override void LateUpdate()
	{
		base.LateUpdate();

		if (SlotList == null || SlotList.Count == 0 || IsAnimating)
		{
			return;
		}

		int div = DIV;
		float scrollY = content.anchoredPosition.y;

		while (SlotList.First != null)
		{
			LinkedListNode<GameObject> firstNode = SlotList.First;
			RectTransform firstRT = firstNode.Value.GetComponent<RectTransform>();
			float slotTop = firstRT.anchoredPosition.y + scrollY;

			if (slotTop > slotHeight + heightSpace)
			{
				// This slot is above the viewport, recycle to bottom
				int lastIndex = dataIndex + SlotList.Count;
				if (lastIndex >= dataSize)
				{
					break;
				}

				dataIndex += div;

				// Move div slots from front to back
				for (int i = 0; i < div; i++)
				{
					if (SlotList.First == null)
					{
						break;
					}
					LinkedListNode<GameObject> moveNode = SlotList.First;
					SlotList.RemoveFirst();
					SlotList.AddLast(moveNode.Value);
				}

				// Reposition and rebind
				SetPosition();
				SlotAllEvent();
			}
			else
			{
				break;
			}
		}

		while (SlotList.Last != null && dataIndex > 0)
		{
			LinkedListNode<GameObject> firstNode = SlotList.First;
			RectTransform firstRT = firstNode.Value.GetComponent<RectTransform>();
			float slotTop = firstRT.anchoredPosition.y + scrollY;

			if (slotTop < -(slotHeight))
			{
				break;
			}

			if (slotTop < 0)
			{
				break;
			}

			// First visible slot is still in view, check if we can bring slots from below
			LinkedListNode<GameObject> lastNode = SlotList.Last;
			RectTransform lastRT = lastNode.Value.GetComponent<RectTransform>();
			RectTransform viewportRect = viewport != null ? viewport : GetComponent<RectTransform>();
			float viewHeight = viewportRect.rect.height;
			float slotBottom = -(lastRT.anchoredPosition.y + scrollY);

			if (slotBottom > viewHeight + slotHeight + heightSpace)
			{
				// Last slot is below viewport, recycle to top
				dataIndex -= div;
				if (dataIndex < 0)
				{
					dataIndex = 0;
				}

				// Move div slots from back to front
				for (int i = 0; i < div; i++)
				{
					if (SlotList.Last == null)
					{
						break;
					}
					LinkedListNode<GameObject> moveNode = SlotList.Last;
					SlotList.RemoveLast();
					SlotList.AddFirst(moveNode.Value);
				}

				SetPosition();
				SlotAllEvent();
			}
			else
			{
				break;
			}
		}
	}

	public void AddListener(Action<int, GameObject> _action)
	{
		OnDragIndex = _action;
	}

	public void AddClickListener(Action<GameObject> _action)
	{
		OnClickSlot = _action;
	}

	public GameObject GetSlot(int index)
	{
		if (SlotList == null)
		{
			return null;
		}
		LinkedListNode<GameObject> node = SlotList.First;
		int curIdx = dataIndex;
		while (node != null)
		{
			if (curIdx == index)
			{
				return node.Value;
			}
			curIdx++;
			node = node.Next;
		}
		return null;
	}

	public LinkedList<GameObject> GetSlotList()
	{
		return SlotList;
	}

	public void Refresh()
	{
		SlotAllEvent();
	}

	public void ResetData()
	{
		dataIndex = 0;
		if (content != null)
		{
			content.anchoredPosition = Vector2.zero;
		}
		SetPosition();
		SlotAllEvent();
	}

	private void SlotAllEvent()
	{
		if (OnDragIndex == null || SlotList == null)
		{
			return;
		}
		LinkedListNode<GameObject> node = SlotList.First;
		int index = dataIndex;
		while (node != null)
		{
			if (index < dataSize)
			{
				OnDragIndex(index, node.Value);
			}
			index++;
			node = node.Next;
		}
	}

	public void FocusToIndex(int dataIndex)
	{
		Vector2 targetPos = CalculateFocusToIndexPosition(dataIndex);
		SetContentsAnchoredPosition(targetPos);
		this.dataIndex = 0;
		int div = DIV;
		int row = dataIndex / div;
		this.dataIndex = row * div;
		if (this.dataIndex < 0)
		{
			this.dataIndex = 0;
		}
		SetPosition();
		SlotAllEvent();
	}

	public void FocusToIndexCoroutine(int dataIndex)
	{
		Vector2 targetPos = CalculateFocusToIndexPosition(dataIndex);
		StartCoroutine(FocusToIndexCoroutine(targetPos));
	}

	private Vector2 CalculateFocusToIndexPosition(int dataIndex)
	{
		int div = DIV;
		int row = dataIndex / div;
		float yPos = startHeightSpace + row * (slotHeight + heightSpace);

		RectTransform viewportRect = viewport != null ? viewport : GetComponent<RectTransform>();
		float viewHeight = viewportRect.rect.height;
		float maxY = content.sizeDelta.y - viewHeight;
		if (maxY < 0f)
		{
			maxY = 0f;
		}
		yPos = Mathf.Clamp(yPos, 0f, maxY);

		return new Vector2(content.anchoredPosition.x, yPos);
	}

	[IteratorStateMachine(typeof(_003CFocusToIndexCoroutine_003Ed__52))]
	private IEnumerator FocusToIndexCoroutine(Vector2 anchoredPosition)
	{
		float elapsedTime = 0f;
		float duration = 0.3f;
		Vector2 startPos = content.anchoredPosition;
		while (elapsedTime < duration)
		{
			elapsedTime += Time.deltaTime;
			float t = EaseInOutSine(Mathf.Clamp01(elapsedTime / duration));
			content.anchoredPosition = Vector2.Lerp(startPos, anchoredPosition, t);
			yield return null;
		}
		content.anchoredPosition = anchoredPosition;
	}

	public void RemoveFirstItemWithAnimation(AnimParams animParams)
	{
		if (IsAnimating)
		{
			return;
		}
		if (AnimationCoroutine != null)
		{
			StopCoroutine(AnimationCoroutine);
		}
		AnimationCoroutine = StartCoroutine(RemoveFirstItemAnimation(animParams));
	}

	[IteratorStateMachine(typeof(_003CRemoveFirstItemAnimation_003Ed__54))]
	private IEnumerator RemoveFirstItemAnimation(AnimParams animParams)
	{
		IsAnimating = true;

		List<Vector3> originalPositions = new List<Vector3>();
		List<Vector3> targetPositions = new List<Vector3>();
		LinkedListNode<GameObject> slot = SlotList.First;
		int slotIdx = 0;

		while (slot != null)
		{
			originalPositions.Add(slot.Value.GetComponent<RectTransform>().localPosition);
			targetPositions.Add(CalculateTargetPosition(slot.Value, slotIdx, true));
			slot = slot.Next;
			slotIdx++;
		}

		if (SlotList.First != null)
		{
			Animator animator = SlotList.First.Value.GetComponent<Animator>();
			if (animator != null && !string.IsNullOrEmpty(animParams.ItemMoveSound))
			{
				// Trigger animation
			}
		}

		if (animParams.FirstDelay > 0f)
		{
			yield return new WaitForSeconds(animParams.FirstDelay);
		}

		float elapsedTime = 0f;
		float duration = animParams.PlayDuration;
		if (duration <= 0f)
		{
			duration = 0.3f;
		}

		while (elapsedTime < duration)
		{
			elapsedTime += Time.deltaTime;
			float progress = Mathf.Clamp01(elapsedTime / duration);
			float easedProgress = EaseInOutSine(progress);

			slot = SlotList.First;
			int i = 0;
			while (slot != null && i < originalPositions.Count)
			{
				Vector3 newPos;
				if (animParams.OverShootValue > 0f)
				{
					newPos = CalculateOvershootPosition(originalPositions[i], targetPositions[i], easedProgress, animParams.OverShootValue);
				}
				else
				{
					newPos = Vector3.Lerp(originalPositions[i], targetPositions[i], easedProgress);
				}
				slot.Value.GetComponent<RectTransform>().localPosition = newPos;
				slot = slot.Next;
				i++;
			}

			yield return null;
		}

		slot = SlotList.First;
		int idx = 0;
		while (slot != null && idx < targetPositions.Count)
		{
			slot.Value.GetComponent<RectTransform>().localPosition = targetPositions[idx];
			slot = slot.Next;
			idx++;
		}

		if (animParams.DataUpdateAction != null)
		{
			animParams.DataUpdateAction();
		}

		CalculatePosition(true);
		SetPosition();
		SlotAllEvent();

		IsAnimating = false;

		if (animParams.OnComplete != null)
		{
			animParams.OnComplete();
		}
	}

	private Vector3 CalculateTargetPosition(GameObject slot, int slotIndex, bool isRemovingFirst)
	{
		int div = DIV;
		int targetIndex = isRemovingFirst ? slotIndex - 1 : slotIndex;
		if (targetIndex < 0)
		{
			targetIndex = 0;
		}

		int adjustedDataIndex = dataIndex + targetIndex;
		int col = adjustedDataIndex % div;
		int row = adjustedDataIndex / div;

		float xPos;
		if (childAlignment == TextAnchor.MiddleCenter || childAlignment == TextAnchor.UpperCenter || childAlignment == TextAnchor.LowerCenter)
		{
			RectTransform viewportRect = viewport != null ? viewport : GetComponent<RectTransform>();
			float totalWidth = div * slotWidth + (div - 1) * widthSpace;
			float offsetX = (viewportRect.rect.width - totalWidth) * 0.5f;
			xPos = offsetX + col * (slotWidth + widthSpace);
		}
		else
		{
			xPos = startWidthSpace + col * (slotWidth + widthSpace);
		}

		float yPos = -(startHeightSpace + row * (slotHeight + heightSpace));

		return new Vector3(xPos, yPos, 0f);
	}

	private Vector3 CalculateOvershootPosition(Vector3 originalPos, Vector3 targetPos, float progress, float overshootValue)
	{
		float overshoot;
		if (progress < 0.7f)
		{
			float t = progress / 0.7f;
			overshoot = Mathf.Lerp(0f, 1f + overshootValue, EaseInSine(t));
		}
		else
		{
			float t = (progress - 0.7f) / 0.3f;
			overshoot = Mathf.Lerp(1f + overshootValue, 1f, EaseInOutSine(t));
		}
		return Vector3.LerpUnclamped(originalPos, targetPos, overshoot);
	}

	private float EaseInOutSine(float x)
	{
		return -(Mathf.Cos(Mathf.PI * x) - 1f) / 2f;
	}

	private float EaseInSine(float x)
	{
		return 1f - Mathf.Cos(x * Mathf.PI / 2f);
	}
}
