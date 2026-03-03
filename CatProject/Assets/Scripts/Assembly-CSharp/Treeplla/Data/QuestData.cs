using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct QuestData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Order => 0;

		public string Value => null;

		public bool Recevied => false;

		public static void ValidateVersion()
		{
		}

		public static QuestData GetRootAsQuestData(ByteBuffer _bb)
		{
			return default(QuestData);
		}

		public static QuestData GetRootAsQuestData(ByteBuffer _bb, QuestData obj)
		{
			return default(QuestData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public QuestData __assign(int _i, ByteBuffer _bb)
		{
			return default(QuestData);
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

		public bool MutateRecevied(bool recevied)
		{
			return false;
		}

		public static Offset<QuestData> CreateQuestData(FlatBufferBuilder builder, int order = 0, StringOffset valueOffset = default(StringOffset), bool recevied = false)
		{
			return default(Offset<QuestData>);
		}

		public static void StartQuestData(FlatBufferBuilder builder)
		{
		}

		public static void AddOrder(FlatBufferBuilder builder, int order)
		{
		}

		public static void AddValue(FlatBufferBuilder builder, StringOffset valueOffset)
		{
		}

		public static void AddRecevied(FlatBufferBuilder builder, bool recevied)
		{
		}

		public static Offset<QuestData> EndQuestData(FlatBufferBuilder builder)
		{
			return default(Offset<QuestData>);
		}

		public QuestDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(QuestDataT _o)
		{
		}

		public static Offset<QuestData> Pack(FlatBufferBuilder builder, QuestDataT _o)
		{
			return default(Offset<QuestData>);
		}
	}
}
