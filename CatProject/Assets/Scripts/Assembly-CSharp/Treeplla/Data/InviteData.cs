using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct InviteData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int InviterewardLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

		public bool Invitegemreceive { get { int o = __p.__offset(6); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public long Invitegemtime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static InviteData GetRootAsInviteData(ByteBuffer _bb)
		{
			return GetRootAsInviteData(_bb, new InviteData());
		}

		public static InviteData GetRootAsInviteData(ByteBuffer _bb, InviteData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public InviteData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public int Invitereward(int j)
		{
			int o = __p.__offset(4);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetInviterewardBytes()
		{
			return __p.__vector_as_arraysegment(10);
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
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(invitegemreceive ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateInvitegemtime(long invitegemtime)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, invitegemtime);
				return true;
			}
			return false;
		}

		public static Offset<InviteData> CreateInviteData(FlatBufferBuilder builder, VectorOffset inviterewardOffset = default(VectorOffset), bool invitegemreceive = false, long invitegemtime = 0L)
		{
			builder.StartTable(3);
			AddInvitegemtime(builder, invitegemtime);
			AddInvitegemreceive(builder, invitegemreceive);
			AddInvitereward(builder, inviterewardOffset);
			return EndInviteData(builder);
		}

		public static void StartInviteData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		public static void AddInvitereward(FlatBufferBuilder builder, VectorOffset inviterewardOffset)
		{
			builder.AddOffset(0, inviterewardOffset.Value, 0);
		}

		public static VectorOffset CreateInviterewardVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateInviterewardVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateInviterewardVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateInviterewardVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartInviterewardVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddInvitegemreceive(FlatBufferBuilder builder, bool invitegemreceive)
		{
			builder.AddBool(1, invitegemreceive, false);
		}

		public static void AddInvitegemtime(FlatBufferBuilder builder, long invitegemtime)
		{
			builder.AddLong(2, invitegemtime, 0);
		}

		public static Offset<InviteData> EndInviteData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<InviteData>(o);
		}

		public InviteDataT UnPack()
		{
			var _o = new InviteDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(InviteDataT _o)
		{
			_o.Invitereward = new List<int>();
			for (var _j = 0; _j < this.InviterewardLength; ++_j)
				_o.Invitereward.Add(this.Invitereward(_j));
			_o.Invitegemreceive = this.Invitegemreceive;
			_o.Invitegemtime = this.Invitegemtime;
		}

		public static Offset<InviteData> Pack(FlatBufferBuilder builder, InviteDataT _o)
		{
			if (_o == null) return default(Offset<InviteData>);
			var _invitereward = default(VectorOffset);
			if (_o.Invitereward != null)
			{
				var __invitereward = _o.Invitereward.ToArray();
				_invitereward = CreateInviterewardVector(builder, __invitereward);
			}
			StartInviteData(builder);
			AddInvitereward(builder, _invitereward);
			AddInvitegemreceive(builder, _o.Invitegemreceive);
			AddInvitegemtime(builder, _o.Invitegemtime);
			return EndInviteData(builder);
		}
	}
}
