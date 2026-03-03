using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct MissionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Slot => 0;

		public int Order => 0;

		public string Value => null;

		public static void ValidateVersion()
		{
		}

		public static MissionData GetRootAsMissionData(ByteBuffer _bb)
		{
			return default(MissionData);
		}

		public static MissionData GetRootAsMissionData(ByteBuffer _bb, MissionData obj)
		{
			return default(MissionData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public MissionData __assign(int _i, ByteBuffer _bb)
		{
			return default(MissionData);
		}

		public bool MutateSlot(int slot)
		{
			return false;
		}

		public bool MutateOrder(int order)
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

		public static Offset<MissionData> CreateMissionData(FlatBufferBuilder builder, int slot = 0, int order = 0, StringOffset valueOffset = default(StringOffset))
		{
			return default(Offset<MissionData>);
		}

		public static void StartMissionData(FlatBufferBuilder builder)
		{
		}

		public static void AddSlot(FlatBufferBuilder builder, int slot)
		{
		}

		public static void AddOrder(FlatBufferBuilder builder, int order)
		{
		}

		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
		}

		public static Offset<MissionData> EndMissionData(FlatBufferBuilder builder)
		{
			return default(Offset<MissionData>);
		}

		public MissionDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(MissionDataT _o)
		{
		}

		public static Offset<MissionData> Pack(FlatBufferBuilder builder, MissionDataT _o)
		{
			return default(Offset<MissionData>);
		}
	}
}
