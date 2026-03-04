using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OfflineData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Totalofflinetime { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public string Totalofflinemoney { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public bool Onstrike { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Notstrike { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static OfflineData GetRootAsOfflineData(ByteBuffer _bb)
		{
			return GetRootAsOfflineData(_bb, new OfflineData());
		}

		public static OfflineData GetRootAsOfflineData(ByteBuffer _bb, OfflineData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public OfflineData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateTotalofflinetime(int totalofflinetime)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, totalofflinetime);
				return true;
			}
			return false;
		}

		public ArraySegment<byte>? GetTotalofflinemoneyBytes()
		{
			return __p.__vector_as_arraysegment(6);
		}

		public byte[] GetTotalofflinemoneyArray()
		{
			return __p.__vector_as_array<byte>(6);
		}

		public bool MutateOnstrike(bool onstrike)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(onstrike ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateNotstrike(bool notstrike)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(notstrike ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<OfflineData> CreateOfflineData(FlatBufferBuilder builder, int totalofflinetime = 0, StringOffset totalofflinemoneyOffset = default(StringOffset), bool onstrike = false, bool notstrike = false)
		{
			builder.StartTable(4);
			AddNotstrike(builder, notstrike);
			AddOnstrike(builder, onstrike);
			AddTotalofflinemoney(builder, totalofflinemoneyOffset);
			AddTotalofflinetime(builder, totalofflinetime);
			return EndOfflineData(builder);
		}

		public static void StartOfflineData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		public static void AddTotalofflinetime(FlatBufferBuilder builder, int totalofflinetime)
		{
			builder.AddInt(0, totalofflinetime, 0);
		}

		public static void AddTotalofflinemoney(FlatBufferBuilder builder, StringOffset totalofflinemoneyOffset)
		{
			builder.AddOffset(1, totalofflinemoneyOffset.Value, 0);
		}

		public static void AddOnstrike(FlatBufferBuilder builder, bool onstrike)
		{
			builder.AddBool(2, onstrike, false);
		}

		public static void AddNotstrike(FlatBufferBuilder builder, bool notstrike)
		{
			builder.AddBool(3, notstrike, false);
		}

		public static Offset<OfflineData> EndOfflineData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<OfflineData>(o);
		}

		public OfflineDataT UnPack()
		{
			var _o = new OfflineDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(OfflineDataT _o)
		{
			_o.Totalofflinetime = this.Totalofflinetime;
			_o.Totalofflinemoney = this.Totalofflinemoney;
			_o.Onstrike = this.Onstrike;
			_o.Notstrike = this.Notstrike;
		}

		public static Offset<OfflineData> Pack(FlatBufferBuilder builder, OfflineDataT _o)
		{
			if (_o == null) return default(Offset<OfflineData>);
			var _totalofflinemoney = _o.Totalofflinemoney == null ? default(StringOffset) : builder.CreateString(_o.Totalofflinemoney);
			StartOfflineData(builder);
			AddTotalofflinetime(builder, _o.Totalofflinetime);
			AddTotalofflinemoney(builder, _totalofflinemoney);
			AddOnstrike(builder, _o.Onstrike);
			AddNotstrike(builder, _o.Notstrike);
			return EndOfflineData(builder);
		}
	}
}
