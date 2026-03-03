using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CeoCostumeData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public bool Isowned => false;

		public bool Showreddot => false;

		public static void ValidateVersion()
		{
		}

		public static CeoCostumeData GetRootAsCeoCostumeData(ByteBuffer _bb)
		{
			return default(CeoCostumeData);
		}

		public static CeoCostumeData GetRootAsCeoCostumeData(ByteBuffer _bb, CeoCostumeData obj)
		{
			return default(CeoCostumeData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public CeoCostumeData __assign(int _i, ByteBuffer _bb)
		{
			return default(CeoCostumeData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateIsowned(bool isowned)
		{
			return false;
		}

		public bool MutateShowreddot(bool showreddot)
		{
			return false;
		}

		public static Offset<CeoCostumeData> CreateCeoCostumeData(FlatBufferBuilder builder, int idx = 0, bool isowned = false, bool showreddot = false)
		{
			return default(Offset<CeoCostumeData>);
		}

		public static void StartCeoCostumeData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddIsowned(FlatBufferBuilder builder, bool isowned)
		{
		}

		public static void AddShowreddot(FlatBufferBuilder builder, bool showreddot)
		{
		}

		public static Offset<CeoCostumeData> EndCeoCostumeData(FlatBufferBuilder builder)
		{
			return default(Offset<CeoCostumeData>);
		}

		public CeoCostumeDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(CeoCostumeDataT _o)
		{
		}

		public static Offset<CeoCostumeData> Pack(FlatBufferBuilder builder, CeoCostumeDataT _o)
		{
			return default(Offset<CeoCostumeData>);
		}
	}
}
