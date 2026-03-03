using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BizAcqTeamData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int TeamceoidxlistLength => 0;

		public static void ValidateVersion()
		{
		}

		public static BizAcqTeamData GetRootAsBizAcqTeamData(ByteBuffer _bb)
		{
			return default(BizAcqTeamData);
		}

		public static BizAcqTeamData GetRootAsBizAcqTeamData(ByteBuffer _bb, BizAcqTeamData obj)
		{
			return default(BizAcqTeamData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public BizAcqTeamData __assign(int _i, ByteBuffer _bb)
		{
			return default(BizAcqTeamData);
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

		public static Offset<BizAcqTeamData> CreateBizAcqTeamData(FlatBufferBuilder builder, VectorOffset teamceoidxlistOffset = default(VectorOffset))
		{
			return default(Offset<BizAcqTeamData>);
		}

		public static void StartBizAcqTeamData(FlatBufferBuilder builder)
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

		public static Offset<BizAcqTeamData> EndBizAcqTeamData(FlatBufferBuilder builder)
		{
			return default(Offset<BizAcqTeamData>);
		}

		public BizAcqTeamDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(BizAcqTeamDataT _o)
		{
		}

		public static Offset<BizAcqTeamData> Pack(FlatBufferBuilder builder, BizAcqTeamDataT _o)
		{
			return default(Offset<BizAcqTeamData>);
		}
	}
}
