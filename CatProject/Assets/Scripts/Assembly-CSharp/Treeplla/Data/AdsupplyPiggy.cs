using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AdsupplyPiggy : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Savecnt { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Collectmoney { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static AdsupplyPiggy GetRootAsAdsupplyPiggy(ByteBuffer _bb)
		{
			return GetRootAsAdsupplyPiggy(_bb, new AdsupplyPiggy());
		}

		public static AdsupplyPiggy GetRootAsAdsupplyPiggy(ByteBuffer _bb, AdsupplyPiggy obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public AdsupplyPiggy __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateSavecnt(int savecnt)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, savecnt);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetCollectmoneyBytes()
		{
			return __p.__vector_as_arraysegment(6);
		}

		public byte[] GetCollectmoneyArray()
		{
			return __p.__vector_as_array<byte>(6);
		}

		public static Offset<AdsupplyPiggy> CreateAdsupplyPiggy(FlatBufferBuilder builder, int savecnt = 0, StringOffset collectmoneyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			AddCollectmoney(builder, collectmoneyOffset);
			AddSavecnt(builder, savecnt);
			return EndAdsupplyPiggy(builder);
		}

		public static void StartAdsupplyPiggy(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddSavecnt(FlatBufferBuilder builder, int savecnt)
		{
			builder.AddInt(0, savecnt, 0);
		}

		public static void AddCollectmoney(FlatBufferBuilder builder, StringOffset collectmoneyOffset)
		{
			builder.AddOffset(1, collectmoneyOffset.Value, 0);
		}

		public static Offset<AdsupplyPiggy> EndAdsupplyPiggy(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<AdsupplyPiggy>(o);
		}

		public AdsupplyPiggyT UnPack()
		{
			var _o = new AdsupplyPiggyT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(AdsupplyPiggyT _o)
		{
			_o.Savecnt = this.Savecnt;
			_o.Collectmoney = this.Collectmoney;
		}

		public static Offset<AdsupplyPiggy> Pack(FlatBufferBuilder builder, AdsupplyPiggyT _o)
		{
			if (_o == null) return default(Offset<AdsupplyPiggy>);
			var _collectmoney = _o.Collectmoney == null ? default(StringOffset) : builder.CreateString(_o.Collectmoney);
			StartAdsupplyPiggy(builder);
			AddSavecnt(builder, _o.Savecnt);
			AddCollectmoney(builder, _collectmoney);
			return EndAdsupplyPiggy(builder);
		}
	}
}
