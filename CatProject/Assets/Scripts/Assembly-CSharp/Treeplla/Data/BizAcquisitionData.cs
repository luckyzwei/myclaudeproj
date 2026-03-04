using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BizAcquisitionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Curstageidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public BizAcquisitionTeamData? Teamdata { get { int o = __p.__offset(6); return o != 0 ? (new BizAcquisitionTeamData()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static BizAcquisitionData GetRootAsBizAcquisitionData(ByteBuffer _bb)
		{
			return GetRootAsBizAcquisitionData(_bb, new BizAcquisitionData());
		}

		public static BizAcquisitionData GetRootAsBizAcquisitionData(ByteBuffer _bb, BizAcquisitionData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public BizAcquisitionData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateCurstageidx(int curstageidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, curstageidx);
				return true;
			}
			return false;
		}

		public static Offset<BizAcquisitionData> CreateBizAcquisitionData(FlatBufferBuilder builder, int curstageidx = 0, Offset<BizAcquisitionTeamData> teamdataOffset = default(Offset<BizAcquisitionTeamData>))
		{
			builder.StartTable(2);
			AddTeamdata(builder, teamdataOffset);
			AddCurstageidx(builder, curstageidx);
			return EndBizAcquisitionData(builder);
		}

		public static void StartBizAcquisitionData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddCurstageidx(FlatBufferBuilder builder, int curstageidx)
		{
			builder.AddInt(0, curstageidx, 0);
		}

		public static void AddTeamdata(FlatBufferBuilder builder, Offset<BizAcquisitionTeamData> teamdataOffset)
		{
			builder.AddOffset(1, teamdataOffset.Value, 0);
		}

		public static Offset<BizAcquisitionData> EndBizAcquisitionData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<BizAcquisitionData>(o);
		}

		public BizAcquisitionDataT UnPack()
		{
			var _o = new BizAcquisitionDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(BizAcquisitionDataT _o)
		{
			_o.Curstageidx = this.Curstageidx;
			_o.Teamdata = this.Teamdata.HasValue ? this.Teamdata.Value.UnPack() : null;
		}

		public static Offset<BizAcquisitionData> Pack(FlatBufferBuilder builder, BizAcquisitionDataT _o)
		{
			if (_o == null) return default(Offset<BizAcquisitionData>);
			var _teamdata = _o.Teamdata == null ? default(Offset<BizAcquisitionTeamData>) : BizAcquisitionTeamData.Pack(builder, _o.Teamdata);
			StartBizAcquisitionData(builder);
			AddCurstageidx(builder, _o.Curstageidx);
			AddTeamdata(builder, _teamdata);
			return EndBizAcquisitionData(builder);
		}
	}
}
