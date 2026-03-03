using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct UserCharData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public string Name => null;

		public string Companyname => null;

		public static void ValidateVersion()
		{
		}

		public static UserCharData GetRootAsUserCharData(ByteBuffer _bb)
		{
			return default(UserCharData);
		}

		public static UserCharData GetRootAsUserCharData(ByteBuffer _bb, UserCharData obj)
		{
			return default(UserCharData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public UserCharData __assign(int _i, ByteBuffer _bb)
		{
			return default(UserCharData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public ArraySegment<byte>? GetNameBytes()
		{
			return null;
		}

		public byte[] GetNameArray()
		{
			return null;
		}

		public ArraySegment<byte>? GetCompanynameBytes()
		{
			return null;
		}

		public byte[] GetCompanynameArray()
		{
			return null;
		}

		public static Offset<UserCharData> CreateUserCharData(FlatBufferBuilder builder, int idx = 0, StringOffset nameOffset = default(StringOffset), StringOffset companynameOffset = default(StringOffset))
		{
			return default(Offset<UserCharData>);
		}

		public static void StartUserCharData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
		}

		public static void AddCompanyname(FlatBufferBuilder builder, StringOffset companynameOffset)
		{
		}

		public static Offset<UserCharData> EndUserCharData(FlatBufferBuilder builder)
		{
			return default(Offset<UserCharData>);
		}

		public UserCharDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(UserCharDataT _o)
		{
		}

		public static Offset<UserCharData> Pack(FlatBufferBuilder builder, UserCharDataT _o)
		{
			return default(Offset<UserCharData>);
		}
	}
}
