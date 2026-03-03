using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SlotData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Index => 0;

		public int Openslot => 0;

		public int Level => 0;

		public float Cooltime => 0f;

		public int Buffvalue => 0;

		public static void ValidateVersion()
		{
		}

		public static SlotData GetRootAsSlotData(ByteBuffer _bb)
		{
			return default(SlotData);
		}

		public static SlotData GetRootAsSlotData(ByteBuffer _bb, SlotData obj)
		{
			return default(SlotData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SlotData __assign(int _i, ByteBuffer _bb)
		{
			return default(SlotData);
		}

		public bool MutateIndex(int index)
		{
			return false;
		}

		public bool MutateOpenslot(int openslot)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public bool MutateCooltime(float cooltime)
		{
			return false;
		}

		public bool MutateBuffvalue(int buffvalue)
		{
			return false;
		}

		public static Offset<SlotData> CreateSlotData(FlatBufferBuilder builder, int index = -1, int openslot = 0, int level = 1, float cooltime = 0f, int buffvalue = 1)
		{
			return default(Offset<SlotData>);
		}

		public static void StartSlotData(FlatBufferBuilder builder)
		{
		}

		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
		}

		public static void AddOpenslot(FlatBufferBuilder builder, int openslot)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddCooltime(FlatBufferBuilder builder, float cooltime)
		{
		}

		public static void AddBuffvalue(FlatBufferBuilder builder, int buffvalue)
		{
		}

		public static Offset<SlotData> EndSlotData(FlatBufferBuilder builder)
		{
			return default(Offset<SlotData>);
		}

		public SlotDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SlotDataT _o)
		{
		}

		public static Offset<SlotData> Pack(FlatBufferBuilder builder, SlotDataT _o)
		{
			return default(Offset<SlotData>);
		}
	}
}
