using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct PackageOfferData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Offertype { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Offertime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static PackageOfferData GetRootAsPackageOfferData(ByteBuffer _bb)
		{
			return GetRootAsPackageOfferData(_bb, new PackageOfferData());
		}

		public static PackageOfferData GetRootAsPackageOfferData(ByteBuffer _bb, PackageOfferData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public PackageOfferData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateOffertype(int offertype)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, offertype);
				return true;
			}
			return false;
		}

		public bool MutateOffertime(long offertime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, offertime);
				return true;
			}
			return false;
		}

		public static Offset<PackageOfferData> CreatePackageOfferData(FlatBufferBuilder builder, int offertype = 0, long offertime = 0L)
		{
			builder.StartTable(2);
			AddOffertime(builder, offertime);
			AddOffertype(builder, offertype);
			return EndPackageOfferData(builder);
		}

		public static void StartPackageOfferData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddOffertype(FlatBufferBuilder builder, int offertype)
		{
			builder.AddInt(0, offertype, 0);
		}

		public static void AddOffertime(FlatBufferBuilder builder, long offertime)
		{
			builder.AddLong(1, offertime, 0);
		}

		public static Offset<PackageOfferData> EndPackageOfferData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<PackageOfferData>(o);
		}

		public PackageOfferDataT UnPack()
		{
			var _o = new PackageOfferDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(PackageOfferDataT _o)
		{
			_o.Offertype = this.Offertype;
			_o.Offertime = this.Offertime;
		}

		public static Offset<PackageOfferData> Pack(FlatBufferBuilder builder, PackageOfferDataT _o)
		{
			if (_o == null) return default(Offset<PackageOfferData>);
			StartPackageOfferData(builder);
			AddOffertype(builder, _o.Offertype);
			AddOffertime(builder, _o.Offertime);
			return EndPackageOfferData(builder);
		}
	}
}
