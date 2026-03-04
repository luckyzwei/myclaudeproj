using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AdsFreeItemData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Itemidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Viewcount { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Lastviewtime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static AdsFreeItemData GetRootAsAdsFreeItemData(ByteBuffer _bb)
		{
			return GetRootAsAdsFreeItemData(_bb, new AdsFreeItemData());
		}

		public static AdsFreeItemData GetRootAsAdsFreeItemData(ByteBuffer _bb, AdsFreeItemData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public AdsFreeItemData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateItemidx(int itemidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, itemidx);
				return true;
			}
			return false;
		}

		public bool MutateViewcount(int viewcount)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, viewcount);
				return true;
			}
			return false;
		}

		public bool MutateLastviewtime(long lastviewtime)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, lastviewtime);
				return true;
			}
			return false;
		}

		public static Offset<AdsFreeItemData> CreateAdsFreeItemData(FlatBufferBuilder builder, int itemidx = 0, int viewcount = 0, long lastviewtime = 0L)
		{
			builder.StartTable(3);
			AddLastviewtime(builder, lastviewtime);
			AddViewcount(builder, viewcount);
			AddItemidx(builder, itemidx);
			return EndAdsFreeItemData(builder);
		}

		public static void StartAdsFreeItemData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddItemidx(FlatBufferBuilder builder, int itemidx)
		{
			builder.AddInt(0, itemidx, 0);
		}

		public static void AddViewcount(FlatBufferBuilder builder, int viewcount)
		{
			builder.AddInt(1, viewcount, 0);
		}

		public static void AddLastviewtime(FlatBufferBuilder builder, long lastviewtime)
		{
			builder.AddLong(2, lastviewtime, 0);
		}

		public static Offset<AdsFreeItemData> EndAdsFreeItemData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<AdsFreeItemData>(o);
		}

		public AdsFreeItemDataT UnPack()
		{
			var _o = new AdsFreeItemDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(AdsFreeItemDataT _o)
		{
			_o.Itemidx = this.Itemidx;
			_o.Viewcount = this.Viewcount;
			_o.Lastviewtime = this.Lastviewtime;
		}

		public static Offset<AdsFreeItemData> Pack(FlatBufferBuilder builder, AdsFreeItemDataT _o)
		{
			if (_o == null) return default(Offset<AdsFreeItemData>);
			StartAdsFreeItemData(builder);
			AddItemidx(builder, _o.Itemidx);
			AddViewcount(builder, _o.Viewcount);
			AddLastviewtime(builder, _o.Lastviewtime);
			return EndAdsFreeItemData(builder);
		}
	}
}
