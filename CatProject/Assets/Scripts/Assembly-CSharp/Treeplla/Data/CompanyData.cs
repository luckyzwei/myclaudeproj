using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct CompanyData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Level { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Exp { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public bool Maxreward { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static CompanyData GetRootAsCompanyData(ByteBuffer _bb)
		{
			return GetRootAsCompanyData(_bb, new CompanyData());
		}

		public static CompanyData GetRootAsCompanyData(ByteBuffer _bb, CompanyData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public CompanyData __assign(int _i, ByteBuffer _bb)
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

		public ArraySegment<byte>? GetExpBytes()
		{
			return __p.__vector_as_arraysegment(8);
		}

		public byte[] GetExpArray()
		{
			return __p.__vector_as_array<byte>(8);
		}

		public bool MutateMaxreward(bool maxreward)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(maxreward ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<CompanyData> CreateCompanyData(FlatBufferBuilder builder, int idx = 0, int level = 0, StringOffset expOffset = default(StringOffset), bool maxreward = false)
		{
			builder.StartTable(4);
			AddMaxreward(builder, maxreward);
			AddExp(builder, expOffset);
			AddLevel(builder, level);
			AddIdx(builder, idx);
			return EndCompanyData(builder);
		}

		public static void StartCompanyData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(1, level, 0);
		}

		public static void AddExp(FlatBufferBuilder builder, StringOffset expOffset)
		{
			builder.AddOffset(2, expOffset.Value, 0);
		}

		public static void AddMaxreward(FlatBufferBuilder builder, bool maxreward)
		{
			builder.AddBool(3, maxreward, false);
		}

		public static Offset<CompanyData> EndCompanyData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<CompanyData>(o);
		}

		public CompanyDataT UnPack()
		{
			var _o = new CompanyDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(CompanyDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Level = this.Level;
			_o.Exp = this.Exp;
			_o.Maxreward = this.Maxreward;
		}

		public static Offset<CompanyData> Pack(FlatBufferBuilder builder, CompanyDataT _o)
		{
			if (_o == null) return default(Offset<CompanyData>);
			var _exp = _o.Exp == null ? default(StringOffset) : builder.CreateString(_o.Exp);
			StartCompanyData(builder);
			AddIdx(builder, _o.Idx);
			AddLevel(builder, _o.Level);
			AddExp(builder, _exp);
			AddMaxreward(builder, _o.Maxreward);
			return EndCompanyData(builder);
		}
	}
}
