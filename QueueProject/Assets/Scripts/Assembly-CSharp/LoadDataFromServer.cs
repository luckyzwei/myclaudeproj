using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

[RequireComponent(typeof(DataSheetAnalytics))]
public abstract class LoadDataFromServer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDownloadFile_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadDataFromServer _003C_003E4__this;

		public string version;

		private UnityWebRequest _003Cwww_003E5__2;

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
		public _003CDownloadFile_003Ed__20(int _003C_003E1__state)
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
	private string m_url;

	[SerializeField]
	private string m_system;

	[SerializeField]
	private DataSheetAnalytics m_analytics;

	private Action<Hashtable> m_callback;

	private string m_requiredVersion;

	private int m_time;

	private bool m_downloading;

	protected virtual void OnValidate()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	private void OutOfTime()
	{
	}

	private string GetFileName(string version = null)
	{
		return null;
	}

	protected abstract void Init();

	protected abstract DataSheetSettings GetDataSheetSettings();

	protected abstract void DataLoaded(Hashtable data);

	private void LoadFromGameSetting()
	{
	}

	private void LoadFromLocalStorage()
	{
	}

	private void LoadJson(string json)
	{
	}

	private void LoadFromServer(string version)
	{
	}

	[IteratorStateMachine(typeof(_003CDownloadFile_003Ed__20))]
	private IEnumerator DownloadFile(string version)
	{
		return null;
	}

	private void Fail(string fail)
	{
	}
}
