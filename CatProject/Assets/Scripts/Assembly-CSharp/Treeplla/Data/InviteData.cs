using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct InviteData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int InviterewardLength => 0;

		public bool Invitegemreceive => false;

		public long Invitegemtime => 0L;

		public static void ValidateVersion()
		{
		}

		public static InviteData GetRootAsInviteData(ByteBuffer _bb)
		{
			return default(InviteData);
		}

		public static InviteData GetRootAsInviteData(ByteBuffer _bb, InviteData obj)
		{
			return default(InviteData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public InviteData __assign(int _i, ByteBuffer _bb)
		{
			return default(InviteData);
		}

		public int Invitereward(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetInviterewardBytes()
		{
			return null;
		}

		public int[] GetInviterewardArray()
		{
			return null;
		}

		public bool MutateInvitereward(int j, int invitereward)
		{
			return false;
		}

		public bool MutateInvitegemreceive(bool invitegemreceive)
		{
			return false;
		}

		public bool MutateInvitegemtime(long invitegemtime)
		{
			return false;
		}

		public static Offset<InviteData> CreateInviteData(FlatBufferBuilder builder, VectorOffset inviterewardOffset = default(VectorOffset), bool invitegemreceive = false, long invitegemtime = 0L)
		{
			return default(Offset<InviteData>);
		}

		public static void StartInviteData(FlatBufferBuilder builder)
		{
		}

		public static void AddInvitereward(FlatBufferBuilder builder, VectorOffset inviterewardOffset)
		{
		}

		public static VectorOffset CreateInviterewardVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateInviterewardVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateInviterewardVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateInviterewardVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartInviterewardVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddInvitegemreceive(FlatBufferBuilder builder, bool invitegemreceive)
		{
		}

		public static void AddInvitegemtime(FlatBufferBuilder builder, long invitegemtime)
		{
		}

		public static Offset<InviteData> EndInviteData(FlatBufferBuilder builder)
		{
			return default(Offset<InviteData>);
		}

		public InviteDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(InviteDataT _o)
		{
		}

		public static Offset<InviteData> Pack(FlatBufferBuilder builder, InviteDataT _o)
		{
			return default(Offset<InviteData>);
		}
	}
}
