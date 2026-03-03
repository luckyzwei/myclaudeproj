using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalArcadeMachineData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Level => 0;

		public int Bettingmultiplevalue => 0;

		public bool Receivedfirstfixedreward => false;

		public int Roulettecount => 0;

		public bool Usefirstfreechance => false;

		public int Firstfreechancecheckcount => 0;

		public static void ValidateVersion()
		{
		}

		public static SeasonalArcadeMachineData GetRootAsSeasonalArcadeMachineData(ByteBuffer _bb)
		{
			return default(SeasonalArcadeMachineData);
		}

		public static SeasonalArcadeMachineData GetRootAsSeasonalArcadeMachineData(ByteBuffer _bb, SeasonalArcadeMachineData obj)
		{
			return default(SeasonalArcadeMachineData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public SeasonalArcadeMachineData __assign(int _i, ByteBuffer _bb)
		{
			return default(SeasonalArcadeMachineData);
		}

		public bool MutateLevel(int level)
		{
			return false;
		}

		public bool MutateBettingmultiplevalue(int bettingmultiplevalue)
		{
			return false;
		}

		public bool MutateReceivedfirstfixedreward(bool receivedfirstfixedreward)
		{
			return false;
		}

		public bool MutateRoulettecount(int roulettecount)
		{
			return false;
		}

		public bool MutateUsefirstfreechance(bool usefirstfreechance)
		{
			return false;
		}

		public bool MutateFirstfreechancecheckcount(int firstfreechancecheckcount)
		{
			return false;
		}

		public static Offset<SeasonalArcadeMachineData> CreateSeasonalArcadeMachineData(FlatBufferBuilder builder, int level = 0, int bettingmultiplevalue = 0, bool receivedfirstfixedreward = false, int roulettecount = 0, bool usefirstfreechance = false, int firstfreechancecheckcount = 0)
		{
			return default(Offset<SeasonalArcadeMachineData>);
		}

		public static void StartSeasonalArcadeMachineData(FlatBufferBuilder builder)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddBettingmultiplevalue(FlatBufferBuilder builder, int bettingmultiplevalue)
		{
		}

		public static void AddReceivedfirstfixedreward(FlatBufferBuilder builder, bool receivedfirstfixedreward)
		{
		}

		public static void AddRoulettecount(FlatBufferBuilder builder, int roulettecount)
		{
		}

		public static void AddUsefirstfreechance(FlatBufferBuilder builder, bool usefirstfreechance)
		{
		}

		public static void AddFirstfreechancecheckcount(FlatBufferBuilder builder, int firstfreechancecheckcount)
		{
		}

		public static Offset<SeasonalArcadeMachineData> EndSeasonalArcadeMachineData(FlatBufferBuilder builder)
		{
			return default(Offset<SeasonalArcadeMachineData>);
		}

		public SeasonalArcadeMachineDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(SeasonalArcadeMachineDataT _o)
		{
		}

		public static Offset<SeasonalArcadeMachineData> Pack(FlatBufferBuilder builder, SeasonalArcadeMachineDataT _o)
		{
			return default(Offset<SeasonalArcadeMachineData>);
		}
	}
}
