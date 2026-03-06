using System;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;
using UnityEngine;

public class UtilityInGame
{
	public static string GetChangePromiseString(string input, int quest_object_idx, BigInteger quest_object_value)
	{
		return null;
	}

	public static void GoodsGetEffect(Vector3 worldStartPos, Vector3 worldMiddlePos, Vector3 worldEndPos, int goodsType, int goodsIdx, string goodsCnt, Action OnEnd = null, float delay = 0f, string viewText = "")
	{
		OnEnd?.Invoke();
	}

	public static void PlayGoodsEffect(Vector3 startPos, int rewardType, int rewardIdx, BigInteger value, Action OnEnd = null, float delay = 0f, string viewText = "")
	{
		GoodsGetEffect(startPos, startPos, startPos, rewardType, rewardIdx, value.ToString(), OnEnd, delay, viewText);
	}

	public static void FoucusFacilityByIdx(int FacilityIdx)
	{
		var root = Treeplla.Singleton<GameRoot>.Instance;
		if (root == null || root.InGameSystem == null) return;
	}
}
