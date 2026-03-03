using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CompanyData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Idx => 0;

		public int Level => 0;

		public string Exp => null;

		public bool Maxreward => false;

		public static void ValidateVersion()
		{
		}

		public static CompanyData GetRootAsCompanyData(ByteBuffer _bb)
		{
			return default(CompanyData);
		}

		public static CompanyData GetRootAsCompanyData(ByteBuffer _bb, CompanyData obj)
		{
			return default(CompanyData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public CompanyData __assign(int _i, ByteBuffer _bb)
		{
			return default(CompanyData);
		}

		public bool MutateIdx(int idx)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public ArraySegment<byte>? GetExpBytes()
		{
			return null;
		}

		public byte[] GetExpArray()
		{
			return null;
		}

		public bool MutateMaxreward(bool maxreward)
		{
			return false;
		}

		public static Offset<CompanyData> CreateCompanyData(FlatBufferBuilder builder, int idx = 0, int level = 0, StringOffset expOffset = default(StringOffset), bool maxreward = false)
		{
			return default(Offset<CompanyData>);
		}

		public static void StartCompanyData(FlatBufferBuilder builder)
		{
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddExp(FlatBufferBuilder builder, StringOffset expOffset)
		{
		}

		public static void AddMaxreward(FlatBufferBuilder builder, bool maxreward)
		{
		}

		public static Offset<CompanyData> EndCompanyData(FlatBufferBuilder builder)
		{
			return default(Offset<CompanyData>);
		}

		public CompanyDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(CompanyDataT _o)
		{
		}

		public static Offset<CompanyData> Pack(FlatBufferBuilder builder, CompanyDataT _o)
		{
			return default(Offset<CompanyData>);
		}
	}
}
