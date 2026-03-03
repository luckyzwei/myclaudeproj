using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RichRichAchieve : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Achievecount => 0;

		public int MissionreceivedidxsLength => 0;

		public int AchievereceivedidxsLength => 0;

		public static void ValidateVersion()
		{
		}

		public static RichRichAchieve GetRootAsRichRichAchieve(ByteBuffer _bb)
		{
			return default(RichRichAchieve);
		}

		public static RichRichAchieve GetRootAsRichRichAchieve(ByteBuffer _bb, RichRichAchieve obj)
		{
			return default(RichRichAchieve);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public RichRichAchieve __assign(int _i, ByteBuffer _bb)
		{
			return default(RichRichAchieve);
		}

		public bool MutateAchievecount(int achievecount)
		{
			return false;
		}

		public int Missionreceivedidxs(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetMissionreceivedidxsBytes()
		{
			return null;
		}

		public int[] GetMissionreceivedidxsArray()
		{
			return null;
		}

		public bool MutateMissionreceivedidxs(int j, int missionreceivedidxs)
		{
			return false;
		}

		public int Achievereceivedidxs(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetAchievereceivedidxsBytes()
		{
			return null;
		}

		public int[] GetAchievereceivedidxsArray()
		{
			return null;
		}

		public bool MutateAchievereceivedidxs(int j, int achievereceivedidxs)
		{
			return false;
		}

		public static Offset<RichRichAchieve> CreateRichRichAchieve(FlatBufferBuilder builder, int achievecount = 0, VectorOffset missionreceivedidxsOffset = default(VectorOffset), VectorOffset achievereceivedidxsOffset = default(VectorOffset))
		{
			return default(Offset<RichRichAchieve>);
		}

		public static void StartRichRichAchieve(FlatBufferBuilder builder)
		{
		}

		public static void AddAchievecount(FlatBufferBuilder builder, int achievecount)
		{
		}

		public static void AddMissionreceivedidxs(FlatBufferBuilder builder, VectorOffset missionreceivedidxsOffset)
		{
		}

		public static VectorOffset CreateMissionreceivedidxsVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionreceivedidxsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionreceivedidxsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionreceivedidxsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartMissionreceivedidxsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddAchievereceivedidxs(FlatBufferBuilder builder, VectorOffset achievereceivedidxsOffset)
		{
		}

		public static VectorOffset CreateAchievereceivedidxsVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAchievereceivedidxsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAchievereceivedidxsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAchievereceivedidxsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartAchievereceivedidxsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<RichRichAchieve> EndRichRichAchieve(FlatBufferBuilder builder)
		{
			return default(Offset<RichRichAchieve>);
		}

		public RichRichAchieveT UnPack()
		{
			return null;
		}

		public void UnPackTo(RichRichAchieveT _o)
		{
		}

		public static Offset<RichRichAchieve> Pack(FlatBufferBuilder builder, RichRichAchieveT _o)
		{
			return default(Offset<RichRichAchieve>);
		}
	}
}
