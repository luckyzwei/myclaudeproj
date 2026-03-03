using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OptionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public string Language => null;

		public bool Bgm => false;

		public bool Effect => false;

		public bool Slowgraphic => false;

		public bool Vibration => false;

		public bool Companylvupatonce => false;

		public static void ValidateVersion()
		{
		}

		public static OptionData GetRootAsOptionData(ByteBuffer _bb)
		{
			return default(OptionData);
		}

		public static OptionData GetRootAsOptionData(ByteBuffer _bb, OptionData obj)
		{
			return default(OptionData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public OptionData __assign(int _i, ByteBuffer _bb)
		{
			return default(OptionData);
		}

		public ArraySegment<byte>? GetLanguageBytes()
		{
			return null;
		}

		public byte[] GetLanguageArray()
		{
			return null;
		}

		public bool MutateBgm(bool bgm)
		{
			return false;
		}

		public bool MutateEffect(bool effect)
		{
			return false;
		}

		public bool MutateSlowgraphic(bool slowgraphic)
		{
			return false;
		}

		public bool MutateVibration(bool vibration)
		{
			return false;
		}

		public bool MutateCompanylvupatonce(bool companylvupatonce)
		{
			return false;
		}

		public static Offset<OptionData> CreateOptionData(FlatBufferBuilder builder, StringOffset languageOffset = default(StringOffset), bool bgm = false, bool effect = false, bool slowgraphic = false, bool vibration = true, bool companylvupatonce = true)
		{
			return default(Offset<OptionData>);
		}

		public static void StartOptionData(FlatBufferBuilder builder)
		{
		}

		public static void AddLanguage(FlatBufferBuilder builder, StringOffset languageOffset)
		{
		}

		public static void AddBgm(FlatBufferBuilder builder, bool bgm)
		{
		}

		public static void AddEffect(FlatBufferBuilder builder, bool effect)
		{
		}

		public static void AddSlowgraphic(FlatBufferBuilder builder, bool slowgraphic)
		{
		}

		public static void AddVibration(FlatBufferBuilder builder, bool vibration)
		{
		}

		public static void AddCompanylvupatonce(FlatBufferBuilder builder, bool companylvupatonce)
		{
		}

		public static Offset<OptionData> EndOptionData(FlatBufferBuilder builder)
		{
			return default(Offset<OptionData>);
		}

		public OptionDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(OptionDataT _o)
		{
		}

		public static Offset<OptionData> Pack(FlatBufferBuilder builder, OptionDataT _o)
		{
			return default(Offset<OptionData>);
		}
	}
}
