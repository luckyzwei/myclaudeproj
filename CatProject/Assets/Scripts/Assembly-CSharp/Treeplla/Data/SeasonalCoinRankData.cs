using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalCoinRankData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public long Startranktime { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Accumulatecnt { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool End { get { int o = __p.__offset(8); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int UserdataLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalCoinRankData GetRootAsSeasonalCoinRankData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalCoinRankData(_bb, new SeasonalCoinRankData());
		}

		public static SeasonalCoinRankData GetRootAsSeasonalCoinRankData(ByteBuffer _bb, SeasonalCoinRankData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalCoinRankData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateStartranktime(long startranktime)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, startranktime);
				return true;
			}
			return false;
		}

		public bool MutateAccumulatecnt(int accumulatecnt)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, accumulatecnt);
				return true;
			}
			return false;
		}

		public bool MutateEnd(bool end)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(end ? 1 : 0));
				return true;
			}
			return false;
		}

		public SeasonalUserData? Userdata(int j)
		{
			int o = __p.__offset(10);
			return o != 0 ? (new SeasonalUserData()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<SeasonalCoinRankData> CreateSeasonalCoinRankData(FlatBufferBuilder builder, long startranktime = 0L, int accumulatecnt = 0, bool end = false, VectorOffset userdataOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			AddUserdata(builder, userdataOffset);
			AddEnd(builder, end);
			AddAccumulatecnt(builder, accumulatecnt);
			AddStartranktime(builder, startranktime);
			return EndSeasonalCoinRankData(builder);
		}

		public static void StartSeasonalCoinRankData(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		public static void AddStartranktime(FlatBufferBuilder builder, long startranktime)
		{
			builder.AddLong(0, startranktime, 0);
		}

		public static void AddAccumulatecnt(FlatBufferBuilder builder, int accumulatecnt)
		{
			builder.AddInt(1, accumulatecnt, 0);
		}

		public static void AddEnd(FlatBufferBuilder builder, bool end)
		{
			builder.AddBool(2, end, false);
		}

		public static void AddUserdata(FlatBufferBuilder builder, VectorOffset userdataOffset)
		{
			builder.AddOffset(3, userdataOffset.Value, 0);
		}

		public static VectorOffset CreateUserdataVector(FlatBufferBuilder builder, Offset<SeasonalUserData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateUserdataVectorBlock(FlatBufferBuilder builder, Offset<SeasonalUserData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateUserdataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SeasonalUserData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateUserdataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartUserdataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<SeasonalCoinRankData> EndSeasonalCoinRankData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalCoinRankData>(o);
		}

		public SeasonalCoinRankDataT UnPack()
		{
			var _o = new SeasonalCoinRankDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalCoinRankDataT _o)
		{
			_o.Startranktime = this.Startranktime;
			_o.Accumulatecnt = this.Accumulatecnt;
			_o.End = this.End;
			_o.Userdata = new List<SeasonalUserDataT>();
			for (var _j = 0; _j < this.UserdataLength; ++_j)
				_o.Userdata.Add(this.Userdata(_j).HasValue ? this.Userdata(_j).Value.UnPack() : null);
		}

		public static Offset<SeasonalCoinRankData> Pack(FlatBufferBuilder builder, SeasonalCoinRankDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalCoinRankData>);
			var _userdata = default(VectorOffset);
			if (_o.Userdata != null)
			{
				var __userdata = new Offset<SeasonalUserData>[_o.Userdata.Count];
				for (var _j = 0; _j < _o.Userdata.Count; ++_j)
					__userdata[_j] = SeasonalUserData.Pack(builder, _o.Userdata[_j]);
				_userdata = CreateUserdataVector(builder, __userdata);
			}
			StartSeasonalCoinRankData(builder);
			AddStartranktime(builder, _o.Startranktime);
			AddAccumulatecnt(builder, _o.Accumulatecnt);
			AddEnd(builder, _o.End);
			AddUserdata(builder, _userdata);
			return EndSeasonalCoinRankData(builder);
		}
	}
}
