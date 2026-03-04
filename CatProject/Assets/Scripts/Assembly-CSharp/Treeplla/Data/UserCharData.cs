using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct UserCharData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public string Companyname { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static UserCharData GetRootAsUserCharData(ByteBuffer _bb)
		{
			return GetRootAsUserCharData(_bb, new UserCharData());
		}

		public static UserCharData GetRootAsUserCharData(ByteBuffer _bb, UserCharData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public UserCharData __assign(int _i, ByteBuffer _bb)
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

		public ArraySegment<byte>? GetNameBytes()
		{
			return __p.__vector_as_arraysegment(6);
		}

		public byte[] GetNameArray()
		{
			return __p.__vector_as_array<byte>(6);
		}

		public ArraySegment<byte>? GetCompanynameBytes()
		{
			return __p.__vector_as_arraysegment(8);
		}

		public byte[] GetCompanynameArray()
		{
			return __p.__vector_as_array<byte>(8);
		}

		public static Offset<UserCharData> CreateUserCharData(FlatBufferBuilder builder, int idx = 0, StringOffset nameOffset = default(StringOffset), StringOffset companynameOffset = default(StringOffset))
		{
			builder.StartTable(3);
			AddCompanyname(builder, companynameOffset);
			AddName(builder, nameOffset);
			AddIdx(builder, idx);
			return EndUserCharData(builder);
		}

		public static void StartUserCharData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		public static void AddCompanyname(FlatBufferBuilder builder, StringOffset companynameOffset)
		{
			builder.AddOffset(2, companynameOffset.Value, 0);
		}

		public static Offset<UserCharData> EndUserCharData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<UserCharData>(o);
		}

		public UserCharDataT UnPack()
		{
			var _o = new UserCharDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(UserCharDataT _o)
		{
			_o.Idx = this.Idx;
			_o.Name = this.Name;
			_o.Companyname = this.Companyname;
		}

		public static Offset<UserCharData> Pack(FlatBufferBuilder builder, UserCharDataT _o)
		{
			if (_o == null) return default(Offset<UserCharData>);
			var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
			var _companyname = _o.Companyname == null ? default(StringOffset) : builder.CreateString(_o.Companyname);
			StartUserCharData(builder);
			AddIdx(builder, _o.Idx);
			AddName(builder, _name);
			AddCompanyname(builder, _companyname);
			return EndUserCharData(builder);
		}
	}
}
