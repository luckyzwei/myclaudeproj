using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OfflineData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Totalofflinetime => 0;

		public string Totalofflinemoney => null;

		public bool Onstrike => false;

		public bool Notstrike => false;

		public static void ValidateVersion()
		{
		}

		public static OfflineData GetRootAsOfflineData(ByteBuffer _bb)
		{
			return default(OfflineData);
		}

		public static OfflineData GetRootAsOfflineData(ByteBuffer _bb, OfflineData obj)
		{
			return default(OfflineData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public OfflineData __assign(int _i, ByteBuffer _bb)
		{
			return default(OfflineData);
		}

		public bool MutateTotalofflinetime(int totalofflinetime)
		{
			return false;
		}

		public ArraySegment<byte>? GetTotalofflinemoneyBytes()
		{
			return null;
		}

		public byte[] GetTotalofflinemoneyArray()
		{
			return null;
		}

		public bool MutateOnstrike(bool onstrike)
		{
			return false;
		}

		public bool MutateNotstrike(bool notstrike)
		{
			return false;
		}

		public static Offset<OfflineData> CreateOfflineData(FlatBufferBuilder builder, int totalofflinetime = 0, StringOffset totalofflinemoneyOffset = default(StringOffset), bool onstrike = false, bool notstrike = false)
		{
			return default(Offset<OfflineData>);
		}

		public static void StartOfflineData(FlatBufferBuilder builder)
		{
		}

		public static void AddTotalofflinetime(FlatBufferBuilder builder, int totalofflinetime)
		{
		}

		public static void AddTotalofflinemoney(FlatBufferBuilder builder, StringOffset totalofflinemoneyOffset)
		{
		}

		public static void AddOnstrike(FlatBufferBuilder builder, bool onstrike)
		{
		}

		public static void AddNotstrike(FlatBufferBuilder builder, bool notstrike)
		{
		}

		public static Offset<OfflineData> EndOfflineData(FlatBufferBuilder builder)
		{
			return default(Offset<OfflineData>);
		}

		public OfflineDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(OfflineDataT _o)
		{
		}

		public static Offset<OfflineData> Pack(FlatBufferBuilder builder, OfflineDataT _o)
		{
			return default(Offset<OfflineData>);
		}
	}
}
