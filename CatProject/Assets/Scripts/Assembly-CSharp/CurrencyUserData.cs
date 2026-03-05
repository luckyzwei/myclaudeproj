using System.Collections.Generic;
using System.Numerics;
using Google.FlatBuffers;
using Treeplla.Data;

public class CurrencyUserData
{
	public Config.CurrencyID CurrencyId;

	public BigInteger Value;

	public CurrencyUserData()
	{
	}

	public CurrencyUserData(Config.CurrencyID currencyId, BigInteger value)
	{
		CurrencyId = currencyId;
		Value = value;
	}

	public static CurrencyUserData FromFlatBuffer(CurrencyData data)
	{
		var result = new CurrencyUserData();
		result.CurrencyId = (Config.CurrencyID)data.Currencyid;
		if (!string.IsNullOrEmpty(data.Value))
			BigInteger.TryParse(data.Value, out result.Value);
		return result;
	}

	public static VectorOffset ToFlatBufferVector(FlatBufferBuilder builder, List<CurrencyUserData> dataList)
	{
		if (dataList == null || dataList.Count == 0)
			return default(VectorOffset);

		var offsets = new Offset<CurrencyData>[dataList.Count];
		for (int i = 0; i < dataList.Count; i++)
		{
			offsets[i] = ToFlatBuffer(builder, dataList[i]);
		}
		return builder.CreateVectorOfTables(offsets);
	}

	private static Offset<CurrencyData> ToFlatBuffer(FlatBufferBuilder builder, CurrencyUserData data)
	{
		var valueOffset = builder.CreateString(data.Value.ToString());
		return CurrencyData.CreateCurrencyData(builder, (int)data.CurrencyId, valueOffset);
	}
}
