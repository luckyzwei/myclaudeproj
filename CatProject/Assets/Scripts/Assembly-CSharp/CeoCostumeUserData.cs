using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;

public class CeoCostumeUserData
{
	public int DefaultCostumeIdx { get; private set; }

	public int EquippedCostumeIdx { get; private set; }

	public Dictionary<int, CeoCostumeData> CostumeDataList { get; private set; }

	public CeoCostumeUserData()
	{
		CostumeDataList = new Dictionary<int, CeoCostumeData>();
	}

	public void ChangeEquippedCostumeIdx(int costumeIdx)
	{
		EquippedCostumeIdx = costumeIdx;
	}

	public void SetDefaultCostumeIdx(int costumeIdx)
	{
		DefaultCostumeIdx = costumeIdx;
	}

	public void AddCostumeData(int costumeIdx, bool isOwned, bool showRedDot)
	{
		if (CostumeDataList == null)
			CostumeDataList = new Dictionary<int, CeoCostumeData>();
		if (CostumeDataList.ContainsKey(costumeIdx))
		{
			var existing = CostumeDataList[costumeIdx];
			existing.SetOwned(isOwned);
			existing.SetShowRedDot(showRedDot);
		}
		else
		{
			CostumeDataList[costumeIdx] = new CeoCostumeData(costumeIdx, isOwned, showRedDot);
		}
	}

	public void SetShowRedDot(int costumeIdx, bool showRedDot)
	{
		if (CostumeDataList == null) return;
		if (CostumeDataList.TryGetValue(costumeIdx, out var data))
		{
			data.SetShowRedDot(showRedDot);
		}
	}

	public bool IsHasCostume(int costumeIdx)
	{
		if (CostumeDataList == null) return false;
		return CostumeDataList.ContainsKey(costumeIdx);
	}

	public bool IsShowRedDot(int costumeIdx)
	{
		if (CostumeDataList == null) return false;
		if (CostumeDataList.TryGetValue(costumeIdx, out var data))
		{
			return data.ShowRedDot;
		}
		return false;
	}

	public static CeoCostumeUserData FromFlatBuffer(CeoCostumeOwnedData? fbData)
	{
		if (!fbData.HasValue) return null;
		var d = fbData.Value;
		var result = new CeoCostumeUserData();
		result.ChangeEquippedCostumeIdx(d.Equippedcostumeidx);
		result.SetDefaultCostumeIdx(d.Defaultcostumeidx);
		for (int i = 0; i < d.OwnedcostumeidxlistLength; i++)
		{
			var fbCostume = d.Ownedcostumeidxlist(i);
			if (fbCostume.HasValue)
			{
				var costumeData = CeoCostumeData.FromFlatBuffer(fbCostume);
				if (costumeData != null)
					result.CostumeDataList[costumeData.CostumeIdx] = costumeData;
			}
		}
		return result;
	}

	public Offset<CeoCostumeOwnedData> ToFlatBuffer(FlatBufferBuilder builder, CeoCostumeUserData data)
	{
		if (data == null) return default(Offset<CeoCostumeOwnedData>);
		VectorOffset costumeVectorOffset = default(VectorOffset);
		if (data.CostumeDataList != null && data.CostumeDataList.Count > 0)
		{
			var offsets = new Offset<Treeplla.Data.CeoCostumeData>[data.CostumeDataList.Count];
			int i = 0;
			foreach (var kvp in data.CostumeDataList)
			{
				offsets[i++] = kvp.Value.ToFlatBuffer(builder);
			}
			costumeVectorOffset = CeoCostumeOwnedData.CreateOwnedcostumeidxlistVector(builder, offsets);
		}
		return CeoCostumeOwnedData.CreateCeoCostumeOwnedData(builder, data.DefaultCostumeIdx, data.EquippedCostumeIdx, costumeVectorOffset);
	}
}
