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

	public int DIV { get { return 0; } }

	protected override void Awake()
	{
	}

	public void GenerateList(int _dataSize)
	{
	}

	public void SetSlotObject(GameObject _slot, int _dataSize)
	{
	}

	private void Init()
	{
	}

	public void CalculatePosition(bool forceUpdate = false)
	{
	}

	public Vector2 GetContentsAnchoredPosition()
	{
		return default(Vector2);
	}

	public void SetContentsAnchoredPosition(Vector2 anchoredPosition)
	{
	}

	private void SetPosition()
	{
	}

	protected override void LateUpdate()
	{
	}

	public void AddListener(Action<int, GameObject> _action)
	{
	}

	public void AddClickListener(Action<GameObject> _action)
	{
	}

	public GameObject GetSlot(int index)
	{
		return null;
	}

	public LinkedList<GameObject> GetSlotList()
	{
		return null;
	}

	public void Refresh()
	{
	}

	public void ResetData()
	{
	}

	private void SlotAllEvent()
	{
	}

	public void FocusToIndex(int dataIndex)
	{
	}

	public void FocusToIndexCoroutine(int dataIndex)
	{
	}

	private Vector2 CalculateFocusToIndexPosition(int dataIndex)
	{
		return default(Vector2);
	}

	[IteratorStateMachine(typeof(_003CFocusToIndexCoroutine_003Ed__52))]
	private IEnumerator FocusToIndexCoroutine(Vector2 anchoredPosition)
	{
		yield break;
	}

	public void RemoveFirstItemWithAnimation(AnimParams animParams)
	{
	}

	[IteratorStateMachine(typeof(_003CRemoveFirstItemAnimation_003Ed__54))]
	private IEnumerator RemoveFirstItemAnimation(AnimParams animParams)
	{
		yield break;
	}

	private Vector3 CalculateTargetPosition(GameObject slot, int slotIndex, bool isRemovingFirst)
	{
		return default(Vector3);
	}

	private Vector3 CalculateOvershootPosition(Vector3 originalPos, Vector3 targetPos, float progress, float overshootValue)
	{
		return default(Vector3);
	}

	private float EaseInOutSine(float x)
	{
		return 0f;
	}

	private float EaseInSine(float x)
	{
		return 0f;
	}
}
