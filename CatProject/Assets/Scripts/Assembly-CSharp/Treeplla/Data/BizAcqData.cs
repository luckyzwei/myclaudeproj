using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct BizAcqData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Curstageidx => 0;

		public BizAcqTeamData? Teamdata => null;

		public long Lastrewardgettime => 0L;

		public long Laststagecleartime => 0L;

		public int AccumulaterewardsLength => 0;

		public long Autoplayguideshowntime => 0L;

		public int Multiplerewardgetcount => 0;

		public long Multiplerewardlastgettime => 0L;

		public int PassreceiveLength => 0;

		public bool Autoplayon => false;

		public int Battlespeedindex => 0;

		public string Accumulatereinstone => null;

		public long Lastrewardaccumulatetime => 0L;

		public long Weeklyshopshowntime => 0L;

		public string Jewelryboxvalue => null;

		public int Jewelryboxlevel => 0;

		public int Jewelryboxstagestep => 0;

		public int Jewelryboxstagelastshownstep => 0;

		public bool Activespeedtrial => false;

		public static void ValidateVersion()
		{
		}

		public static BizAcqData GetRootAsBizAcqData(ByteBuffer _bb)
		{
			return default(BizAcqData);
		}

		public static BizAcqData GetRootAsBizAcqData(ByteBuffer _bb, BizAcqData obj)
		{
			return default(BizAcqData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public BizAcqData __assign(int _i, ByteBuffer _bb)
		{
			return default(BizAcqData);
		}

		public bool MutateCurstageidx(int curstageidx)
		{
			return false;
		}

		public bool MutateLastrewardgettime(long lastrewardgettime)
		{
			return false;
		}

		public bool MutateLaststagecleartime(long laststagecleartime)
		{
			return false;
		}

		public CurrencyData? Accumulaterewards(int j)
		{
			return null;
		}

		public bool MutateAutoplayguideshowntime(long autoplayguideshowntime)
		{
			return false;
		}

		public bool MutateMultiplerewardgetcount(int multiplerewardgetcount)
		{
			return false;
		}

		public bool MutateMultiplerewardlastgettime(long multiplerewardlastgettime)
		{
			return false;
		}

		public PassReceiveData? Passreceive(int j)
		{
			return null;
		}

		public bool MutateAutoplayon(bool autoplayon)
		{
			return false;
		}

		public bool MutateBattlespeedindex(int battlespeedindex)
		{
			return false;
		}

		public ArraySegment<byte>? GetAccumulatereinstoneBytes()
		{
			return null;
		}

		public byte[] GetAccumulatereinstoneArray()
		{
			return null;
		}

		public bool MutateLastrewardaccumulatetime(long lastrewardaccumulatetime)
		{
			return false;
		}

		public bool MutateWeeklyshopshowntime(long weeklyshopshowntime)
		{
			return false;
		}

		public ArraySegment<byte>? GetJewelryboxvalueBytes()
		{
			return null;
		}

		public byte[] GetJewelryboxvalueArray()
		{
			return null;
		}

		public bool MutateJewelryboxlevel(int jewelryboxlevel)
		{
			return false;
		}

		public bool MutateJewelryboxstagestep(int jewelryboxstagestep)
		{
			return false;
		}

		public bool MutateJewelryboxstagelastshownstep(int jewelryboxstagelastshownstep)
		{
			return false;
		}

		public bool MutateActivespeedtrial(bool activespeedtrial)
		{
			return false;
		}

		public static Offset<BizAcqData> CreateBizAcqData(FlatBufferBuilder builder, int curstageidx = 0, Offset<BizAcqTeamData> teamdataOffset = default(Offset<BizAcqTeamData>), long lastrewardgettime = 0L, long laststagecleartime = 0L, VectorOffset accumulaterewardsOffset = default(VectorOffset), long autoplayguideshowntime = 0L, int multiplerewardgetcount = 0, long multiplerewardlastgettime = 0L, VectorOffset passreceiveOffset = default(VectorOffset), bool autoplayon = false, int battlespeedindex = 0, StringOffset accumulatereinstoneOffset = default(StringOffset), long lastrewardaccumulatetime = 0L, long weeklyshopshowntime = 0L, StringOffset jewelryboxvalueOffset = default(StringOffset), int jewelryboxlevel = 1, int jewelryboxstagestep = 0, int jewelryboxstagelastshownstep = 0, bool activespeedtrial = false)
		{
			return default(Offset<BizAcqData>);
		}

		public static void StartBizAcqData(FlatBufferBuilder builder)
		{
		}

		public static void AddCurstageidx(FlatBufferBuilder builder, int curstageidx)
		{
		}

		public static void AddTeamdata(FlatBufferBuilder builder, Offset<BizAcqTeamData> teamdataOffset)
		{
		}

		public static void AddLastrewardgettime(FlatBufferBuilder builder, long lastrewardgettime)
		{
		}

		public static void AddLaststagecleartime(FlatBufferBuilder builder, long laststagecleartime)
		{
		}

		public static void AddAccumulaterewards(FlatBufferBuilder builder, VectorOffset accumulaterewardsOffset)
		{
		}

		public static VectorOffset CreateAccumulaterewardsVector(FlatBufferBuilder builder, Offset<CurrencyData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAccumulaterewardsVectorBlock(FlatBufferBuilder builder, Offset<CurrencyData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAccumulaterewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<CurrencyData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateAccumulaterewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartAccumulaterewardsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddAutoplayguideshowntime(FlatBufferBuilder builder, long autoplayguideshowntime)
		{
		}

		public static void AddMultiplerewardgetcount(FlatBufferBuilder builder, int multiplerewardgetcount)
		{
		}

		public static void AddMultiplerewardlastgettime(FlatBufferBuilder builder, long multiplerewardlastgettime)
		{
		}

		public static void AddPassreceive(FlatBufferBuilder builder, VectorOffset passreceiveOffset)
		{
		}

		public static VectorOffset CreatePassreceiveVector(FlatBufferBuilder builder, Offset<PassReceiveData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePassreceiveVectorBlock(FlatBufferBuilder builder, Offset<PassReceiveData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePassreceiveVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<PassReceiveData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePassreceiveVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartPassreceiveVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddAutoplayon(FlatBufferBuilder builder, bool autoplayon)
		{
		}

		public static void AddBattlespeedindex(FlatBufferBuilder builder, int battlespeedindex)
		{
		}

		public static void AddAccumulatereinstone(FlatBufferBuilder builder, StringOffset accumulatereinstoneOffset)
		{
		}

		public static void AddLastrewardaccumulatetime(FlatBufferBuilder builder, long lastrewardaccumulatetime)
		{
		}

		public static void AddWeeklyshopshowntime(FlatBufferBuilder builder, long weeklyshopshowntime)
		{
		}

		public static void AddJewelryboxvalue(FlatBufferBuilder builder, StringOffset jewelryboxvalueOffset)
		{
		}

		public static void AddJewelryboxlevel(FlatBufferBuilder builder, int jewelryboxlevel)
		{
		}

		public static void AddJewelryboxstagestep(FlatBufferBuilder builder, int jewelryboxstagestep)
		{
		}

		public static void AddJewelryboxstagelastshownstep(FlatBufferBuilder builder, int jewelryboxstagelastshownstep)
		{
		}

		public static void AddActivespeedtrial(FlatBufferBuilder builder, bool activespeedtrial)
		{
		}

		public static Offset<BizAcqData> EndBizAcqData(FlatBufferBuilder builder)
		{
			return default(Offset<BizAcqData>);
		}

		public BizAcqDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(BizAcqDataT _o)
		{
		}

		public static Offset<BizAcqData> Pack(FlatBufferBuilder builder, BizAcqDataT _o)
		{
			return default(Offset<BizAcqData>);
		}
	}
}
