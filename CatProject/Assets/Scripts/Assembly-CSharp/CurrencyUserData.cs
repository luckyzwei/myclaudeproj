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
		return result;
	}

	public static VectorOffset ToFlatBufferVector(FlatBufferBuilder builder, List<CurrencyUserData> dataList)
	{
		return default(VectorOffset);
	}

	private static Offset<CurrencyData> ToFlatBuffer(FlatBufferBuilder builder, CurrencyUserData data)
	{
		return default(Offset<CurrencyData>);
	}
}
