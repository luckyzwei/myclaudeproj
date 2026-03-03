using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalUserData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Graphtype => 0;

		public int Finalscore => 0;

		public int Currentscore => 0;

		public string Name => null;

		public string Profile => null;

		public bool Me => false;

		public int Graphpower => 0;

		public static void ValidateVersion()
		{
		}

		public static SeasonalUserData GetRootAsSeasonalUserData(ByteBuffer _bb)
		{
			return default(SeasonalUserData);
		}

		public static SeasonalUserData GetRootAsSeasonalUserData(ByteBuffer _bb, SeasonalUserData obj)
		{
			return default(SeasonalUserData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalUserData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalUserData);
		}

		public bool MutateGraphtype(int graphtype)
		{
			return false;
		}

		public bool MutateFinalscore(int finalscore)
		{
			return false;
		}

		public bool MutateCurrentscore(int currentscore)
		{
			return false;
		}

		public ArraySegment<byte>? GetNameBytes()
		{
			return null;
		}

		public byte[] GetNameArray()
		{
			return null;
		}

		public ArraySegment<byte>? GetProfileBytes()
		{
			return null;
		}

		public byte[] GetProfileArray()
		{
			return null;
		}

		public bool MutateMe(bool me)
		{
			return false;
		}

		public bool MutateGraphpower(int graphpower)
		{
			return false;
		}

		public static Offset<SeasonalUserData> CreateSeasonalUserData(FlatBufferBuilder builder, int graphtype = 0, int finalscore = 0, int currentscore = 0, StringOffset nameOffset = default(StringOffset), StringOffset profileOffset = default(StringOffset), bool me = false, int graphpower = 0)
		{
			return default(Offset<SeasonalUserData>);
		}

		public static void StartSeasonalUserData(FlatBufferBuilder builder)
		{
		}

		public static void AddGraphtype(FlatBufferBuilder builder, int graphtype)
		{
		}

		public static void AddFinalscore(FlatBufferBuilder builder, int finalscore)
		{
		}

		public static void AddCurrentscore(FlatBufferBuilder builder, int currentscore)
		{
		}

		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
		}

		public static void AddProfile(FlatBufferBuilder builder, StringOffset profileOffset)
		{
		}

		public static void AddMe(FlatBufferBuilder builder, bool me)
		{
		}

		public static void AddGraphpower(FlatBufferBuilder builder, int graphpower)
		{
		}

		public static Offset<SeasonalUserData> EndSeasonalUserData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalUserData>);
		}

		public SeasonalUserDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalUserDataT _o)
		{
		}

		public static Offset<SeasonalUserData> Pack(FlatBufferBuilder builder, SeasonalUserDataT _o)
		{
			return default(Offset<SeasonalUserData>);
		}
	}
}
