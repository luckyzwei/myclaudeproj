using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ContentsMissionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Contentstype => 0;

		public long Missionsettime => 0L;

		public int MissionsLength => 0;

		public bool Isrefreshed => false;

		public int Missiongroupidx => 0;

		public static void ValidateVersion()
		{
		}

		public static ContentsMissionData GetRootAsContentsMissionData(ByteBuffer _bb)
		{
			return default(ContentsMissionData);
		}

		public static ContentsMissionData GetRootAsContentsMissionData(ByteBuffer _bb, ContentsMissionData obj)
		{
			return default(ContentsMissionData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public ContentsMissionData __assign(int _i, ByteBuffer _bb)
		{
			return default(ContentsMissionData);
		}

		public bool MutateContentstype(int contentstype)
		{
			return false;
		}

		public bool MutateMissionsettime(long missionsettime)
		{
			return false;
		}

		public SingleMissionData? Missions(int j)
		{
			return null;
		}

		public bool MutateIsrefreshed(bool isrefreshed)
		{
			return false;
		}

		public bool MutateMissiongroupidx(int missiongroupidx)
		{
			return false;
		}

		public static Offset<ContentsMissionData> CreateContentsMissionData(FlatBufferBuilder builder, int contentstype = 0, long missionsettime = 0L, VectorOffset missionsOffset = default(VectorOffset), bool isrefreshed = false, int missiongroupidx = 0)
		{
			return default(Offset<ContentsMissionData>);
		}

		public static void StartContentsMissionData(FlatBufferBuilder builder)
		{
		}

		public static void AddContentstype(FlatBufferBuilder builder, int contentstype)
		{
		}

		public static void AddMissionsettime(FlatBufferBuilder builder, long missionsettime)
		{
		}

		public static void AddMissions(FlatBufferBuilder builder, VectorOffset missionsOffset)
		{
		}

		public static VectorOffset CreateMissionsVector(FlatBufferBuilder builder, Offset<SingleMissionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, Offset<SingleMissionData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SingleMissionData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateMissionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartMissionsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddIsrefreshed(FlatBufferBuilder builder, bool isrefreshed)
		{
		}

		public static void AddMissiongroupidx(FlatBufferBuilder builder, int missiongroupidx)
		{
		}

		public static Offset<ContentsMissionData> EndContentsMissionData(FlatBufferBuilder builder)
		{
			return default(Offset<ContentsMissionData>);
		}

		public ContentsMissionDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(ContentsMissionDataT _o)
		{
		}

		public static Offset<ContentsMissionData> Pack(FlatBufferBuilder builder, ContentsMissionDataT _o)
		{
			return default(Offset<ContentsMissionData>);
		}
	}
}
