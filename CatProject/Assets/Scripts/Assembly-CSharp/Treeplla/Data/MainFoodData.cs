using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct MainFoodData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Foodslotidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Resettime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static MainFoodData GetRootAsMainFoodData(ByteBuffer _bb)
		{
			return GetRootAsMainFoodData(_bb, new MainFoodData());
		}

		public static MainFoodData GetRootAsMainFoodData(ByteBuffer _bb, MainFoodData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public MainFoodData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateFoodslotidx(int foodslotidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, foodslotidx);
				return true;
			}
			return false;
		}

		public bool MutateResettime(long resettime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, resettime);
				return true;
			}
			return false;
		}

		public static Offset<MainFoodData> CreateMainFoodData(FlatBufferBuilder builder, int foodslotidx = 0, long resettime = 0L)
		{
			builder.StartTable(2);
			AddResettime(builder, resettime);
			AddFoodslotidx(builder, foodslotidx);
			return EndMainFoodData(builder);
		}

		public static void StartMainFoodData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddFoodslotidx(FlatBufferBuilder builder, int foodslotidx)
		{
			builder.AddInt(0, foodslotidx, 0);
		}

		public static void AddResettime(FlatBufferBuilder builder, long resettime)
		{
			builder.AddLong(1, resettime, 0);
		}

		public static Offset<MainFoodData> EndMainFoodData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<MainFoodData>(o);
		}

		public MainFoodDataT UnPack()
		{
			var _o = new MainFoodDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(MainFoodDataT _o)
		{
			_o.Foodslotidx = this.Foodslotidx;
			_o.Resettime = this.Resettime;
		}

		public static Offset<MainFoodData> Pack(FlatBufferBuilder builder, MainFoodDataT _o)
		{
			if (_o == null) return default(Offset<MainFoodData>);
			StartMainFoodData(builder);
			AddFoodslotidx(builder, _o.Foodslotidx);
			AddResettime(builder, _o.Resettime);
			return EndMainFoodData(builder);
		}
	}
}
