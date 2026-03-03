using Google.FlatBuffers;
using Treeplla.Data;

public class CeoCostumeData
{
	public int CostumeIdx { get; private set; }

	public bool IsOwned { get; private set; }

	public bool ShowRedDot { get; private set; }

	public CeoCostumeData(int costumeIdx, bool isOwned, bool showRedDot)
	{
	}

	public void SetOwned(bool isOwned)
	{
	}

	public void SetShowRedDot(bool showRedDot)
	{
	}

	public static CeoCostumeData FromFlatBuffer(Treeplla.Data.CeoCostumeData? fbData)
	{
		return null;
	}

	public Offset<Treeplla.Data.CeoCostumeData> ToFlatBuffer(FlatBufferBuilder builder)
	{
		return default(Offset<Treeplla.Data.CeoCostumeData>);
	}
}
