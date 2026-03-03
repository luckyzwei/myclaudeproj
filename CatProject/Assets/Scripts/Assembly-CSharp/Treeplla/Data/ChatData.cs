using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct ChatData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Group => 0;

		public int Curchat => 0;

		public int Curchatorder => 0;

		public int CompletechatLength => 0;

		public bool Isnew => false;

		public int Nextgrouporder => 0;

		public int WaitchatLength => 0;

		public static void ValidateVersion()
		{
		}

		public static ChatData GetRootAsChatData(ByteBuffer _bb)
		{
			return default(ChatData);
		}

		public static ChatData GetRootAsChatData(ByteBuffer _bb, ChatData obj)
		{
			return default(ChatData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public ChatData __assign(int _i, ByteBuffer _bb)
		{
			return default(ChatData);
		}

		public bool MutateGroup(int group)
		{
			return false;
		}

		public bool MutateCurchat(int curchat)
		{
			return false;
		}

		public bool MutateCurchatorder(int curchatorder)
		{
			return false;
		}

		public int Completechat(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetCompletechatBytes()
		{
			return null;
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
			return false;
		}

		public bool MutateNextgrouporder(int nextgrouporder)
		{
			return false;
		}

		public int Waitchat(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetWaitchatBytes()
		{
			return null;
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
			return default(Offset<ChatData>);
		}

		public static void StartChatData(FlatBufferBuilder builder)
		{
		}

		public static void AddGroup(FlatBufferBuilder builder, int group)
		{
		}

		public static void AddCurchat(FlatBufferBuilder builder, int curchat)
		{
		}

		public static void AddCurchatorder(FlatBufferBuilder builder, int curchatorder)
		{
		}

		public static void AddCompletechat(FlatBufferBuilder builder, VectorOffset completechatOffset)
		{
		}

		public static VectorOffset CreateCompletechatVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompletechatVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompletechatVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateCompletechatVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartCompletechatVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddIsnew(FlatBufferBuilder builder, bool isnew)
		{
		}

		public static void AddNextgrouporder(FlatBufferBuilder builder, int nextgrouporder)
		{
		}

		public static void AddWaitchat(FlatBufferBuilder builder, VectorOffset waitchatOffset)
		{
		}

		public static VectorOffset CreateWaitchatVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateWaitchatVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateWaitchatVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateWaitchatVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartWaitchatVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<ChatData> EndChatData(FlatBufferBuilder builder)
		{
			return default(Offset<ChatData>);
		}

		public ChatDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(ChatDataT _o)
		{
		}

		public static Offset<ChatData> Pack(FlatBufferBuilder builder, ChatDataT _o)
		{
			return default(Offset<ChatData>);
		}
	}
}
