using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AdsFreeViewData : IFlatbufferObject
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

		public static AdsFreeViewData GetRootAsAdsFreeViewData(ByteBuffer _bb)
		{
			return GetRootAsAdsFreeViewData(_bb, new AdsFreeViewData());
		}

		public static AdsFreeViewData GetRootAsAdsFreeViewData(ByteBuffer _bb, AdsFreeViewData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public AdsFreeViewData __assign(int _i, ByteBuffer _bb)
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

		public static Offset<AdsFreeViewData> CreateAdsFreeViewData(FlatBufferBuilder builder, int itemidx = 0, int viewcount = 0, long lastviewtime = 0L)
		{
			builder.StartTable(3);
			AddLastviewtime(builder, lastviewtime);
			AddViewcount(builder, viewcount);
			AddItemidx(builder, itemidx);
			return EndAdsFreeViewData(builder);
		}

		public static void StartAdsFreeViewData(FlatBufferBuilder builder)
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

		public static Offset<AdsFreeViewData> EndAdsFreeViewData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<AdsFreeViewData>(o);
		}

		public AdsFreeViewDataT UnPack()
		{
			var _o = new AdsFreeViewDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(AdsFreeViewDataT _o)
		{
			_o.Itemidx = this.Itemidx;
			_o.Viewcount = this.Viewcount;
			_o.Lastviewtime = this.Lastviewtime;
		}

		public static Offset<AdsFreeViewData> Pack(FlatBufferBuilder builder, AdsFreeViewDataT _o)
		{
			if (_o == null) return default(Offset<AdsFreeViewData>);
			StartAdsFreeViewData(builder);
			AddItemidx(builder, _o.Itemidx);
			AddViewcount(builder, _o.Viewcount);
			AddLastviewtime(builder, _o.Lastviewtime);
			return EndAdsFreeViewData(builder);
		}
	}
}
