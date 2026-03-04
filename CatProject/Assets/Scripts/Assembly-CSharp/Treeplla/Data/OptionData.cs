using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OptionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public string Language { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public bool Bgm { get { int o = __p.__offset(6); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Effect { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Slowgraphic { get { int o = __p.__offset(10); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Vibration { get { int o = __p.__offset(12); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public bool Companylvupatonce { get { int o = __p.__offset(14); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static OptionData GetRootAsOptionData(ByteBuffer _bb)
		{
			return GetRootAsOptionData(_bb, new OptionData());
		}

		public static OptionData GetRootAsOptionData(ByteBuffer _bb, OptionData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public OptionData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public ArraySegment<byte>? GetLanguageBytes()
		{
			return __p.__vector_as_arraysegment(4);
		}

		public byte[] GetLanguageArray()
		{
			return __p.__vector_as_array<byte>(4);
		}

		public bool MutateBgm(bool bgm)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(bgm ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateEffect(bool effect)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(effect ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateSlowgraphic(bool slowgraphic)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(slowgraphic ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateVibration(bool vibration)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(vibration ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateCompanylvupatonce(bool companylvupatonce)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(companylvupatonce ? 1 : 0));
				return true;
			}
			return false;
		}

		public static Offset<OptionData> CreateOptionData(FlatBufferBuilder builder, StringOffset languageOffset = default(StringOffset), bool bgm = false, bool effect = false, bool slowgraphic = false, bool vibration = true, bool companylvupatonce = true)
		{
			builder.StartTable(6);
			AddCompanylvupatonce(builder, companylvupatonce);
			AddVibration(builder, vibration);
			AddSlowgraphic(builder, slowgraphic);
			AddEffect(builder, effect);
			AddBgm(builder, bgm);
			AddLanguage(builder, languageOffset);
			return EndOptionData(builder);
		}

		public static void StartOptionData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		public static void AddLanguage(FlatBufferBuilder builder, StringOffset languageOffset)
		{
			builder.AddOffset(0, languageOffset.Value, 0);
		}

		public static void AddBgm(FlatBufferBuilder builder, bool bgm)
		{
			builder.AddBool(1, bgm, false);
		}

		public static void AddEffect(FlatBufferBuilder builder, bool effect)
		{
			builder.AddBool(2, effect, false);
		}

		public static void AddSlowgraphic(FlatBufferBuilder builder, bool slowgraphic)
		{
			builder.AddBool(3, slowgraphic, false);
		}

		public static void AddVibration(FlatBufferBuilder builder, bool vibration)
		{
			builder.AddBool(4, vibration, false);
		}

		public static void AddCompanylvupatonce(FlatBufferBuilder builder, bool companylvupatonce)
		{
			builder.AddBool(5, companylvupatonce, false);
		}

		public static Offset<OptionData> EndOptionData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<OptionData>(o);
		}

		public OptionDataT UnPack()
		{
			var _o = new OptionDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(OptionDataT _o)
		{
			_o.Language = this.Language;
			_o.Bgm = this.Bgm;
			_o.Effect = this.Effect;
			_o.Slowgraphic = this.Slowgraphic;
			_o.Vibration = this.Vibration;
			_o.Companylvupatonce = this.Companylvupatonce;
		}

		public static Offset<OptionData> Pack(FlatBufferBuilder builder, OptionDataT _o)
		{
			if (_o == null) return default(Offset<OptionData>);
			var _language = _o.Language == null ? default(StringOffset) : builder.CreateString(_o.Language);
			StartOptionData(builder);
			AddLanguage(builder, _language);
			AddBgm(builder, _o.Bgm);
			AddEffect(builder, _o.Effect);
			AddSlowgraphic(builder, _o.Slowgraphic);
			AddVibration(builder, _o.Vibration);
			AddCompanylvupatonce(builder, _o.Companylvupatonce);
			return EndOptionData(builder);
		}
	}
}
