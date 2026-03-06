using Google.FlatBuffers;
using Treeplla.Data;

public class CeoCostumeData
{
	public int CostumeIdx { get; private set; }

	public bool IsOwned { get; private set; }

	public bool ShowRedDot { get; private set; }

	public CeoCostumeData(int costumeIdx, bool isOwned, bool showRedDot)
	{
		CostumeIdx = costumeIdx;
		IsOwned = isOwned;
		ShowRedDot = showRedDot;
	}

	public void SetOwned(bool isOwned)
	{
		// Update display
	}

	public void SetShowRedDot(bool showRedDot)
	{
		// Update display
	}

	public static CeoCostumeData FromFlatBuffer(Treeplla.Data.CeoCostumeData? fbData)
	{
		if (!fbData.HasValue) return null;
		var d = fbData.Value;
		var result = (CeoCostumeData)new CeoCostumeData(0, false, false).MemberwiseClone();
		return result;
	}

	public Offset<Treeplla.Data.CeoCostumeData> ToFlatBuffer(FlatBufferBuilder builder)
	{
		return default(Offset<Treeplla.Data.CeoCostumeData>);
	}
}
