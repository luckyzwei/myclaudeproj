using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BizAcquisitionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Curstageidx => 0;

		public BizAcquisitionTeamData? Teamdata => null;

		public static void ValidateVersion()
		{
		}

		public static BizAcquisitionData GetRootAsBizAcquisitionData(ByteBuffer _bb)
		{
			return default(BizAcquisitionData);
		}

		public static BizAcquisitionData GetRootAsBizAcquisitionData(ByteBuffer _bb, BizAcquisitionData obj)
		{
			return default(BizAcquisitionData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public BizAcquisitionData __assign(int _i, ByteBuffer _bb)
		{
			return default(BizAcquisitionData);
		}

		public bool MutateCurstageidx(int curstageidx)
		{
			return false;
		}

		public static Offset<BizAcquisitionData> CreateBizAcquisitionData(FlatBufferBuilder builder, int curstageidx = 0, Offset<BizAcquisitionTeamData> teamdataOffset = default(Offset<BizAcquisitionTeamData>))
		{
			return default(Offset<BizAcquisitionData>);
		}

		public static void StartBizAcquisitionData(FlatBufferBuilder builder)
		{
		}

		public static void AddCurstageidx(FlatBufferBuilder builder, int curstageidx)
		{
		}

		public static void AddTeamdata(FlatBufferBuilder builder, Offset<BizAcquisitionTeamData> teamdataOffset)
		{
		}

		public static Offset<BizAcquisitionData> EndBizAcquisitionData(FlatBufferBuilder builder)
		{
			return default(Offset<BizAcquisitionData>);
		}

		public BizAcquisitionDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(BizAcquisitionDataT _o)
		{
		}

		public static Offset<BizAcquisitionData> Pack(FlatBufferBuilder builder, BizAcquisitionDataT _o)
		{
			return default(Offset<BizAcquisitionData>);
		}
	}
}
