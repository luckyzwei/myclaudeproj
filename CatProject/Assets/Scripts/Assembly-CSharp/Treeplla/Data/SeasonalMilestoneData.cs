using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalMilestoneData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public string Currencyaccumulationvalue { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }

		public int ReceivedrewardidxlistLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public float Milestonestepelapsedtimesec { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0f; } }

		public int ReceivedpreminumrewardidxlistLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalMilestoneData GetRootAsSeasonalMilestoneData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalMilestoneData(_bb, new SeasonalMilestoneData());
		}

		public static SeasonalMilestoneData GetRootAsSeasonalMilestoneData(ByteBuffer _bb, SeasonalMilestoneData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalMilestoneData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public ArraySegment<byte>? GetCurrencyaccumulationvalueBytes()
		{
			return __p.__vector_as_arraysegment(4);
		}

		public byte[] GetCurrencyaccumulationvalueArray()
		{
			return __p.__vector_as_array<byte>(4);
		}

		public int Receivedrewardidxlist(int j)
		{
			int o = __p.__offset(6);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetReceivedrewardidxlistBytes()
		{
			return __p.__vector_as_arraysegment(12);
		}

		public int[] GetReceivedrewardidxlistArray()
		{
			return null;
		}

		public bool MutateReceivedrewardidxlist(int j, int receivedrewardidxlist)
		{
			return false;
		}

		public bool MutateMilestonestepelapsedtimesec(float milestonestepelapsedtimesec)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutFloat(o + __p.bb_pos, milestonestepelapsedtimesec);
				return true;
			}
			return false;
		}

		public int Receivedpreminumrewardidxlist(int j)
		{
			int o = __p.__offset(10);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetReceivedpreminumrewardidxlistBytes()
		{
			return __p.__vector_as_arraysegment(14);
		}

		public int[] GetReceivedpreminumrewardidxlistArray()
		{
			return null;
		}

		public bool MutateReceivedpreminumrewardidxlist(int j, int receivedpreminumrewardidxlist)
		{
			return false;
		}

		public static Offset<SeasonalMilestoneData> CreateSeasonalMilestoneData(FlatBufferBuilder builder, StringOffset currencyaccumulationvalueOffset = default(StringOffset), VectorOffset receivedrewardidxlistOffset = default(VectorOffset), float milestonestepelapsedtimesec = 0f, VectorOffset receivedpreminumrewardidxlistOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			AddReceivedpreminumrewardidxlist(builder, receivedpreminumrewardidxlistOffset);
			AddMilestonestepelapsedtimesec(builder, milestonestepelapsedtimesec);
			AddReceivedrewardidxlist(builder, receivedrewardidxlistOffset);
			AddCurrencyaccumulationvalue(builder, currencyaccumulationvalueOffset);
			return EndSeasonalMilestoneData(builder);
		}

		public static void StartSeasonalMilestoneData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		public static void AddCurrencyaccumulationvalue(FlatBufferBuilder builder, StringOffset currencyaccumulationvalueOffset)
		{
			builder.AddOffset(0, currencyaccumulationvalueOffset.Value, 0);
		}

		public static void AddReceivedrewardidxlist(FlatBufferBuilder builder, VectorOffset receivedrewardidxlistOffset)
		{
			builder.AddOffset(1, receivedrewardidxlistOffset.Value, 0);
		}

		public static VectorOffset CreateReceivedrewardidxlistVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivedrewardidxlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivedrewardidxlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivedrewardidxlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartReceivedrewardidxlistVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddMilestonestepelapsedtimesec(FlatBufferBuilder builder, float milestonestepelapsedtimesec)
		{
			builder.AddFloat(2, milestonestepelapsedtimesec, 0f);
		}

		public static void AddReceivedpreminumrewardidxlist(FlatBufferBuilder builder, VectorOffset receivedpreminumrewardidxlistOffset)
		{
			builder.AddOffset(3, receivedpreminumrewardidxlistOffset.Value, 0);
		}

		public static VectorOffset CreateReceivedpreminumrewardidxlistVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivedpreminumrewardidxlistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivedpreminumrewardidxlistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateReceivedpreminumrewardidxlistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartReceivedpreminumrewardidxlistVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<SeasonalMilestoneData> EndSeasonalMilestoneData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalMilestoneData>(o);
		}

		public SeasonalMilestoneDataT UnPack()
		{
			var _o = new SeasonalMilestoneDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalMilestoneDataT _o)
		{
			_o.Currencyaccumulationvalue = this.Currencyaccumulationvalue;
			_o.Receivedrewardidxlist = new List<int>();
			for (var _j = 0; _j < this.ReceivedrewardidxlistLength; ++_j)
				_o.Receivedrewardidxlist.Add(this.Receivedrewardidxlist(_j));
			_o.Milestonestepelapsedtimesec = this.Milestonestepelapsedtimesec;
			_o.Receivedpreminumrewardidxlist = new List<int>();
			for (var _j = 0; _j < this.ReceivedpreminumrewardidxlistLength; ++_j)
				_o.Receivedpreminumrewardidxlist.Add(this.Receivedpreminumrewardidxlist(_j));
		}

		public static Offset<SeasonalMilestoneData> Pack(FlatBufferBuilder builder, SeasonalMilestoneDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalMilestoneData>);
			var _currencyaccumulationvalue = _o.Currencyaccumulationvalue == null ? default(StringOffset) : builder.CreateString(_o.Currencyaccumulationvalue);
			var _receivedrewardidxlist = default(VectorOffset);
			if (_o.Receivedrewardidxlist != null)
			{
				var __receivedrewardidxlist = _o.Receivedrewardidxlist.ToArray();
				_receivedrewardidxlist = CreateReceivedrewardidxlistVector(builder, __receivedrewardidxlist);
			}
			var _receivedpreminumrewardidxlist = default(VectorOffset);
			if (_o.Receivedpreminumrewardidxlist != null)
			{
				var __receivedpreminumrewardidxlist = _o.Receivedpreminumrewardidxlist.ToArray();
				_receivedpreminumrewardidxlist = CreateReceivedpreminumrewardidxlistVector(builder, __receivedpreminumrewardidxlist);
			}
			StartSeasonalMilestoneData(builder);
			AddCurrencyaccumulationvalue(builder, _currencyaccumulationvalue);
			AddReceivedrewardidxlist(builder, _receivedrewardidxlist);
			AddMilestonestepelapsedtimesec(builder, _o.Milestonestepelapsedtimesec);
			AddReceivedpreminumrewardidxlist(builder, _receivedpreminumrewardidxlist);
			return EndSeasonalMilestoneData(builder);
		}
	}
}
