using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct InvestData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Selectcompany => 0;

		public string Rewardmoney => null;

		public long Refreshtime => 0L;

		public long Startttime => 0L;

		public int Multiplevalue => 0;

		public long Startinvesttime => 0L;

		public string Investmoney => null;

		public static void ValidateVersion()
		{
		}

		public static InvestData GetRootAsInvestData(ByteBuffer _bb)
		{
			return default(InvestData);
		}

		public static InvestData GetRootAsInvestData(ByteBuffer _bb, InvestData obj)
		{
			return default(InvestData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public InvestData __assign(int _i, ByteBuffer _bb)
		{
			return default(InvestData);
		}

		public bool MutateSelectcompany(int selectcompany)
		{
			return false;
		}

		public ArraySegment<byte>? GetRewardmoneyBytes()
		{
			return null;
		}

		public byte[] GetRewardmoneyArray()
		{
			return null;
		}

		public bool MutateRefreshtime(long refreshtime)
		{
			return false;
		}

		public bool MutateStartttime(long startttime)
		{
			return false;
		}

		public bool MutateMultiplevalue(int multiplevalue)
		{
			return false;
		}

		public bool MutateStartinvesttime(long startinvesttime)
		{
			return false;
		}

		public ArraySegment<byte>? GetInvestmoneyBytes()
		{
			return null;
		}

		public byte[] GetInvestmoneyArray()
		{
			return null;
		}

		public static Offset<InvestData> CreateInvestData(FlatBufferBuilder builder, int selectcompany = -1, StringOffset rewardmoneyOffset = default(StringOffset), long refreshtime = 0L, long startttime = 0L, int multiplevalue = -1, long startinvesttime = 0L, StringOffset investmoneyOffset = default(StringOffset))
		{
			return default(Offset<InvestData>);
		}

		public static void StartInvestData(FlatBufferBuilder builder)
		{
		}

		public static void AddSelectcompany(FlatBufferBuilder builder, int selectcompany)
		{
		}

		public static void AddRewardmoney(FlatBufferBuilder builder, StringOffset rewardmoneyOffset)
		{
		}

		public static void AddRefreshtime(FlatBufferBuilder builder, long refreshtime)
		{
		}

		public static void AddStartttime(FlatBufferBuilder builder, long startttime)
		{
		}

		public static void AddMultiplevalue(FlatBufferBuilder builder, int multiplevalue)
		{
		}

		public static void AddStartinvesttime(FlatBufferBuilder builder, long startinvesttime)
		{
		}

		public static void AddInvestmoney(FlatBufferBuilder builder, StringOffset investmoneyOffset)
		{
		}

		public static Offset<InvestData> EndInvestData(FlatBufferBuilder builder)
		{
			return default(Offset<InvestData>);
		}

		public InvestDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(InvestDataT _o)
		{
		}

		public static Offset<InvestData> Pack(FlatBufferBuilder builder, InvestDataT _o)
		{
			return default(Offset<InvestData>);
		}
	}
}
