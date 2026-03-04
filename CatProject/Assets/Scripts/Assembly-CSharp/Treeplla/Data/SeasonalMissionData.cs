using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct SeasonalMissionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Missionidx { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int MissionvalueLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int MissioncompleteLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int MissionneedvalueLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int NeedupdatetargetrequirevalueLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static SeasonalMissionData GetRootAsSeasonalMissionData(ByteBuffer _bb)
		{
			return GetRootAsSeasonalMissionData(_bb, new SeasonalMissionData());
		}

		public static SeasonalMissionData GetRootAsSeasonalMissionData(ByteBuffer _bb, SeasonalMissionData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public SeasonalMissionData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateMissionidx(int missionidx)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, missionidx);
				return true;
			}
			return false;
		}

		public string Missionvalue(int j)
		{
			int o = __p.__offset(6);
			return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null;
		}

		public bool Missioncomplete(int j)
		{
			return false;
		}

		public ArraySegment<byte>? GetMissioncompleteBytes()
		{
			return __p.__vector_as_arraysegment(16);
		}

		public bool[] GetMissioncompleteArray()
		{
			return null;
		}

		public bool MutateMissioncomplete(int j, bool missioncomplete)
		{
			return false;
		}

		public string Missionneedvalue(int j)
		{
			int o = __p.__offset(10);
			return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null;
		}

		public bool Needupdatetargetrequirevalue(int j)
		{
			return false;
		}

		public ArraySegment<byte>? GetNeedupdatetargetrequirevalueBytes()
		{
			return __p.__vector_as_arraysegment(20);
		}

		public bool[] GetNeedupdatetargetrequirevalueArray()
		{
			return null;
		}

		public bool MutateNeedupdatetargetrequirevalue(int j, bool needupdatetargetrequirevalue)
		{
			return false;
		}

		public static Offset<SeasonalMissionData> CreateSeasonalMissionData(FlatBufferBuilder builder, int missionidx = 0, VectorOffset missionvalueOffset = default(VectorOffset), VectorOffset missioncompleteOffset = default(VectorOffset), VectorOffset missionneedvalueOffset = default(VectorOffset), VectorOffset needupdatetargetrequirevalueOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			AddNeedupdatetargetrequirevalue(builder, needupdatetargetrequirevalueOffset);
			AddMissionneedvalue(builder, missionneedvalueOffset);
			AddMissioncomplete(builder, missioncompleteOffset);
			AddMissionvalue(builder, missionvalueOffset);
			AddMissionidx(builder, missionidx);
			return EndSeasonalMissionData(builder);
		}

		public static void StartSeasonalMissionData(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		public static void AddMissionidx(FlatBufferBuilder builder, int missionidx)
		{
			builder.AddInt(0, missionidx, 0);
		}

		public static void AddMissionvalue(FlatBufferBuilder builder, VectorOffset missionvalueOffset)
		{
			builder.AddOffset(1, missionvalueOffset.Value, 0);
		}

		public static VectorOffset CreateMissionvalueVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionvalueVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionvalueVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionvalueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartMissionvalueVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddMissioncomplete(FlatBufferBuilder builder, VectorOffset missioncompleteOffset)
		{
			builder.AddOffset(2, missioncompleteOffset.Value, 0);
		}

		public static VectorOffset CreateMissioncompleteVector(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddBool(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateMissioncompleteVectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddBool(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissioncompleteVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			builder.StartVector(1, data.Count, 1);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddBool(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissioncompleteVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartMissioncompleteVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddMissionneedvalue(FlatBufferBuilder builder, VectorOffset missionneedvalueOffset)
		{
			builder.AddOffset(3, missionneedvalueOffset.Value, 0);
		}

		public static VectorOffset CreateMissionneedvalueVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionneedvalueVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionneedvalueVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateMissionneedvalueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartMissionneedvalueVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddNeedupdatetargetrequirevalue(FlatBufferBuilder builder, VectorOffset needupdatetargetrequirevalueOffset)
		{
			builder.AddOffset(4, needupdatetargetrequirevalueOffset.Value, 0);
		}

		public static VectorOffset CreateNeedupdatetargetrequirevalueVector(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddBool(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateNeedupdatetargetrequirevalueVectorBlock(FlatBufferBuilder builder, bool[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddBool(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateNeedupdatetargetrequirevalueVectorBlock(FlatBufferBuilder builder, ArraySegment<bool> data)
		{
			builder.StartVector(1, data.Count, 1);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddBool(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateNeedupdatetargetrequirevalueVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartNeedupdatetargetrequirevalueVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<SeasonalMissionData> EndSeasonalMissionData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<SeasonalMissionData>(o);
		}

		public SeasonalMissionDataT UnPack()
		{
			var _o = new SeasonalMissionDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(SeasonalMissionDataT _o)
		{
			_o.Missionidx = this.Missionidx;
			_o.Missionvalue = new List<string>();
			for (var _j = 0; _j < this.MissionvalueLength; ++_j)
				_o.Missionvalue.Add(this.Missionvalue(_j));
			_o.Missioncomplete = new List<bool>();
			for (var _j = 0; _j < this.MissioncompleteLength; ++_j)
				_o.Missioncomplete.Add(this.Missioncomplete(_j));
			_o.Missionneedvalue = new List<string>();
			for (var _j = 0; _j < this.MissionneedvalueLength; ++_j)
				_o.Missionneedvalue.Add(this.Missionneedvalue(_j));
			_o.Needupdatetargetrequirevalue = new List<bool>();
			for (var _j = 0; _j < this.NeedupdatetargetrequirevalueLength; ++_j)
				_o.Needupdatetargetrequirevalue.Add(this.Needupdatetargetrequirevalue(_j));
		}

		public static Offset<SeasonalMissionData> Pack(FlatBufferBuilder builder, SeasonalMissionDataT _o)
		{
			if (_o == null) return default(Offset<SeasonalMissionData>);
			var _missionvalue = default(VectorOffset);
			if (_o.Missionvalue != null)
			{
				var __missionvalue = new StringOffset[_o.Missionvalue.Count];
				for (int _j = 0; _j < _o.Missionvalue.Count; _j++) __missionvalue[_j] = builder.CreateString(_o.Missionvalue[_j]);
				_missionvalue = CreateMissionvalueVector(builder, __missionvalue);
			}
			var _missioncomplete = default(VectorOffset);
			if (_o.Missioncomplete != null)
			{
				_missioncomplete = CreateMissioncompleteVector(builder, _o.Missioncomplete.ToArray());
			}
			var _missionneedvalue = default(VectorOffset);
			if (_o.Missionneedvalue != null)
			{
				var __missionneedvalue = new StringOffset[_o.Missionneedvalue.Count];
				for (int _j = 0; _j < _o.Missionneedvalue.Count; _j++) __missionneedvalue[_j] = builder.CreateString(_o.Missionneedvalue[_j]);
				_missionneedvalue = CreateMissionneedvalueVector(builder, __missionneedvalue);
			}
			var _needupdatetargetrequirevalue = default(VectorOffset);
			if (_o.Needupdatetargetrequirevalue != null)
			{
				var __needupdatetargetrequirevalue = _o.Needupdatetargetrequirevalue.ToArray();
				_needupdatetargetrequirevalue = CreateNeedupdatetargetrequirevalueVector(builder, __needupdatetargetrequirevalue);
			}
			StartSeasonalMissionData(builder);
			AddMissionidx(builder, _o.Missionidx);
			AddMissionvalue(builder, _missionvalue);
			AddMissioncomplete(builder, _missioncomplete);
			AddMissionneedvalue(builder, _missionneedvalue);
			AddNeedupdatetargetrequirevalue(builder, _needupdatetargetrequirevalue);
			return EndSeasonalMissionData(builder);
		}
	}
}
