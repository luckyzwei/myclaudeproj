using System.Collections.Generic;
using Google.FlatBuffers;
using Treeplla.Data;

public class CeoCostumeUserData
{
	public int DefaultCostumeIdx { get; private set; }

	public int EquippedCostumeIdx { get; private set; }

	public Dictionary<int, CeoCostumeData> CostumeDataList { get; private set; }

	public void ChangeEquippedCostumeIdx(int costumeIdx)
	{
	}

	public void SetDefaultCostumeIdx(int costumeIdx)
	{
	}

	public void AddCostumeData(int costumeIdx, bool isOwned, bool showRedDot)
	{
	}

	public void SetShowRedDot(int costumeIdx, bool showRedDot)
	{
	}

	public bool IsHasCostume(int costumeIdx)
	{
		return false;
	}

	public bool IsShowRedDot(int costumeIdx)
	{
		return false;
	}

	public static CeoCostumeUserData FromFlatBuffer(CeoCostumeOwnedData? fbData)
	{
		return null;
	}

	public Offset<CeoCostumeOwnedData> ToFlatBuffer(FlatBufferBuilder builder, CeoCostumeUserData data)
	{
		return default(Offset<CeoCostumeOwnedData>);
	}
}
