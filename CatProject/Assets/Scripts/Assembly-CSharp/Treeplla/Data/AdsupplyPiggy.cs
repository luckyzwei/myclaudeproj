using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AdsupplyPiggy : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Savecnt => 0;

		public string Collectmoney => null;

		public static void ValidateVersion()
		{
		}

		public static AdsupplyPiggy GetRootAsAdsupplyPiggy(ByteBuffer _bb)
		{
			return default(AdsupplyPiggy);
		}

		public static AdsupplyPiggy GetRootAsAdsupplyPiggy(ByteBuffer _bb, AdsupplyPiggy obj)
		{
			return default(AdsupplyPiggy);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public AdsupplyPiggy __assign(int _i, ByteBuffer _bb)
		{
			return default(AdsupplyPiggy);
		}

		public bool MutateSavecnt(int savecnt)
		{
			return false;
		}

		public ArraySegment<byte>? GetCollectmoneyBytes()
		{
			return null;
		}

		public byte[] GetCollectmoneyArray()
		{
			return null;
		}

		public static Offset<AdsupplyPiggy> CreateAdsupplyPiggy(FlatBufferBuilder builder, int savecnt = 0, StringOffset collectmoneyOffset = default(StringOffset))
		{
			return default(Offset<AdsupplyPiggy>);
		}

		public static void StartAdsupplyPiggy(FlatBufferBuilder builder)
		{
		}

		public static void AddSavecnt(FlatBufferBuilder builder, int savecnt)
		{
		}

		public static void AddCollectmoney(FlatBufferBuilder builder, StringOffset collectmoneyOffset)
		{
		}

		public static Offset<AdsupplyPiggy> EndAdsupplyPiggy(FlatBufferBuilder builder)
		{
			return default(Offset<AdsupplyPiggy>);
		}

		public AdsupplyPiggyT UnPack()
		{
			return null;
		}

		public void UnPackTo(AdsupplyPiggyT _o)
		{
		}

		public static Offset<AdsupplyPiggy> Pack(FlatBufferBuilder builder, AdsupplyPiggyT _o)
		{
			return default(Offset<AdsupplyPiggy>);
		}
	}
}
