using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct DailyQuestData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Daypoint { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Weekpoint { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Dayresettime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Weekresettime { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int CompletequestLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int GetrewardsLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int GetweekrewardsLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int GetweekreplacesLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int QuestsLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static DailyQuestData GetRootAsDailyQuestData(ByteBuffer _bb)
		{
			return GetRootAsDailyQuestData(_bb, new DailyQuestData());
		}

		public static DailyQuestData GetRootAsDailyQuestData(ByteBuffer _bb, DailyQuestData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public DailyQuestData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateDaypoint(int daypoint)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, daypoint);
				return true;
			}
			return false;
		}

		public bool MutateWeekpoint(int weekpoint)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, weekpoint);
				return true;
			}
			return false;
		}

		public bool MutateDayresettime(long dayresettime)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, dayresettime);
				return true;
			}
			return false;
		}

		public bool MutateWeekresettime(long weekresettime)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, weekresettime);
				return true;
			}
			return false;
		}

		public int Completequest(int j)
		{
			int o = __p.__offset(12);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetCompletequestBytes()
		{
			return __p.__vector_as_arraysegment(22);
		}

		public int[] GetCompletequestArray()
		{
			return null;
		}

		public bool MutateCompletequest(int j, int completequest)
		{
			return false;
		}

		public int Getrewards(int j)
		{
			int o = __p.__offset(14);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetGetrewardsBytes()
		{
			return __p.__vector_as_arraysegment(24);
		}

		public int[] GetGetrewardsArray()
		{
			return null;
		}

		public bool MutateGetrewards(int j, int getrewards)
		{
			return false;
		}

		public int Getweekrewards(int j)
		{
			int o = __p.__offset(16);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetGetweekrewardsBytes()
		{
			return __p.__vector_as_arraysegment(26);
		}

		public int[] GetGetweekrewardsArray()
		{
			return null;
		}

		public bool MutateGetweekrewards(int j, int getweekrewards)
		{
			return false;
		}

		public int Getweekreplaces(int j)
		{
			int o = __p.__offset(18);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetGetweekreplacesBytes()
		{
			return __p.__vector_as_arraysegment(28);
		}

		public int[] GetGetweekreplacesArray()
		{
			return null;
		}

		public bool MutateGetweekreplaces(int j, int getweekreplaces)
		{
			return false;
		}

		public KeyValueLong? Quests(int j)
		{
			int o = __p.__offset(20);
			return o != 0 ? (new KeyValueLong()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public static Offset<DailyQuestData> CreateDailyQuestData(FlatBufferBuilder builder, int daypoint = 0, int weekpoint = 0, long dayresettime = 0L, long weekresettime = 0L, VectorOffset completequestOffset = default(VectorOffset), VectorOffset getrewardsOffset = default(VectorOffset), VectorOffset getweekrewardsOffset = default(VectorOffset), VectorOffset getweekreplacesOffset = default(VectorOffset), VectorOffset questsOffset = default(VectorOffset))
		{
			builder.StartTable(9);
			AddQuests(builder, questsOffset);
			AddGetweekreplaces(builder, getweekreplacesOffset);
			AddGetweekrewards(builder, getweekrewardsOffset);
			AddGetrewards(builder, getrewardsOffset);
			AddCompletequest(builder, completequestOffset);
			AddWeekresettime(builder, weekresettime);
			AddDayresettime(builder, dayresettime);
			AddWeekpoint(builder, weekpoint);
			AddDaypoint(builder, daypoint);
			return EndDailyQuestData(builder);
		}

		public static void StartDailyQuestData(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		public static void AddDaypoint(FlatBufferBuilder builder, int daypoint)
		{
			builder.AddInt(0, daypoint, 0);
		}

		public static void AddWeekpoint(FlatBufferBuilder builder, int weekpoint)
		{
			builder.AddInt(1, weekpoint, 0);
		}

		public static void AddDayresettime(FlatBufferBuilder builder, long dayresettime)
		{
			builder.AddLong(2, dayresettime, 0);
		}

		public static void AddWeekresettime(FlatBufferBuilder builder, long weekresettime)
		{
			builder.AddLong(3, weekresettime, 0);
		}

		public static void AddCompletequest(FlatBufferBuilder builder, VectorOffset completequestOffset)
		{
			builder.AddOffset(4, completequestOffset.Value, 0);
		}

		public static VectorOffset CreateCompletequestVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateCompletequestVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompletequestVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateCompletequestVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartCompletequestVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddGetrewards(FlatBufferBuilder builder, VectorOffset getrewardsOffset)
		{
			builder.AddOffset(5, getrewardsOffset.Value, 0);
		}

		public static VectorOffset CreateGetrewardsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateGetrewardsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateGetrewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateGetrewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartGetrewardsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddGetweekrewards(FlatBufferBuilder builder, VectorOffset getweekrewardsOffset)
		{
			builder.AddOffset(6, getweekrewardsOffset.Value, 0);
		}

		public static VectorOffset CreateGetweekrewardsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateGetweekrewardsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateGetweekrewardsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateGetweekrewardsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartGetweekrewardsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddGetweekreplaces(FlatBufferBuilder builder, VectorOffset getweekreplacesOffset)
		{
			builder.AddOffset(7, getweekreplacesOffset.Value, 0);
		}

		public static VectorOffset CreateGetweekreplacesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateGetweekreplacesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateGetweekreplacesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateGetweekreplacesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartGetweekreplacesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddQuests(FlatBufferBuilder builder, VectorOffset questsOffset)
		{
			builder.AddOffset(8, questsOffset.Value, 0);
		}

		public static VectorOffset CreateQuestsVector(FlatBufferBuilder builder, Offset<KeyValueLong>[] data)
		{
			builder.StartVector(8, data.Length, 8);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, Offset<KeyValueLong>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValueLong>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartQuestsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<DailyQuestData> EndDailyQuestData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<DailyQuestData>(o);
		}

		public DailyQuestDataT UnPack()
		{
			var _o = new DailyQuestDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(DailyQuestDataT _o)
		{
			_o.Daypoint = this.Daypoint;
			_o.Weekpoint = this.Weekpoint;
			_o.Dayresettime = this.Dayresettime;
			_o.Weekresettime = this.Weekresettime;
			_o.Completequest = new List<int>();
			for (var _j = 0; _j < this.CompletequestLength; ++_j)
				_o.Completequest.Add(this.Completequest(_j));
			_o.Getrewards = new List<int>();
			for (var _j = 0; _j < this.GetrewardsLength; ++_j)
				_o.Getrewards.Add(this.Getrewards(_j));
			_o.Getweekrewards = new List<int>();
			for (var _j = 0; _j < this.GetweekrewardsLength; ++_j)
				_o.Getweekrewards.Add(this.Getweekrewards(_j));
			_o.Getweekreplaces = new List<int>();
			for (var _j = 0; _j < this.GetweekreplacesLength; ++_j)
				_o.Getweekreplaces.Add(this.Getweekreplaces(_j));
			_o.Quests = new List<KeyValueLongT>();
			for (var _j = 0; _j < this.QuestsLength; ++_j)
				_o.Quests.Add(this.Quests(_j).HasValue ? this.Quests(_j).Value.UnPack() : null);
		}

		public static Offset<DailyQuestData> Pack(FlatBufferBuilder builder, DailyQuestDataT _o)
		{
			if (_o == null) return default(Offset<DailyQuestData>);
			var _completequest = default(VectorOffset);
			if (_o.Completequest != null)
			{
				var __completequest = _o.Completequest.ToArray();
				_completequest = CreateCompletequestVector(builder, __completequest);
			}
			var _getrewards = default(VectorOffset);
			if (_o.Getrewards != null)
			{
				var __getrewards = _o.Getrewards.ToArray();
				_getrewards = CreateGetrewardsVector(builder, __getrewards);
			}
			var _getweekrewards = default(VectorOffset);
			if (_o.Getweekrewards != null)
			{
				var __getweekrewards = _o.Getweekrewards.ToArray();
				_getweekrewards = CreateGetweekrewardsVector(builder, __getweekrewards);
			}
			var _getweekreplaces = default(VectorOffset);
			if (_o.Getweekreplaces != null)
			{
				var __getweekreplaces = _o.Getweekreplaces.ToArray();
				_getweekreplaces = CreateGetweekreplacesVector(builder, __getweekreplaces);
			}
			var _quests = default(VectorOffset);
			if (_o.Quests != null)
			{
				var __quests = new Offset<KeyValueLong>[_o.Quests.Count];
				for (var _j = 0; _j < _o.Quests.Count; ++_j)
					__quests[_j] = KeyValueLong.Pack(builder, _o.Quests[_j]);
				_quests = CreateQuestsVector(builder, __quests);
			}
			StartDailyQuestData(builder);
			AddDaypoint(builder, _o.Daypoint);
			AddWeekpoint(builder, _o.Weekpoint);
			AddDayresettime(builder, _o.Dayresettime);
			AddWeekresettime(builder, _o.Weekresettime);
			AddCompletequest(builder, _completequest);
			AddGetrewards(builder, _getrewards);
			AddGetweekrewards(builder, _getweekrewards);
			AddGetweekreplaces(builder, _getweekreplaces);
			AddQuests(builder, _quests);
			return EndDailyQuestData(builder);
		}
	}
}
