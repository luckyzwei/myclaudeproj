using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AbilityData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Index => 0;

		public int Level => 0;

		public static void ValidateVersion()
		{
		}

		public static AbilityData GetRootAsAbilityData(ByteBuffer _bb)
		{
			return default(AbilityData);
		}

		public static AbilityData GetRootAsAbilityData(ByteBuffer _bb, AbilityData obj)
		{
			return default(AbilityData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public AbilityData __assign(int _i, ByteBuffer _bb)
		{
			return default(AbilityData);
		}

		public bool MutateIndex(int index)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public static Offset<AbilityData> CreateAbilityData(FlatBufferBuilder builder, int index = -1, int level = 0)
		{
			return default(Offset<AbilityData>);
		}

		public static void StartAbilityData(FlatBufferBuilder builder)
		{
		}

		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static Offset<AbilityData> EndAbilityData(FlatBufferBuilder builder)
		{
			return default(Offset<AbilityData>);
		}

		public AbilityDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(AbilityDataT _o)
		{
		}

		public static Offset<AbilityData> Pack(FlatBufferBuilder builder, AbilityDataT _o)
		{
			return default(Offset<AbilityData>);
		}
	}
}
