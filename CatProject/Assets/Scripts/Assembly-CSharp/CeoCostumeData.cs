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
		IsOwned = isOwned;
	}

	public void SetShowRedDot(bool showRedDot)
	{
		ShowRedDot = showRedDot;
	}

	public static CeoCostumeData FromFlatBuffer(Treeplla.Data.CeoCostumeData? fbData)
	{
		if (!fbData.HasValue) return null;
		var d = fbData.Value;
		return new CeoCostumeData(d.Idx, d.Isowned, d.Showreddot);
	}

	public Offset<Treeplla.Data.CeoCostumeData> ToFlatBuffer(FlatBufferBuilder builder)
	{
		return Treeplla.Data.CeoCostumeData.CreateCeoCostumeData(builder, CostumeIdx, IsOwned, ShowRedDot);
	}
}
