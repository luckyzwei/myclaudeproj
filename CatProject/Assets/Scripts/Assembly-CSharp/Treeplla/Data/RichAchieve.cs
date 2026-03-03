using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct RichAchieve : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int MissionreceivedidxsLength => 0;

		public int AchievereceivedidxsLength => 0;

		public bool Isguideshow => false;

		public bool Ispageinfoshow => false;

		public static void ValidateVersion()
		{
		}

		public static RichAchieve GetRootAsRichAchieve(ByteBuffer _bb)
		{
			return default(RichAchieve);
		}

		public static RichAchieve GetRootAsRichAchieve(ByteBuffer _bb, RichAchieve obj)
		{
			return default(RichAchieve);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public RichAchieve __assign(int _i, ByteBuffer _bb)
		{
			return default(RichAchieve);
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

		public bool MutateIsguideshow(bool isguideshow)
		{
			return false;
		}

		public bool MutateIspageinfoshow(bool ispageinfoshow)
		{
			return false;
		}

		public static Offset<RichAchieve> CreateRichAchieve(FlatBufferBuilder builder, VectorOffset missionreceivedidxsOffset = default(VectorOffset), VectorOffset achievereceivedidxsOffset = default(VectorOffset), bool isguideshow = false, bool ispageinfoshow = false)
		{
			return default(Offset<RichAchieve>);
		}

		public static void StartRichAchieve(FlatBufferBuilder builder)
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

		public static void AddIsguideshow(FlatBufferBuilder builder, bool isguideshow)
		{
		}

		public static void AddIspageinfoshow(FlatBufferBuilder builder, bool ispageinfoshow)
		{
		}

		public static Offset<RichAchieve> EndRichAchieve(FlatBufferBuilder builder)
		{
			return default(Offset<RichAchieve>);
		}

		public RichAchieveT UnPack()
		{
			return null;
		}

		public void UnPackTo(RichAchieveT _o)
		{
		}

		public static Offset<RichAchieve> Pack(FlatBufferBuilder builder, RichAchieveT _o)
		{
			return default(Offset<RichAchieve>);
		}
	}
}
