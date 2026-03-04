using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalUserData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Graphtype { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Finalscore { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Currentscore { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Name { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public string Profile { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public bool Me { get { int o = __p.__offset(14); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int Graphpower { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalUserData GetRootAsSeasonalUserData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalUserData(_bb, new SeasonalUserData());
		}

		public static SeasonalUserData GetRootAsSeasonalUserData(ByteBuffer _bb, SeasonalUserData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalUserData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateGraphtype(int graphtype)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, graphtype);
				return true;
			}
			return false;
		}

		public bool MutateFinalscore(int finalscore)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, finalscore);
				return true;
			}
			return false;
		}

		public bool MutateCurrentscore(int currentscore)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, currentscore);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetNameBytes()
		{
			return __p.__vector_as_arraysegment(10);
		}

		public byte[] GetNameArray()
		{
			return __p.__vector_as_array<byte>(10);
		}

		public ArraySegment<byte>? GetProfileBytes()
		{
			return __p.__vector_as_arraysegment(12);
		}

		public byte[] GetProfileArray()
		{
			return __p.__vector_as_array<byte>(12);
		}

		public bool MutateMe(bool me)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(me ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateGraphpower(int graphpower)
		{
			int o = __p.__offset(16);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, graphpower);
				return true;
			}
			return false;
		}

		public static Offset<SeasonalUserData> CreateSeasonalUserData(FlatBufferBuilder builder, int graphtype = 0, int finalscore = 0, int currentscore = 0, StringOffset nameOffset = default(StringOffset), StringOffset profileOffset = default(StringOffset), bool me = false, int graphpower = 0)
		{
			builder.StartTable(7);
			AddGraphpower(builder, graphpower);
			AddMe(builder, me);
			AddProfile(builder, profileOffset);
			AddName(builder, nameOffset);
			AddCurrentscore(builder, currentscore);
			AddFinalscore(builder, finalscore);
			AddGraphtype(builder, graphtype);
			return EndSeasonalUserData(builder);
		}

		public static void StartSeasonalUserData(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		public static void AddGraphtype(FlatBufferBuilder builder, int graphtype)
		{
			builder.AddInt(0, graphtype, 0);
		}

		public static void AddFinalscore(FlatBufferBuilder builder, int finalscore)
		{
			builder.AddInt(1, finalscore, 0);
		}

		public static void AddCurrentscore(FlatBufferBuilder builder, int currentscore)
		{
			builder.AddInt(2, currentscore, 0);
		}

		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(3, nameOffset.Value, 0);
		}

		public static void AddProfile(FlatBufferBuilder builder, StringOffset profileOffset)
		{
			builder.AddOffset(4, profileOffset.Value, 0);
		}

		public static void AddMe(FlatBufferBuilder builder, bool me)
		{
			builder.AddBool(5, me, false);
		}

		public static void AddGraphpower(FlatBufferBuilder builder, int graphpower)
		{
			builder.AddInt(6, graphpower, 0);
		}

		public static Offset<SeasonalUserData> EndSeasonalUserData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalUserData>(o);
		}

		public SeasonalUserDataT UnPack()
		{
			var _o = new SeasonalUserDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalUserDataT _o)
		{
			_o.Graphtype = this.Graphtype;
			_o.Finalscore = this.Finalscore;
			_o.Currentscore = this.Currentscore;
			_o.Name = this.Name;
			_o.Profile = this.Profile;
			_o.Me = this.Me;
			_o.Graphpower = this.Graphpower;
		}

		public static Offset<SeasonalUserData> Pack(FlatBufferBuilder builder, SeasonalUserDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalUserData>);
			var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
			var _profile = _o.Profile == null ? default(StringOffset) : builder.CreateString(_o.Profile);
			StartSeasonalUserData(builder);
			AddGraphtype(builder, _o.Graphtype);
			AddFinalscore(builder, _o.Finalscore);
			AddCurrentscore(builder, _o.Currentscore);
			AddName(builder, _name);
			AddProfile(builder, _profile);
			AddMe(builder, _o.Me);
			AddGraphpower(builder, _o.Graphpower);
			return EndSeasonalUserData(builder);
		}
	}
}
