using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Treeplla;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[UIPath("UI/Popup/PopupFreecash", false, false)]
public class PopupFreecash : UIBase
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGiveRewardIfLinked_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public PopupFreecash _003C_003E4__this;

		private UniTask<(FreecashIsLinkedResArg arg, UnityEngine.Networking.UnityWebRequest.Result ret)>.Awaiter _003C_003Eu__1;

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

	[SerializeField]
	private Text rewardGemText;

	[SerializeField]
	private Button freecashBtn;

	[SerializeField]
	private Button refreshBtn;

	private ShopSystem.InAppPurchaseLocation EnterPlace;

	protected override void Awake()
	{
		base.Awake();
		if (freecashBtn != null) freecashBtn.onClick.AddListener(OnClickFreecash);
		if (refreshBtn != null) refreshBtn.onClick.AddListener(OnClickRefresh);
	}

	public void Init(ShopSystem.InAppPurchaseLocation enterPlace)
	{
		EnterPlace = enterPlace;
	}

	[AsyncStateMachine(typeof(_003CGiveRewardIfLinked_003Ed__6))]
	private UniTask GiveRewardIfLinked()
	{
		return default(UniTask);
	}

	private void GrantReward()
	{
	}

	private void OnClickFreecash()
	{
	}

	private void OnClickRefresh()
	{
	}
}
