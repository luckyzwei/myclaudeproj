using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CeoCostumeData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Isowned { get { int o = __p.__offset(6); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Showreddot { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static CeoCostumeData GetRootAsCeoCostumeData(ByteBuffer _bb)
		{
			return GetRootAsCeoCostumeData(_bb, new CeoCostumeData());
		}

		public static CeoCostumeData GetRootAsCeoCostumeData(ByteBuffer _bb, CeoCostumeData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public CeoCostumeData __assign(int _i, ByteBuffer _bb)
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

		public bool MutateIsowned(bool isowned)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(isowned ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateShowreddot(bool showreddot)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(showreddot ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<CeoCostumeData> CreateCeoCostumeData(FlatBufferBuilder builder, int idx = 0, bool isowned = false, bool showreddot = false)
		{
			builder.StartTable(3);
			AddShowreddot(builder, showreddot);
			AddIsowned(builder, isowned);
			AddIdx(builder, idx);
			return EndCeoCostumeData(builder);
		}

		public static void StartCeoCostumeData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddIsowned(FlatBufferBuilder builder, bool isowned)
		{
			builder.AddBool(1, isowned, false);
		}

		public static void AddShowreddot(FlatBufferBuilder builder, bool showreddot)
		{
			builder.AddBool(2, showreddot, false);
		}

		public static Offset<CeoCostumeData> EndCeoCostumeData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<CeoCostumeData>(o);
		}

		public CeoCostumeDataT UnPack()
		{
			var _o = new CeoCostumeDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(CeoCostumeDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Isowned = this.Isowned;
			_o.Showreddot = this.Showreddot;
		}

		public static Offset<CeoCostumeData> Pack(FlatBufferBuilder builder, CeoCostumeDataT _o)
		{
			if (_o == null) return default(Offset<CeoCostumeData>);
			StartCeoCostumeData(builder);
			AddIdx(builder, _o.Idx);
			AddIsowned(builder, _o.Isowned);
			AddShowreddot(builder, _o.Showreddot);
			return EndCeoCostumeData(builder);
		}
	}
}
