using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using KWCore.Utils;
using UnityEngine;

public class PassiveNotificationManager : MonoSingleton<PassiveNotificationManager>
{
	[CompilerGenerated]
	private sealed class _003CPositionAndClampRoutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PassiveNotificationManager _003C_003E4__this;

		public WidgetPassiveNotification notification;

		public Vector2 desiredLocalPos;

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
		public _003CPositionAndClampRoutine_003Ed__5(int _003C_003E1__state)
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
	private WidgetPassiveNotification m_passiveNotificationWidgetPrefab;

	protected override void Init()
	{
	}

	public static void ShowPassiveNotification(Vector3 uiElementScreenPos, string key, bool hideIcon = false)
	{
	}

	public static void ShowPassiveNotification(Transform worldTransform, string key, bool hideIcon = false)
	{
	}

	private void CreateAndPositionNotification(Vector2 desiredLocalPos, string key, bool showIcon)
	{
	}

	[IteratorStateMachine(typeof(_003CPositionAndClampRoutine_003Ed__5))]
	private IEnumerator PositionAndClampRoutine(WidgetPassiveNotification notification, Vector2 desiredLocalPos)
	{
		return null;
	}

	private void PositionAndClamp(WidgetPassiveNotification notification, Vector2 desiredLocalPos)
	{
	}
}
