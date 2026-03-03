using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct TarotData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Tarotbasicticket => 0;

		public int Tarotspecialticket => 0;

		public int TarotrewardlistLength => 0;

		public int TarotregiondataLength => 0;

		public long Lastfreerefreshtime => 0L;

		public static void ValidateVersion()
		{
		}

		public static TarotData GetRootAsTarotData(ByteBuffer _bb)
		{
			return default(TarotData);
		}

		public static TarotData GetRootAsTarotData(ByteBuffer _bb, TarotData obj)
		{
			return default(TarotData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public TarotData __assign(int _i, ByteBuffer _bb)
		{
			return default(TarotData);
		}

		public bool MutateTarotbasicticket(int tarotbasicticket)
		{
			return false;
		}

		public bool MutateTarotspecialticket(int tarotspecialticket)
		{
			return false;
		}

		public int Tarotrewardlist(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetTarotrewardlistBytes()
		{
			return null;
		}

		public int[] GetTarotrewardlistArray()
		{
			return null;
		}

		public bool MutateTarotrewardlist(int j, int tarotrewardlist)
		{
			return false;
		}

		public TarotRegionData? Tarotregiondata(int j)
		{
			return null;
		}

		public bool MutateLastfreerefreshtime(long lastfreerefreshtime)
		{
			return false;
		}

		public static Offset<TarotData> CreateTarotData(FlatBufferBuilder builder, int tarotbasicticket = 0, int tarotspecialticket = 0, VectorOffset tarotrewardlistOffset = default(VectorOffset), VectorOffset tarotregiondataOffset = default(VectorOffset), long lastfreerefreshtime = 0L)
		{
			return default(Offset<TarotData>);
		}

		public static void StartTarotData(FlatBufferBuilder builder)
		{
		}

		public static void AddTarotbasicticket(FlatBufferBuilder builder, int tarotbasicticket)
		{
		}

		public static void AddTarotspecialticket(FlatBufferBuilder builder, int tarotspecialticket)
		{
		}

		public static void AddTarotrewardlist(FlatBufferBuilder builder, VectorOffset tarotrewardlistOffset)
		{
		}

		public static VectorOffset CreateTarotrewardlistVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTarotrewardlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTarotrewardlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTarotrewardlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartTarotrewardlistVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddTarotregiondata(FlatBufferBuilder builder, VectorOffset tarotregiondataOffset)
		{
		}

		public static VectorOffset CreateTarotregiondataVector(FlatBufferBuilder builder, Offset<TarotRegionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTarotregiondataVectorBlock(FlatBufferBuilder builder, Offset<TarotRegionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTarotregiondataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<TarotRegionData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTarotregiondataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartTarotregiondataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddLastfreerefreshtime(FlatBufferBuilder builder, long lastfreerefreshtime)
		{
		}

		public static Offset<TarotData> EndTarotData(FlatBufferBuilder builder)
		{
			return default(Offset<TarotData>);
		}

		public TarotDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(TarotDataT _o)
		{
		}

		public static Offset<TarotData> Pack(FlatBufferBuilder builder, TarotDataT _o)
		{
			return default(Offset<TarotData>);
		}
	}
}
