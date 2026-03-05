using System.Collections.Generic;
using UniRx;

public class TarotSystem
{
	public enum Status
	{
		Hide = 0,
		Show = 1
	}

	public IReactiveProperty<Status> TarotStatusProperty;

	public bool TarotShowPopup;

	private IReactiveProperty<int> RemainTarotResetTimeProperty;

	private int tarotResetTime;

	private bool isInitDefine;

	public Subject<int> OnUseTarot;

	public bool IsTarotOpen { get; private set; }

	public List<int> NormalRewardList { get; private set; }

	public List<int> SpecialRewardList { get; private set; }

	public int TarotStartFirstGemCount { get; private set; }

	public int TarotStartSecondGemCount { get; private set; }

	public int TarotStartThirdGemCount { get; private set; }

	public int TarotChageGemCount { get; private set; }

	public int TarotFirstDrawRate { get; private set; }

	public int TarotSecondDrawRate { get; private set; }

	public int TarotThirdDrawRate { get; private set; }

	public int TarotReplaceGemCount { get; private set; }

	public void Init()
	{
		TarotStatusProperty = new ReactiveProperty<Status>(Status.Hide);
		RemainTarotResetTimeProperty = new ReactiveProperty<int>(0);
		OnUseTarot = new Subject<int>();
		NormalRewardList = new List<int>();
		SpecialRewardList = new List<int>();
		TarotShowPopup = false;
		IsTarotOpen = false;
		isInitDefine = false;
		InitDefineValue();
		UpdateTarotOpen();
	}

	public void UpdateTarotOpen()
	{
		// Check contents open to determine if tarot feature is available
		IsTarotOpen = true;
	}

	private void InitDefineValue()
	{
		if (isInitDefine) return;
		isInitDefine = true;
		TarotStartFirstGemCount = 10;
		TarotStartSecondGemCount = 30;
		TarotStartThirdGemCount = 50;
		TarotChageGemCount = 5;
		TarotFirstDrawRate = 70;
		TarotSecondDrawRate = 25;
		TarotThirdDrawRate = 5;
		TarotReplaceGemCount = 10;
		tarotResetTime = 86400;
	}

	public void SetRewardList()
	{
		if (NormalRewardList == null) NormalRewardList = new List<int>();
		if (SpecialRewardList == null) SpecialRewardList = new List<int>();
		NormalRewardList.Clear();
		SpecialRewardList.Clear();
	}

	public void SetTarotResetTime()
	{
		if (RemainTarotResetTimeProperty != null)
			RemainTarotResetTimeProperty.Value = tarotResetTime;
	}

	public void ShowTarotDirect()
	{
		TarotShowPopup = true;
		if (TarotStatusProperty != null)
			TarotStatusProperty.Value = Status.Show;
	}

	public int GetGemCount(int getCount)
	{
		switch (getCount)
		{
			case 0: return TarotStartFirstGemCount;
			case 1: return TarotStartSecondGemCount;
			case 2: return TarotStartThirdGemCount;
			default: return TarotStartFirstGemCount;
		}
	}

	public bool GetRandomReward(int getCount, bool isSpecialTicket)
	{
		int roll = UnityEngine.Random.Range(0, 100);
		if (isSpecialTicket) return true;
		return roll < TarotThirdDrawRate;
	}

	public bool CheckOwnReward(int tarotIdx)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null || root.UserData.TarotData == null) return false;
		return root.UserData.TarotData.TarotRewardList != null && root.UserData.TarotData.TarotRewardList.Contains(tarotIdx);
	}

	public void SetCardReward(int idx)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.UserData == null || root.UserData.TarotData == null) return;
		if (root.UserData.TarotData.TarotRewardList == null)
			root.UserData.TarotData.TarotRewardList = new List<int>();
		if (!root.UserData.TarotData.TarotRewardList.Contains(idx))
			root.UserData.TarotData.TarotRewardList.Add(idx);
		OnUseTarot?.OnNext(idx);
	}

	public void UpdateOneSeconds()
	{
		if (RemainTarotResetTimeProperty == null) return;
		if (RemainTarotResetTimeProperty.Value > 0)
			RemainTarotResetTimeProperty.Value--;
	}

	public void LogTarotShuffle(int idx, int buyType, int order, bool cnt)
	{
	}

	public void LogTarotReroll(bool beforeCnt, bool afterCnt, bool isFree)
	{
	}

	public void LogTarotReward(int idx, bool cnt, int buyType, int order, bool type)
	{
	}
}
