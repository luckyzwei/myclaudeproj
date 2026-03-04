using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AnniversaryEventData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Anniversaryyear { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Shownguide { get { int o = __p.__offset(6); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int Anniversarycoin { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Anniversaryrouletteticket { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Roulettemultipleindex { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Roulettplaycount { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Receivedplaybonuscount { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int EventshopdataLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static AnniversaryEventData GetRootAsAnniversaryEventData(ByteBuffer _bb)
		{
			return GetRootAsAnniversaryEventData(_bb, new AnniversaryEventData());
		}

		public static AnniversaryEventData GetRootAsAnniversaryEventData(ByteBuffer _bb, AnniversaryEventData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public AnniversaryEventData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateAnniversaryyear(int anniversaryyear)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, anniversaryyear);
				return true;
			}
			return false;
		}

		public bool MutateShownguide(bool shownguide)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(shownguide ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateAnniversarycoin(int anniversarycoin)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, anniversarycoin);
				return true;
			}
			return false;
		}

		public bool MutateAnniversaryrouletteticket(int anniversaryrouletteticket)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, anniversaryrouletteticket);
				return true;
			}
			return false;
		}

		public bool MutateRoulettemultipleindex(int roulettemultipleindex)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, roulettemultipleindex);
				return true;
			}
			return false;
		}

		public bool MutateRoulettplaycount(int roulettplaycount)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, roulettplaycount);
				return true;
			}
			return false;
		}

		public bool MutateReceivedplaybonuscount(int receivedplaybonuscount)
		{
			int o = __p.__offset(16);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, receivedplaybonuscount);
				return true;
			}
			return false;
		}

		public AnniversaryEventShopData? Eventshopdata(int j)
		{
			int o = __p.__offset(18);
			return o != 0 ? (new AnniversaryEventShopData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<AnniversaryEventData> CreateAnniversaryEventData(FlatBufferBuilder builder, int anniversaryyear = 0, bool shownguide = false, int anniversarycoin = 0, int anniversaryrouletteticket = 0, int roulettemultipleindex = 0, int roulettplaycount = 0, int receivedplaybonuscount = 0, VectorOffset eventshopdataOffset = default(VectorOffset))
		{
			builder.StartTable(8);
			AddEventshopdata(builder, eventshopdataOffset);
			AddReceivedplaybonuscount(builder, receivedplaybonuscount);
			AddRoulettplaycount(builder, roulettplaycount);
			AddRoulettemultipleindex(builder, roulettemultipleindex);
			AddAnniversaryrouletteticket(builder, anniversaryrouletteticket);
			AddAnniversarycoin(builder, anniversarycoin);
			AddShownguide(builder, shownguide);
			AddAnniversaryyear(builder, anniversaryyear);
			return EndAnniversaryEventData(builder);
		}

		public static void StartAnniversaryEventData(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		public static void AddAnniversaryyear(FlatBufferBuilder builder, int anniversaryyear)
		{
			builder.AddInt(0, anniversaryyear, 0);
		}

		public static void AddShownguide(FlatBufferBuilder builder, bool shownguide)
		{
			builder.AddBool(1, shownguide, false);
		}

		public static void AddAnniversarycoin(FlatBufferBuilder builder, int anniversarycoin)
		{
			builder.AddInt(2, anniversarycoin, 0);
		}

		public static void AddAnniversaryrouletteticket(FlatBufferBuilder builder, int anniversaryrouletteticket)
		{
			builder.AddInt(3, anniversaryrouletteticket, 0);
		}

		public static void AddRoulettemultipleindex(FlatBufferBuilder builder, int roulettemultipleindex)
		{
			builder.AddInt(4, roulettemultipleindex, 0);
		}

		public static void AddRoulettplaycount(FlatBufferBuilder builder, int roulettplaycount)
		{
			builder.AddInt(5, roulettplaycount, 0);
		}

		public static void AddReceivedplaybonuscount(FlatBufferBuilder builder, int receivedplaybonuscount)
		{
			builder.AddInt(6, receivedplaybonuscount, 0);
		}

		public static void AddEventshopdata(FlatBufferBuilder builder, VectorOffset eventshopdataOffset)
		{
			builder.AddOffset(7, eventshopdataOffset.Value, 0);
		}

		public static VectorOffset CreateEventshopdataVector(FlatBufferBuilder builder, Offset<AnniversaryEventShopData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateEventshopdataVectorBlock(FlatBufferBuilder builder, Offset<AnniversaryEventShopData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateEventshopdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<AnniversaryEventShopData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateEventshopdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartEventshopdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<AnniversaryEventData> EndAnniversaryEventData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<AnniversaryEventData>(o);
		}

		public AnniversaryEventDataT UnPack()
		{
			var _o = new AnniversaryEventDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(AnniversaryEventDataT _o)
		{
			_o.Anniversaryyear = this.Anniversaryyear;
			_o.Shownguide = this.Shownguide;
			_o.Anniversarycoin = this.Anniversarycoin;
			_o.Anniversaryrouletteticket = this.Anniversaryrouletteticket;
			_o.Roulettemultipleindex = this.Roulettemultipleindex;
			_o.Roulettplaycount = this.Roulettplaycount;
			_o.Receivedplaybonuscount = this.Receivedplaybonuscount;
			_o.Eventshopdata = new List<AnniversaryEventShopDataT>();
			for (var _j = 0; _j < this.EventshopdataLength; ++_j)
				_o.Eventshopdata.Add(this.Eventshopdata(_j).HasValue ? this.Eventshopdata(_j).Value.UnPack() : null);
		}

		public static Offset<AnniversaryEventData> Pack(FlatBufferBuilder builder, AnniversaryEventDataT _o)
		{
			if (_o == null) return default(Offset<AnniversaryEventData>);
			var _eventshopdata = default(VectorOffset);
			if (_o.Eventshopdata != null)
			{
				var __eventshopdata = new Offset<AnniversaryEventShopData>[_o.Eventshopdata.Count];
				for (var _j = 0; _j < _o.Eventshopdata.Count; ++_j)
					__eventshopdata[_j] = AnniversaryEventShopData.Pack(builder, _o.Eventshopdata[_j]);
				_eventshopdata = CreateEventshopdataVector(builder, __eventshopdata);
			}
			StartAnniversaryEventData(builder);
			AddAnniversaryyear(builder, _o.Anniversaryyear);
			AddShownguide(builder, _o.Shownguide);
			AddAnniversarycoin(builder, _o.Anniversarycoin);
			AddAnniversaryrouletteticket(builder, _o.Anniversaryrouletteticket);
			AddRoulettemultipleindex(builder, _o.Roulettemultipleindex);
			AddRoulettplaycount(builder, _o.Roulettplaycount);
			AddReceivedplaybonuscount(builder, _o.Receivedplaybonuscount);
			AddEventshopdata(builder, _eventshopdata);
			return EndAnniversaryEventData(builder);
		}
	}
}
