using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Firebase;

public class TpRemoteProp
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public bool processing;

		public Task waitTask;

		public bool fetching;

		internal void _003CFetchRemote_003Eb__0(Task<DependencyStatus> task)
		{
		}

		internal bool _003CFetchRemote_003Eb__1()
		{
			return false;
		}

		internal bool _003CFetchRemote_003Eb__5()
		{
			return false;
		}

		internal bool _003CFetchRemote_003Eb__3()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_1
	{
		public bool waitFetch;

		public _003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals1;

		internal void _003CFetchRemote_003Eb__6(Task task)
		{
		}

		internal bool _003CFetchRemote_003Eb__7()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CFetchRemote_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass2_1 _003C_003E8__2;

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
		public _003CFetchRemote_003Ed__2(int _003C_003E1__state)
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

	private static List<string> remoteKeys;

	private static DependencyStatus dependencyStatus;

	[IteratorStateMachine(typeof(_003CFetchRemote_003Ed__2))]
	public static IEnumerator FetchRemote()
	{
		return null;
	}

	public static List<string> getRemoteKeys()
	{
		return null;
	}

	public static bool isRemoteConfig(string key)
	{
		return false;
	}

	public static int getRemoteValueInt(string key)
	{
		return 0;
	}

	public static float getRemoteValueFloat(string key)
	{
		return 0f;
	}

	public static string getRemoteValueStr(string key)
	{
		return null;
	}
}
