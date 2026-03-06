using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Treeplla;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupPlantPreview", false, false)]
public class PopupPlantPreview : UIBase
{
	[CompilerGenerated]
	private sealed class _003CFocusOnTargetIndex_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupPlantPreview _003C_003E4__this;

		public GameObject target;

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
		public _003CFocusOnTargetIndex_003Ed__4(int _003C_003E1__state)
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
	private ScrollRect PlantScrollRect;

	[SerializeField]
	private GameObject PlantPreviewPrefab;

	private List<ItemPlantPreview> PlantPreviews;

	public void Set(int plantIdx)
	{
		// Update display
	}

	[IteratorStateMachine(typeof(_003CFocusOnTargetIndex_003Ed__4))]
	private IEnumerator FocusOnTargetIndex(GameObject target)
	{
		yield break;
	}
}
