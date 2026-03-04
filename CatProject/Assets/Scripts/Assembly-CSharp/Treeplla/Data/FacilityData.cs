using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct FacilityData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Index { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Speedlevel { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static FacilityData GetRootAsFacilityData(ByteBuffer _bb)
		{
			return GetRootAsFacilityData(_bb, new FacilityData());
		}

		public static FacilityData GetRootAsFacilityData(ByteBuffer _bb, FacilityData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public FacilityData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateIndex(int index)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, index);
				return true;
			}
			return false;
		}

		public bool MutateLevel(int level)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, level);
				return true;
			}
			return false;
		}

		public bool MutateSpeedlevel(int speedlevel)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, speedlevel);
				return true;
			}
			return false;
		}

		public static Offset<FacilityData> CreateFacilityData(FlatBufferBuilder builder, int index = 0, int level = 0, int speedlevel = 0)
		{
			builder.StartTable(3);
			AddSpeedlevel(builder, speedlevel);
			AddLevel(builder, level);
			AddIndex(builder, index);
			return EndFacilityData(builder);
		}

		public static void StartFacilityData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddIndex(FlatBufferBuilder builder, int index)
		{
			builder.AddInt(0, index, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		public static void AddSpeedlevel(FlatBufferBuilder builder, int speedlevel)
		{
			builder.AddInt(2, speedlevel, 0);
		}

		public static Offset<FacilityData> EndFacilityData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<FacilityData>(o);
		}

		public FacilityDataT UnPack()
		{
			var _o = new FacilityDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(FacilityDataT _o)
		{
			_o.Index = this.Index;
			_o.Level = this.Level;
			_o.Speedlevel = this.Speedlevel;
		}

		public static Offset<FacilityData> Pack(FlatBufferBuilder builder, FacilityDataT _o)
		{
			if (_o == null) return default(Offset<FacilityData>);
			StartFacilityData(builder);
			AddIndex(builder, _o.Index);
			AddLevel(builder, _o.Level);
			AddSpeedlevel(builder, _o.Speedlevel);
			return EndFacilityData(builder);
		}
	}
}
