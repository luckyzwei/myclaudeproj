using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OpenSlotAdData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Reward => 0;

		public long Opentime => 0L;

		public int OpentimedictkeyLength => 0;

		public int OpentimedictvalueLength => 0;

		public static void ValidateVersion()
		{
		}

		public static OpenSlotAdData GetRootAsOpenSlotAdData(ByteBuffer _bb)
		{
			return default(OpenSlotAdData);
		}

		public static OpenSlotAdData GetRootAsOpenSlotAdData(ByteBuffer _bb, OpenSlotAdData obj)
		{
			return default(OpenSlotAdData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public OpenSlotAdData __assign(int _i, ByteBuffer _bb)
		{
			return default(OpenSlotAdData);
		}

		public bool MutateReward(int reward)
		{
			return false;
		}

		public bool MutateOpentime(long opentime)
		{
			return false;
		}

		public int Opentimedictkey(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetOpentimedictkeyBytes()
		{
			return null;
		}

		public int[] GetOpentimedictkeyArray()
		{
			return null;
		}

		public bool MutateOpentimedictkey(int j, int opentimedictkey)
		{
			return false;
		}

		public long Opentimedictvalue(int j)
		{
			return 0L;
		}

		public ArraySegment<byte>? GetOpentimedictvalueBytes()
		{
			return null;
		}

		public long[] GetOpentimedictvalueArray()
		{
			return null;
		}

		public bool MutateOpentimedictvalue(int j, long opentimedictvalue)
		{
			return false;
		}

		public static Offset<OpenSlotAdData> CreateOpenSlotAdData(FlatBufferBuilder builder, int reward = 0, long opentime = 0L, VectorOffset opentimedictkeyOffset = default(VectorOffset), VectorOffset opentimedictvalueOffset = default(VectorOffset))
		{
			return default(Offset<OpenSlotAdData>);
		}

		public static void StartOpenSlotAdData(FlatBufferBuilder builder)
		{
		}

		public static void AddReward(FlatBufferBuilder builder, int reward)
		{
		}

		public static void AddOpentime(FlatBufferBuilder builder, long opentime)
		{
		}

		public static void AddOpentimedictkey(FlatBufferBuilder builder, VectorOffset opentimedictkeyOffset)
		{
		}

		public static VectorOffset CreateOpentimedictkeyVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOpentimedictkeyVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOpentimedictkeyVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOpentimedictkeyVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartOpentimedictkeyVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddOpentimedictvalue(FlatBufferBuilder builder, VectorOffset opentimedictvalueOffset)
		{
		}

		public static VectorOffset CreateOpentimedictvalueVector(FlatBufferBuilder builder, long[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOpentimedictvalueVectorBlock(FlatBufferBuilder builder, long[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOpentimedictvalueVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOpentimedictvalueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartOpentimedictvalueVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<OpenSlotAdData> EndOpenSlotAdData(FlatBufferBuilder builder)
		{
			return default(Offset<OpenSlotAdData>);
		}

		public OpenSlotAdDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(OpenSlotAdDataT _o)
		{
		}

		public static Offset<OpenSlotAdData> Pack(FlatBufferBuilder builder, OpenSlotAdDataT _o)
		{
			return default(Offset<OpenSlotAdData>);
		}
	}
}
