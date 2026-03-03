using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BuildingData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Lv => 0;

		public string Value => null;

		public int Time => 0;

		public static void ValidateVersion()
		{
		}

		public static BuildingData GetRootAsBuildingData(ByteBuffer _bb)
		{
			return default(BuildingData);
		}

		public static BuildingData GetRootAsBuildingData(ByteBuffer _bb, BuildingData obj)
		{
			return default(BuildingData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public BuildingData __assign(int _i, ByteBuffer _bb)
		{
			return default(BuildingData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateLv(int lv)
		{
			return false;
		}

		public ArraySegment<byte>? GetValueBytes()
		{
			return null;
		}

		public byte[] GetValueArray()
		{
			return null;
		}

		public bool MutateTime(int time)
		{
			return false;
		}

		public static Offset<BuildingData> CreateBuildingData(FlatBufferBuilder builder, int idx = 0, int lv = 0, StringOffset valueOffset = default(StringOffset), int time = 0)
		{
			return default(Offset<BuildingData>);
		}

		public static void StartBuildingData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddLv(FlatBufferBuilder builder, int lv)
		{
		}

		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
		}

		public static void AddTime(FlatBufferBuilder builder, int time)
		{
		}

		public static Offset<BuildingData> EndBuildingData(FlatBufferBuilder builder)
		{
			return default(Offset<BuildingData>);
		}

		public BuildingDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(BuildingDataT _o)
		{
		}

		public static Offset<BuildingData> Pack(FlatBufferBuilder builder, BuildingDataT _o)
		{
			return default(Offset<BuildingData>);
		}
	}
}
