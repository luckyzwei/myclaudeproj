using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct KeyValue : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Idx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public float Value { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0f; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static KeyValue GetRootAsKeyValue(ByteBuffer _bb)
		{
			return GetRootAsKeyValue(_bb, new KeyValue());
		}

		public static KeyValue GetRootAsKeyValue(ByteBuffer _bb, KeyValue obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public KeyValue __assign(int _i, ByteBuffer _bb)
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

		public bool MutateValue(float value)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutFloat(o + __p.bb_pos, value);
				return true;
			}
			return false;
		}

		public static Offset<KeyValue> CreateKeyValue(FlatBufferBuilder builder, int idx = 0, float value = 0f)
		{
			builder.StartTable(2);
			AddValue(builder, value);
			AddIdx(builder, idx);
			return EndKeyValue(builder);
		}

		public static void StartKeyValue(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		public static void AddIdx(FlatBufferBuilder builder, int idx)
		{
			builder.AddInt(0, idx, 0);
		}

		public static void AddValue(FlatBufferBuilder builder, float value)
		{
			builder.AddFloat(1, value, 0f);
		}

		public static Offset<KeyValue> EndKeyValue(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<KeyValue>(o);
		}

		public KeyValueT UnPack()
		{
			var _o = new KeyValueT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(KeyValueT _o)
		{
			_o.Idx = this.Idx;
			_o.Value = this.Value;
		}

		public static Offset<KeyValue> Pack(FlatBufferBuilder builder, KeyValueT _o)
		{
			if (_o == null) return default(Offset<KeyValue>);
			StartKeyValue(builder);
			AddIdx(builder, _o.Idx);
			AddValue(builder, _o.Value);
			return EndKeyValue(builder);
		}
	}
}
