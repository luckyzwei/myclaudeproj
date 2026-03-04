using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct PackageData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Endtime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Buycount { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static PackageData GetRootAsPackageData(ByteBuffer _bb)
		{
			return GetRootAsPackageData(_bb, new PackageData());
		}

		public static PackageData GetRootAsPackageData(ByteBuffer _bb, PackageData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public PackageData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateIdx(int idx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, idx);
				return true;
			}
			return false;
		}

		public bool MutateEndtime(long endtime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, endtime);
				return true;
			}
			return false;
		}

		public bool MutateBuycount(int buycount)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, buycount);
				return true;
			}
			return false;
		}

		public static Offset<PackageData> CreatePackageData(FlatBufferBuilder builder, int idx = 0, long endtime = 0L, int buycount = 0)
		{
			builder.StartTable(3);
			AddBuycount(builder, buycount);
			AddEndtime(builder, endtime);
			AddIdx(builder, idx);
			return EndPackageData(builder);
		}

		public static void StartPackageData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddEndtime(FlatBufferBuilder builder, long endtime)
		{
			builder.AddLong(1, endtime, 0);
		}

		public static void AddBuycount(FlatBufferBuilder builder, int buycount)
		{
			builder.AddInt(2, buycount, 0);
		}

		public static Offset<PackageData> EndPackageData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<PackageData>(o);
		}

		public PackageDataT UnPack()
		{
			var _o = new PackageDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(PackageDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Endtime = this.Endtime;
			_o.Buycount = this.Buycount;
		}

		public static Offset<PackageData> Pack(FlatBufferBuilder builder, PackageDataT _o)
		{
			if (_o == null) return default(Offset<PackageData>);
			StartPackageData(builder);
			AddIdx(builder, _o.Idx);
			AddEndtime(builder, _o.Endtime);
			AddBuycount(builder, _o.Buycount);
			return EndPackageData(builder);
		}
	}
}
