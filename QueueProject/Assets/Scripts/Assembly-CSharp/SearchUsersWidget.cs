using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Nakama;
using UnityEngine;
using UnityEngine.UI;

public class SearchUsersWidget : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSearchAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SearchUsersWidget _003C_003E4__this;

		private TaskAwaiter<List<IApiUser>> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private const int MINIMUM_REQUIRED_SEARCH_KEYWORD_LENGTH = 3;

	[Header("Searching")]
	[SerializeField]
	private InputField m_inputField;

	[SerializeField]
	private Button m_searchButton;

	[Header("Optional")]
	[TextLookup(null, true)]
	[SerializeField]
	private string m_playerIdFormat;

	[SerializeField]
	private Text m_playerIdText;

	[SerializeField]
	private GameObject m_searchResultPanel;

	[SerializeField]
	private GameObject m_searchResultContainer;

	[SerializeField]
	private UserCellWidget m_userCellWidgetPrefab;

	[SerializeField]
	private bool m_resetOnDisable;

	public event Action<List<IApiUser>> SearchCompleteCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action SearchFailedCallback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void SendSearchCompleteCallback(List<IApiUser> searchResults)
	{
	}

	private void SendSearchFailedCallback()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void TryUpdatePlayerIdText()
	{
	}

	private void OnSearchPressed()
	{
	}

	[AsyncStateMachine(typeof(_003CSearchAsync_003Ed__23))]
	private void SearchAsync()
	{
	}

	private void OnSearchComplete(List<IApiUser> searchResults)
	{
	}

	private void TryUpdateContainer(List<IApiUser> searchResults)
	{
	}

	private void ClearSearchContainer()
	{
	}

	private void FillSearchContainer(List<IApiUser> users)
	{
	}

	private UserCellWidget CreateCell()
	{
		return null;
	}
}
