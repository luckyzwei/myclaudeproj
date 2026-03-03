using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AnniversaryEventData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Anniversaryyear => 0;

		public bool Shownguide => false;

		public int Anniversarycoin => 0;

		public int Anniversaryrouletteticket => 0;

		public int Roulettemultipleindex => 0;

		public int Roulettplaycount => 0;

		public int Receivedplaybonuscount => 0;

		public int EventshopdataLength => 0;

		public static void ValidateVersion()
		{
		}

		public static AnniversaryEventData GetRootAsAnniversaryEventData(ByteBuffer _bb)
		{
			return default(AnniversaryEventData);
		}

		public static AnniversaryEventData GetRootAsAnniversaryEventData(ByteBuffer _bb, AnniversaryEventData obj)
		{
			return default(AnniversaryEventData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public AnniversaryEventData __assign(int _i, ByteBuffer _bb)
		{
			return default(AnniversaryEventData);
		}

		public bool MutateAnniversaryyear(int anniversaryyear)
		{
			return false;
		}

		public bool MutateShownguide(bool shownguide)
		{
			return false;
		}

		public bool MutateAnniversarycoin(int anniversarycoin)
		{
			return false;
		}

		public bool MutateAnniversaryrouletteticket(int anniversaryrouletteticket)
		{
			return false;
		}

		public bool MutateRoulettemultipleindex(int roulettemultipleindex)
		{
			return false;
		}

		public bool MutateRoulettplaycount(int roulettplaycount)
		{
			return false;
		}

		public bool MutateReceivedplaybonuscount(int receivedplaybonuscount)
		{
			return false;
		}

		public AnniversaryEventShopData? Eventshopdata(int j)
		{
			return null;
		}

		public static Offset<AnniversaryEventData> CreateAnniversaryEventData(FlatBufferBuilder builder, int anniversaryyear = 0, bool shownguide = false, int anniversarycoin = 0, int anniversaryrouletteticket = 0, int roulettemultipleindex = 0, int roulettplaycount = 0, int receivedplaybonuscount = 0, VectorOffset eventshopdataOffset = default(VectorOffset))
		{
			return default(Offset<AnniversaryEventData>);
		}

		public static void StartAnniversaryEventData(FlatBufferBuilder builder)
		{
		}

		public static void AddAnniversaryyear(FlatBufferBuilder builder, int anniversaryyear)
		{
		}

		public static void AddShownguide(FlatBufferBuilder builder, bool shownguide)
		{
		}

		public static void AddAnniversarycoin(FlatBufferBuilder builder, int anniversarycoin)
		{
		}

		public static void AddAnniversaryrouletteticket(FlatBufferBuilder builder, int anniversaryrouletteticket)
		{
		}

		public static void AddRoulettemultipleindex(FlatBufferBuilder builder, int roulettemultipleindex)
		{
		}

		public static void AddRoulettplaycount(FlatBufferBuilder builder, int roulettplaycount)
		{
		}

		public static void AddReceivedplaybonuscount(FlatBufferBuilder builder, int receivedplaybonuscount)
		{
		}

		public static void AddEventshopdata(FlatBufferBuilder builder, VectorOffset eventshopdataOffset)
		{
		}

		public static VectorOffset CreateEventshopdataVector(FlatBufferBuilder builder, Offset<AnniversaryEventShopData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateEventshopdataVectorBlock(FlatBufferBuilder builder, Offset<AnniversaryEventShopData>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateEventshopdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<AnniversaryEventShopData>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateEventshopdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartEventshopdataVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static Offset<AnniversaryEventData> EndAnniversaryEventData(FlatBufferBuilder builder)
		{
			return default(Offset<AnniversaryEventData>);
		}

		public AnniversaryEventDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(AnniversaryEventDataT _o)
		{
		}

		public static Offset<AnniversaryEventData> Pack(FlatBufferBuilder builder, AnniversaryEventDataT _o)
		{
			return default(Offset<AnniversaryEventData>);
		}
	}
}
