using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BizAcquisitionTeamData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int TeamceoidxlistLength => 0;

		public static void ValidateVersion()
		{
		}

		public static BizAcquisitionTeamData GetRootAsBizAcquisitionTeamData(ByteBuffer _bb)
		{
			return default(BizAcquisitionTeamData);
		}

		public static BizAcquisitionTeamData GetRootAsBizAcquisitionTeamData(ByteBuffer _bb, BizAcquisitionTeamData obj)
		{
			return default(BizAcquisitionTeamData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public BizAcquisitionTeamData __assign(int _i, ByteBuffer _bb)
		{
			return default(BizAcquisitionTeamData);
		}

		public int Teamceoidxlist(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetTeamceoidxlistBytes()
		{
			return null;
		}

		public int[] GetTeamceoidxlistArray()
		{
			return null;
		}

		public bool MutateTeamceoidxlist(int j, int teamceoidxlist)
		{
			return false;
		}

		public static Offset<BizAcquisitionTeamData> CreateBizAcquisitionTeamData(FlatBufferBuilder builder, VectorOffset teamceoidxlistOffset = default(VectorOffset))
		{
			return default(Offset<BizAcquisitionTeamData>);
		}

		public static void StartBizAcquisitionTeamData(FlatBufferBuilder builder)
		{
		}

		public static void AddTeamceoidxlist(FlatBufferBuilder builder, VectorOffset teamceoidxlistOffset)
		{
		}

		public static VectorOffset CreateTeamceoidxlistVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTeamceoidxlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTeamceoidxlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateTeamceoidxlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartTeamceoidxlistVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<BizAcquisitionTeamData> EndBizAcquisitionTeamData(FlatBufferBuilder builder)
		{
			return default(Offset<BizAcquisitionTeamData>);
		}

		public BizAcquisitionTeamDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(BizAcquisitionTeamDataT _o)
		{
		}

		public static Offset<BizAcquisitionTeamData> Pack(FlatBufferBuilder builder, BizAcquisitionTeamDataT _o)
		{
			return default(Offset<BizAcquisitionTeamData>);
		}
	}
}
