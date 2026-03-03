using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SingleMissionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Slotidx => 0;

		public int Missionidx => 0;

		public string Currentvalue => null;

		public bool Iscomplete => false;

		public bool Isrewarded => false;

		public static void ValidateVersion()
		{
		}

		public static SingleMissionData GetRootAsSingleMissionData(ByteBuffer _bb)
		{
			return default(SingleMissionData);
		}

		public static SingleMissionData GetRootAsSingleMissionData(ByteBuffer _bb, SingleMissionData obj)
		{
			return default(SingleMissionData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SingleMissionData __assign(int _i, ByteBuffer _bb)
		{
			return default(SingleMissionData);
		}

		public bool MutateSlotidx(int slotidx)
		{
			return false;
		}

		public bool MutateMissionidx(int missionidx)
		{
			return false;
		}

		public ArraySegment<byte>? GetCurrentvalueBytes()
		{
			return null;
		}

		public byte[] GetCurrentvalueArray()
		{
			return null;
		}

		public bool MutateIscomplete(bool iscomplete)
		{
			return false;
		}

		public bool MutateIsrewarded(bool isrewarded)
		{
			return false;
		}

		public static Offset<SingleMissionData> CreateSingleMissionData(FlatBufferBuilder builder, int slotidx = 0, int missionidx = 0, StringOffset currentvalueOffset = default(StringOffset), bool iscomplete = false, bool isrewarded = false)
		{
			return default(Offset<SingleMissionData>);
		}

		public static void StartSingleMissionData(FlatBufferBuilder builder)
		{
		}

		public static void AddSlotidx(FlatBufferBuilder builder, int slotidx)
		{
		}

		public static void AddMissionidx(FlatBufferBuilder builder, int missionidx)
		{
		}

		public static void AddCurrentvalue(FlatBufferBuilder builder, StringOffset currentvalueOffset)
		{
		}

		public static void AddIscomplete(FlatBufferBuilder builder, bool iscomplete)
		{
		}

		public static void AddIsrewarded(FlatBufferBuilder builder, bool isrewarded)
		{
		}

		public static Offset<SingleMissionData> EndSingleMissionData(FlatBufferBuilder builder)
		{
			return default(Offset<SingleMissionData>);
		}

		public SingleMissionDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SingleMissionDataT _o)
		{
		}

		public static Offset<SingleMissionData> Pack(FlatBufferBuilder builder, SingleMissionDataT _o)
		{
			return default(Offset<SingleMissionData>);
		}
	}
}
