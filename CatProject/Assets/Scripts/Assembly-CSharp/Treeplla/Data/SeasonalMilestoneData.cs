using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalMilestoneData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public string Currencyaccumulationvalue => null;

		public int ReceivedrewardidxlistLength => 0;

		public float Milestonestepelapsedtimesec => 0f;

		public int ReceivedpreminumrewardidxlistLength => 0;

		public static void ValidateVersion()
		{
		}

		public static SeasonalMilestoneData GetRootAsSeasonalMilestoneData(ByteBuffer _bb)
		{
			return default(SeasonalMilestoneData);
		}

		public static SeasonalMilestoneData GetRootAsSeasonalMilestoneData(ByteBuffer _bb, SeasonalMilestoneData obj)
		{
			return default(SeasonalMilestoneData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalMilestoneData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalMilestoneData);
		}

		public ArraySegment<byte>? GetCurrencyaccumulationvalueBytes()
		{
			return null;
		}

		public byte[] GetCurrencyaccumulationvalueArray()
		{
			return null;
		}

		public int Receivedrewardidxlist(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetReceivedrewardidxlistBytes()
		{
			return null;
		}

		public int[] GetReceivedrewardidxlistArray()
		{
			return null;
		}

		public bool MutateReceivedrewardidxlist(int j, int receivedrewardidxlist)
		{
			return false;
		}

		public bool MutateMilestonestepelapsedtimesec(float milestonestepelapsedtimesec)
		{
			return false;
		}

		public int Receivedpreminumrewardidxlist(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetReceivedpreminumrewardidxlistBytes()
		{
			return null;
		}

		public int[] GetReceivedpreminumrewardidxlistArray()
		{
			return null;
		}

		public bool MutateReceivedpreminumrewardidxlist(int j, int receivedpreminumrewardidxlist)
		{
			return false;
		}

		public static Offset<SeasonalMilestoneData> CreateSeasonalMilestoneData(FlatBufferBuilder builder, StringOffset currencyaccumulationvalueOffset = default(StringOffset), VectorOffset receivedrewardidxlistOffset = default(VectorOffset), float milestonestepelapsedtimesec = 0f, VectorOffset receivedpreminumrewardidxlistOffset = default(VectorOffset))
		{
			return default(Offset<SeasonalMilestoneData>);
		}

		public static void StartSeasonalMilestoneData(FlatBufferBuilder builder)
		{
		}

		public static void AddCurrencyaccumulationvalue(FlatBufferBuilder builder, StringOffset currencyaccumulationvalueOffset)
		{
		}

		public static void AddReceivedrewardidxlist(FlatBufferBuilder builder, VectorOffset receivedrewardidxlistOffset)
		{
		}

		public static VectorOffset CreateReceivedrewardidxlistVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivedrewardidxlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivedrewardidxlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivedrewardidxlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartReceivedrewardidxlistVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddMilestonestepelapsedtimesec(FlatBufferBuilder builder, float milestonestepelapsedtimesec)
		{
		}

		public static void AddReceivedpreminumrewardidxlist(FlatBufferBuilder builder, VectorOffset receivedpreminumrewardidxlistOffset)
		{
		}

		public static VectorOffset CreateReceivedpreminumrewardidxlistVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivedpreminumrewardidxlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivedpreminumrewardidxlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateReceivedpreminumrewardidxlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartReceivedpreminumrewardidxlistVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<SeasonalMilestoneData> EndSeasonalMilestoneData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalMilestoneData>);
		}

		public SeasonalMilestoneDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalMilestoneDataT _o)
		{
		}

		public static Offset<SeasonalMilestoneData> Pack(FlatBufferBuilder builder, SeasonalMilestoneDataT _o)
		{
			return default(Offset<SeasonalMilestoneData>);
		}
	}
}
