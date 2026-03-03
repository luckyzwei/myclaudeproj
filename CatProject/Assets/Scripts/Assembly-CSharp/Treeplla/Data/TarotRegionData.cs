using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct TarotRegionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Tarotstarttype => 0;

		public long Tarotresettime => 0L;

		public int TarotcardlistLength => 0;

		public int TarotcardgetlistLength => 0;

		public static void ValidateVersion()
		{
		}

		public static TarotRegionData GetRootAsTarotRegionData(ByteBuffer _bb)
		{
			return default(TarotRegionData);
		}

		public static TarotRegionData GetRootAsTarotRegionData(ByteBuffer _bb, TarotRegionData obj)
		{
			return default(TarotRegionData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public TarotRegionData __assign(int _i, ByteBuffer _bb)
		{
			return default(TarotRegionData);
		}

		public bool MutateTarotstarttype(int tarotstarttype)
		{
			return false;
		}

		public bool MutateTarotresettime(long tarotresettime)
		{
			return false;
		}

		public int Tarotcardlist(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetTarotcardlistBytes()
		{
			return null;
		}

		public int[] GetTarotcardlistArray()
		{
			return null;
		}

		public bool MutateTarotcardlist(int j, int tarotcardlist)
		{
			return false;
		}

		public int Tarotcardgetlist(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetTarotcardgetlistBytes()
		{
			return null;
		}

		public int[] GetTarotcardgetlistArray()
		{
			return null;
		}

		public bool MutateTarotcardgetlist(int j, int tarotcardgetlist)
		{
			return false;
		}

		public static Offset<TarotRegionData> CreateTarotRegionData(FlatBufferBuilder builder, int tarotstarttype = 0, long tarotresettime = 0L, VectorOffset tarotcardlistOffset = default(VectorOffset), VectorOffset tarotcardgetlistOffset = default(VectorOffset))
		{
			return default(Offset<TarotRegionData>);
		}

		public static void StartTarotRegionData(FlatBufferBuilder builder)
		{
		}

		public static void AddTarotstarttype(FlatBufferBuilder builder, int tarotstarttype)
		{
		}

		public static void AddTarotresettime(FlatBufferBuilder builder, long tarotresettime)
		{
		}

		public static void AddTarotcardlist(FlatBufferBuilder builder, VectorOffset tarotcardlistOffset)
		{
		}

		public static VectorOffset CreateTarotcardlistVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTarotcardlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTarotcardlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTarotcardlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartTarotcardlistVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddTarotcardgetlist(FlatBufferBuilder builder, VectorOffset tarotcardgetlistOffset)
		{
		}

		public static VectorOffset CreateTarotcardgetlistVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTarotcardgetlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTarotcardgetlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTarotcardgetlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartTarotcardgetlistVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<TarotRegionData> EndTarotRegionData(FlatBufferBuilder builder)
		{
			return default(Offset<TarotRegionData>);
		}

		public TarotRegionDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(TarotRegionDataT _o)
		{
		}

		public static Offset<TarotRegionData> Pack(FlatBufferBuilder builder, TarotRegionDataT _o)
		{
			return default(Offset<TarotRegionData>);
		}
	}
}
