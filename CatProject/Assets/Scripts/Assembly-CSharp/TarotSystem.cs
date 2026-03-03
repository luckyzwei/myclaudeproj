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
	}

	public void UpdateTarotOpen()
	{
	}

	private void InitDefineValue()
	{
	}

	public void SetRewardList()
	{
	}

	public void SetTarotResetTime()
	{
	}

	public void ShowTarotDirect()
	{
	}

	public int GetGemCount(int getCount)
	{
		return 0;
	}

	public bool GetRandomReward(int getCount, bool isSpecialTicket)
	{
		return false;
	}

	public bool CheckOwnReward(int tarotIdx)
	{
		return false;
	}

	public void SetCardReward(int idx)
	{
	}

	public void UpdateOneSeconds()
	{
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
