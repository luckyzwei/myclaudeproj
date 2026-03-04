using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct KeyValueLong : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Key { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Value { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static KeyValueLong GetRootAsKeyValueLong(ByteBuffer _bb)
		{
			return GetRootAsKeyValueLong(_bb, new KeyValueLong());
		}

		public static KeyValueLong GetRootAsKeyValueLong(ByteBuffer _bb, KeyValueLong obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public KeyValueLong __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateKey(int key)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, key);
				return true;
			}
			return false;
		}

		public bool MutateValue(long value)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, value);
				return true;
			}
			return false;
		}

		public static Offset<KeyValueLong> CreateKeyValueLong(FlatBufferBuilder builder, int key = 0, long value = 0L)
		{
			builder.StartTable(2);
			AddValue(builder, value);
			AddKey(builder, key);
			return EndKeyValueLong(builder);
		}

		public static void StartKeyValueLong(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		public static void AddValue(FlatBufferBuilder builder, long value)
		{
			builder.AddLong(1, value, 0);
		}

		public static Offset<KeyValueLong> EndKeyValueLong(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<KeyValueLong>(o);
		}

		public KeyValueLongT UnPack()
		{
			var _o = new KeyValueLongT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(KeyValueLongT _o)
		{
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		public static Offset<KeyValueLong> Pack(FlatBufferBuilder builder, KeyValueLongT _o)
		{
			if (_o == null) return default(Offset<KeyValueLong>);
			StartKeyValueLong(builder);
			AddKey(builder, _o.Key);
			AddValue(builder, _o.Value);
			return EndKeyValueLong(builder);
		}
	}
}
