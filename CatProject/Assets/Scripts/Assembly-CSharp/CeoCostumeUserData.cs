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
		// Would create or update CeoCostumeData entry
	}

	public void SetShowRedDot(int costumeIdx, bool showRedDot)
	{
		if (CostumeDataList == null) return;
		if (CostumeDataList.TryGetValue(costumeIdx, out var data))
		{
			// Would set red dot flag on data
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
			// Would check red dot flag
		}
		return false;
	}

	public static CeoCostumeUserData FromFlatBuffer(CeoCostumeOwnedData? fbData)
	{
		if (!fbData.HasValue) return null;
		var d = fbData.Value;
		var result = new CeoCostumeUserData();
		result.ChangeEquippedCostumeIdx(d.EquippedCostumeIdx);
		result.SetDefaultCostumeIdx(d.DefaultCostumeIdx);
		return result;
	}

	public Offset<CeoCostumeOwnedData> ToFlatBuffer(FlatBufferBuilder builder, CeoCostumeUserData data)
	{
		if (data == null) return default(Offset<CeoCostumeOwnedData>);
		return CeoCostumeOwnedData.CreateCeoCostumeOwnedData(builder, data.DefaultCostumeIdx, data.EquippedCostumeIdx);
	}
}
