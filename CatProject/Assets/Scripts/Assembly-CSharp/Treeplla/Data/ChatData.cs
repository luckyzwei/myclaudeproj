using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ChatData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Group { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Curchat { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Curchatorder { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int CompletechatLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

		public bool Isnew { get { int o = __p.__offset(12); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int Nextgrouporder { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int WaitchatLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static ChatData GetRootAsChatData(ByteBuffer _bb)
		{
			return GetRootAsChatData(_bb, new ChatData());
		}

		public static ChatData GetRootAsChatData(ByteBuffer _bb, ChatData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public ChatData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateGroup(int group)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, group);
				return true;
			}
			return false;
		}

		public bool MutateCurchat(int curchat)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, curchat);
				return true;
			}
			return false;
		}

		public bool MutateCurchatorder(int curchatorder)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, curchatorder);
				return true;
			}
			return false;
		}

		public int Completechat(int j)
		{
			int o = __p.__offset(10);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetCompletechatBytes()
		{
			return __p.__vector_as_arraysegment(18);
		}

		public int[] GetCompletechatArray()
		{
			return null;
		}

		public bool MutateCompletechat(int j, int completechat)
		{
			return false;
		}

		public bool MutateIsnew(bool isnew)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isnew ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateNextgrouporder(int nextgrouporder)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, nextgrouporder);
				return true;
			}
			return false;
		}

		public int Waitchat(int j)
		{
			int o = __p.__offset(16);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetWaitchatBytes()
		{
			return __p.__vector_as_arraysegment(20);
		}

		public int[] GetWaitchatArray()
		{
			return null;
		}

		public bool MutateWaitchat(int j, int waitchat)
		{
			return false;
		}

		public static Offset<ChatData> CreateChatData(FlatBufferBuilder builder, int group = 0, int curchat = 0, int curchatorder = 0, VectorOffset completechatOffset = default(VectorOffset), bool isnew = false, int nextgrouporder = 0, VectorOffset waitchatOffset = default(VectorOffset))
		{
			builder.StartTable(7);
			AddWaitchat(builder, waitchatOffset);
			AddNextgrouporder(builder, nextgrouporder);
			AddIsnew(builder, isnew);
			AddCompletechat(builder, completechatOffset);
			AddCurchatorder(builder, curchatorder);
			AddCurchat(builder, curchat);
			AddGroup(builder, group);
			return EndChatData(builder);
		}

		public static void StartChatData(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		public static void AddGroup(FlatBufferBuilder builder, int group)
		{
			builder.AddInt(0, group, 0);
		}

		public static void AddCurchat(FlatBufferBuilder builder, int curchat)
		{
			builder.AddInt(1, curchat, 0);
		}

		public static void AddCurchatorder(FlatBufferBuilder builder, int curchatorder)
		{
			builder.AddInt(2, curchatorder, 0);
		}

		public static void AddCompletechat(FlatBufferBuilder builder, VectorOffset completechatOffset)
		{
			builder.AddOffset(3, completechatOffset.Value, 0);
		}

		public static VectorOffset CreateCompletechatVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCompletechatVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompletechatVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompletechatVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCompletechatVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddIsnew(FlatBufferBuilder builder, bool isnew)
		{
			builder.AddBool(4, isnew, false);
		}

		public static void AddNextgrouporder(FlatBufferBuilder builder, int nextgrouporder)
		{
			builder.AddInt(5, nextgrouporder, 0);
		}

		public static void AddWaitchat(FlatBufferBuilder builder, VectorOffset waitchatOffset)
		{
			builder.AddOffset(6, waitchatOffset.Value, 0);
		}

		public static VectorOffset CreateWaitchatVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateWaitchatVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateWaitchatVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateWaitchatVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartWaitchatVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<ChatData> EndChatData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<ChatData>(o);
		}

		public ChatDataT UnPack()
		{
			var _o = new ChatDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(ChatDataT _o)
		{
			_o.Group = this.Group;
			_o.Curchat = this.Curchat;
			_o.Curchatorder = this.Curchatorder;
			_o.Completechat = new List<int>();
			for (var _j = 0; _j < this.CompletechatLength; ++_j)
				_o.Completechat.Add(this.Completechat(_j));
			_o.Isnew = this.Isnew;
			_o.Nextgrouporder = this.Nextgrouporder;
			_o.Waitchat = new List<int>();
			for (var _j = 0; _j < this.WaitchatLength; ++_j)
				_o.Waitchat.Add(this.Waitchat(_j));
		}

		public static Offset<ChatData> Pack(FlatBufferBuilder builder, ChatDataT _o)
		{
			if (_o == null) return default(Offset<ChatData>);
			var _completechat = default(VectorOffset);
			if (_o.Completechat != null)
			{
				var __completechat = _o.Completechat.ToArray();
				_completechat = CreateCompletechatVector(builder, __completechat);
			}
			var _waitchat = default(VectorOffset);
			if (_o.Waitchat != null)
			{
				var __waitchat = _o.Waitchat.ToArray();
				_waitchat = CreateWaitchatVector(builder, __waitchat);
			}
			StartChatData(builder);
			AddGroup(builder, _o.Group);
			AddCurchat(builder, _o.Curchat);
			AddCurchatorder(builder, _o.Curchatorder);
			AddCompletechat(builder, _completechat);
			AddIsnew(builder, _o.Isnew);
			AddNextgrouporder(builder, _o.Nextgrouporder);
			AddWaitchat(builder, _waitchat);
			return EndChatData(builder);
		}
	}
}
