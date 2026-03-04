using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

public class TimeSystem
{
	[CompilerGenerated]
	private sealed class _003CGetGoogleTime_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action onLoad;

		private Action<string, int> _003CExceptionSetUtcTime_003E5__2;

		private UnityWebRequestAsyncOperation _003Casync_003E5__3;

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
		public _003CGetGoogleTime_003Ed__2(int _003C_003E1__state)
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

	private static DateTime standardTime;

	public IObservable<float> CreateCountDownObservable(float countTime)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetGoogleTime_003Ed__2))]
	public static IEnumerator GetGoogleTime(Action onLoad)
	{
		return new _003CGetGoogleTime_003Ed__2(0) { onLoad = onLoad };
	}

	public static DateTime GetCurTime()
	{
		if (standardTime == default(DateTime))
			return DateTime.UtcNow;
		return standardTime + (DateTime.UtcNow - standardTime);
	}

	public static DateTime GetConvertUSTimeFromString(string strTime)
	{
		if (string.IsNullOrEmpty(strTime)) return default(DateTime);
		DateTime result;
		if (DateTime.TryParse(strTime, System.Globalization.CultureInfo.GetCultureInfo("en-US"), System.Globalization.DateTimeStyles.None, out result))
			return result;
		return default(DateTime);
	}

	public static DateTime GetConvertInvariantTimeFromString(string timeStr, string format = null)
	{
		if (string.IsNullOrEmpty(timeStr)) return default(DateTime);
		DateTime result;
		if (format != null)
		{
			if (DateTime.TryParseExact(timeStr, format, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out result))
				return result;
		}
		else
		{
			if (DateTime.TryParse(timeStr, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out result))
				return result;
		}
		return default(DateTime);
	}
}
