using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AuctionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Stamina { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public long Staminachargetime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Staminafreetime { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public long Staminaadtime { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0L; } }

		public int Staminaadview { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Passactive { get { int o = __p.__offset(14); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int PassreceivelistLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int PasspremiumreceivelistLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int OrganizemanagerLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int OrganizecoinLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Enemyidx { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int EnemysLength { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }

		public int Level { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Tier { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Firstguideview { get { int o = __p.__offset(32); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int Score { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Firstguideview2 { get { int o = __p.__offset(36); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int Usecoin { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public bool Passpremiumbonusreceived { get { int o = __p.__offset(40); return o != 0 && 0 != __p.bb.Get(o + __p.bb_pos); } }

		public int Eventidx { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static AuctionData GetRootAsAuctionData(ByteBuffer _bb)
		{
			return GetRootAsAuctionData(_bb, new AuctionData());
		}

		public static AuctionData GetRootAsAuctionData(ByteBuffer _bb, AuctionData obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public AuctionData __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateStamina(int stamina)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, stamina);
				return true;
			}
			return false;
		}

		public bool MutateStaminachargetime(long staminachargetime)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, staminachargetime);
				return true;
			}
			return false;
		}

		public bool MutateStaminafreetime(long staminafreetime)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, staminafreetime);
				return true;
			}
			return false;
		}

		public bool MutateStaminaadtime(long staminaadtime)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutLong(o + __p.bb_pos, staminaadtime);
				return true;
			}
			return false;
		}

		public bool MutateStaminaadview(int staminaadview)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, staminaadview);
				return true;
			}
			return false;
		}

		public bool MutatePassactive(bool passactive)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(passactive ? 1 : 0));
				return true;
			}
			return false;
		}

		public int Passreceivelist(int j)
		{
			int o = __p.__offset(16);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetPassreceivelistBytes()
		{
			return __p.__vector_as_arraysegment(44);
		}

		public int[] GetPassreceivelistArray()
		{
			return null;
		}

		public bool MutatePassreceivelist(int j, int passreceivelist)
		{
			return false;
		}

		public int Passpremiumreceivelist(int j)
		{
			int o = __p.__offset(18);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetPasspremiumreceivelistBytes()
		{
			return __p.__vector_as_arraysegment(46);
		}

		public int[] GetPasspremiumreceivelistArray()
		{
			return null;
		}

		public bool MutatePasspremiumreceivelist(int j, int passpremiumreceivelist)
		{
			return false;
		}

		public KeyValue? Organizemanager(int j)
		{
			int o = __p.__offset(20);
			return o != 0 ? (new KeyValue()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public KeyValue? Organizecoin(int j)
		{
			int o = __p.__offset(22);
			return o != 0 ? (new KeyValue()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null;
		}

		public bool MutateEnemyidx(int enemyidx)
		{
			int o = __p.__offset(24);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, enemyidx);
				return true;
			}
			return false;
		}

		public int Enemys(int j)
		{
			int o = __p.__offset(26);
			return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0;
		}

		public ArraySegment<byte>? GetEnemysBytes()
		{
			return __p.__vector_as_arraysegment(52);
		}

		public int[] GetEnemysArray()
		{
			return null;
		}

		public bool MutateEnemys(int j, int enemys)
		{
			return false;
		}

		public bool MutateLevel(int level)
		{
			int o = __p.__offset(28);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, level);
				return true;
			}
			return false;
		}

		public bool MutateTier(int tier)
		{
			int o = __p.__offset(30);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, tier);
				return true;
			}
			return false;
		}

		public bool MutateFirstguideview(bool firstguideview)
		{
			int o = __p.__offset(32);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(firstguideview ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateScore(int score)
		{
			int o = __p.__offset(34);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, score);
				return true;
			}
			return false;
		}

		public bool MutateFirstguideview2(bool firstguideview2)
		{
			int o = __p.__offset(36);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(firstguideview2 ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateUsecoin(int usecoin)
		{
			int o = __p.__offset(38);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, usecoin);
				return true;
			}
			return false;
		}

		public bool MutatePasspremiumbonusreceived(bool passpremiumbonusreceived)
		{
			int o = __p.__offset(40);
			if (o != 0)
			{
				__p.bb.Put(o + __p.bb_pos, (byte)(passpremiumbonusreceived ? 1 : 0));
				return true;
			}
			return false;
		}

		public bool MutateEventidx(int eventidx)
		{
			int o = __p.__offset(42);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, eventidx);
				return true;
			}
			return false;
		}

		public static Offset<AuctionData> CreateAuctionData(FlatBufferBuilder builder, int stamina = 0, long staminachargetime = 0L, long staminafreetime = 0L, long staminaadtime = 0L, int staminaadview = 0, bool passactive = false, VectorOffset passreceivelistOffset = default(VectorOffset), VectorOffset passpremiumreceivelistOffset = default(VectorOffset), VectorOffset organizemanagerOffset = default(VectorOffset), VectorOffset organizecoinOffset = default(VectorOffset), int enemyidx = -1, VectorOffset enemysOffset = default(VectorOffset), int level = -1, int tier = -1, bool firstguideview = false, int score = 0, bool firstguideview2 = false, int usecoin = 0, bool passpremiumbonusreceived = false, int eventidx = -1)
		{
			builder.StartTable(20);
			AddEventidx(builder, eventidx);
			AddPasspremiumbonusreceived(builder, passpremiumbonusreceived);
			AddUsecoin(builder, usecoin);
			AddFirstguideview2(builder, firstguideview2);
			AddScore(builder, score);
			AddFirstguideview(builder, firstguideview);
			AddTier(builder, tier);
			AddLevel(builder, level);
			AddEnemys(builder, enemysOffset);
			AddEnemyidx(builder, enemyidx);
			AddOrganizecoin(builder, organizecoinOffset);
			AddOrganizemanager(builder, organizemanagerOffset);
			AddPasspremiumreceivelist(builder, passpremiumreceivelistOffset);
			AddPassreceivelist(builder, passreceivelistOffset);
			AddPassactive(builder, passactive);
			AddStaminaadview(builder, staminaadview);
			AddStaminaadtime(builder, staminaadtime);
			AddStaminafreetime(builder, staminafreetime);
			AddStaminachargetime(builder, staminachargetime);
			AddStamina(builder, stamina);
			return EndAuctionData(builder);
		}

		public static void StartAuctionData(FlatBufferBuilder builder)
		{
			builder.StartTable(25);
		}

		public static void AddStamina(FlatBufferBuilder builder, int stamina)
		{
			builder.AddInt(0, stamina, 0);
		}

		public static void AddStaminachargetime(FlatBufferBuilder builder, long staminachargetime)
		{
			builder.AddLong(1, staminachargetime, 0);
		}

		public static void AddStaminafreetime(FlatBufferBuilder builder, long staminafreetime)
		{
			builder.AddLong(2, staminafreetime, 0);
		}

		public static void AddStaminaadtime(FlatBufferBuilder builder, long staminaadtime)
		{
			builder.AddLong(3, staminaadtime, 0);
		}

		public static void AddStaminaadview(FlatBufferBuilder builder, int staminaadview)
		{
			builder.AddInt(4, staminaadview, 0);
		}

		public static void AddPassactive(FlatBufferBuilder builder, bool passactive)
		{
			builder.AddBool(5, passactive, false);
		}

		public static void AddPassreceivelist(FlatBufferBuilder builder, VectorOffset passreceivelistOffset)
		{
			builder.AddOffset(6, passreceivelistOffset.Value, 0);
		}

		public static VectorOffset CreatePassreceivelistVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreatePassreceivelistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreatePassreceivelistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreatePassreceivelistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartPassreceivelistVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddPasspremiumreceivelist(FlatBufferBuilder builder, VectorOffset passpremiumreceivelistOffset)
		{
			builder.AddOffset(7, passpremiumreceivelistOffset.Value, 0);
		}

		public static VectorOffset CreatePasspremiumreceivelistVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreatePasspremiumreceivelistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreatePasspremiumreceivelistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreatePasspremiumreceivelistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartPasspremiumreceivelistVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddOrganizemanager(FlatBufferBuilder builder, VectorOffset organizemanagerOffset)
		{
			builder.AddOffset(8, organizemanagerOffset.Value, 0);
		}

		public static VectorOffset CreateOrganizemanagerVector(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateOrganizemanagerVectorBlock(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOrganizemanagerVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValue>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOrganizemanagerVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartOrganizemanagerVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddOrganizecoin(FlatBufferBuilder builder, VectorOffset organizecoinOffset)
		{
			builder.AddOffset(9, organizecoinOffset.Value, 0);
		}

		public static VectorOffset CreateOrganizecoinVector(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateOrganizecoinVectorBlock(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddOffset(data[i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOrganizecoinVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValue>> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddOffset(data.Array[data.Offset + i].Value);
			return builder.EndVector();
		}

		public static VectorOffset CreateOrganizecoinVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartOrganizecoinVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddEnemyidx(FlatBufferBuilder builder, int enemyidx)
		{
			builder.AddInt(10, enemyidx, 0);
		}

		public static void AddEnemys(FlatBufferBuilder builder, VectorOffset enemysOffset)
		{
			builder.AddOffset(11, enemysOffset.Value, 0);
		}

		public static VectorOffset CreateEnemysVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		public static VectorOffset CreateEnemysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
				builder.AddInt(data[i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateEnemysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			for (int i = data.Count - 1; i >= 0; i--)
				builder.AddInt(data.Array[data.Offset + i]);
			return builder.EndVector();
		}

		public static VectorOffset CreateEnemysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<byte>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		public static void StartEnemysVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
			builder.AddInt(12, level, 0);
		}

		public static void AddTier(FlatBufferBuilder builder, int tier)
		{
			builder.AddInt(13, tier, 0);
		}

		public static void AddFirstguideview(FlatBufferBuilder builder, bool firstguideview)
		{
			builder.AddBool(14, firstguideview, false);
		}

		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(15, score, 0);
		}

		public static void AddFirstguideview2(FlatBufferBuilder builder, bool firstguideview2)
		{
			builder.AddBool(16, firstguideview2, false);
		}

		public static void AddUsecoin(FlatBufferBuilder builder, int usecoin)
		{
			builder.AddInt(17, usecoin, 0);
		}

		public static void AddPasspremiumbonusreceived(FlatBufferBuilder builder, bool passpremiumbonusreceived)
		{
			builder.AddBool(18, passpremiumbonusreceived, false);
		}

		public static void AddEventidx(FlatBufferBuilder builder, int eventidx)
		{
			builder.AddInt(19, eventidx, 0);
		}

		public static Offset<AuctionData> EndAuctionData(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<AuctionData>(o);
		}

		public AuctionDataT UnPack()
		{
			var _o = new AuctionDataT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(AuctionDataT _o)
		{
			_o.Stamina = this.Stamina;
			_o.Staminachargetime = this.Staminachargetime;
			_o.Staminafreetime = this.Staminafreetime;
			_o.Staminaadtime = this.Staminaadtime;
			_o.Staminaadview = this.Staminaadview;
			_o.Passactive = this.Passactive;
			_o.Passreceivelist = new List<int>();
			for (var _j = 0; _j < this.PassreceivelistLength; ++_j)
				_o.Passreceivelist.Add(this.Passreceivelist(_j));
			_o.Passpremiumreceivelist = new List<int>();
			for (var _j = 0; _j < this.PasspremiumreceivelistLength; ++_j)
				_o.Passpremiumreceivelist.Add(this.Passpremiumreceivelist(_j));
			_o.Organizemanager = new List<KeyValueT>();
			for (var _j = 0; _j < this.OrganizemanagerLength; ++_j)
				_o.Organizemanager.Add(this.Organizemanager(_j).HasValue ? this.Organizemanager(_j).Value.UnPack() : null);
			_o.Organizecoin = new List<KeyValueT>();
			for (var _j = 0; _j < this.OrganizecoinLength; ++_j)
				_o.Organizecoin.Add(this.Organizecoin(_j).HasValue ? this.Organizecoin(_j).Value.UnPack() : null);
			_o.Enemyidx = this.Enemyidx;
			_o.Enemys = new List<int>();
			for (var _j = 0; _j < this.EnemysLength; ++_j)
				_o.Enemys.Add(this.Enemys(_j));
			_o.Level = this.Level;
			_o.Tier = this.Tier;
			_o.Firstguideview = this.Firstguideview;
			_o.Score = this.Score;
			_o.Firstguideview2 = this.Firstguideview2;
			_o.Usecoin = this.Usecoin;
			_o.Passpremiumbonusreceived = this.Passpremiumbonusreceived;
			_o.Eventidx = this.Eventidx;
		}

		public static Offset<AuctionData> Pack(FlatBufferBuilder builder, AuctionDataT _o)
		{
			if (_o == null) return default(Offset<AuctionData>);
			var _passreceivelist = default(VectorOffset);
			if (_o.Passreceivelist != null)
			{
				var __passreceivelist = _o.Passreceivelist.ToArray();
				_passreceivelist = CreatePassreceivelistVector(builder, __passreceivelist);
			}
			var _passpremiumreceivelist = default(VectorOffset);
			if (_o.Passpremiumreceivelist != null)
			{
				var __passpremiumreceivelist = _o.Passpremiumreceivelist.ToArray();
				_passpremiumreceivelist = CreatePasspremiumreceivelistVector(builder, __passpremiumreceivelist);
			}
			var _organizemanager = default(VectorOffset);
			if (_o.Organizemanager != null)
			{
				var __organizemanager = new Offset<KeyValue>[_o.Organizemanager.Count];
				for (var _j = 0; _j < _o.Organizemanager.Count; ++_j)
					__organizemanager[_j] = KeyValue.Pack(builder, _o.Organizemanager[_j]);
				_organizemanager = CreateOrganizemanagerVector(builder, __organizemanager);
			}
			var _organizecoin = default(VectorOffset);
			if (_o.Organizecoin != null)
			{
				var __organizecoin = new Offset<KeyValue>[_o.Organizecoin.Count];
				for (var _j = 0; _j < _o.Organizecoin.Count; ++_j)
					__organizecoin[_j] = KeyValue.Pack(builder, _o.Organizecoin[_j]);
				_organizecoin = CreateOrganizecoinVector(builder, __organizecoin);
			}
			var _enemys = default(VectorOffset);
			if (_o.Enemys != null)
			{
				var __enemys = _o.Enemys.ToArray();
				_enemys = CreateEnemysVector(builder, __enemys);
			}
			StartAuctionData(builder);
			AddStamina(builder, _o.Stamina);
			AddStaminachargetime(builder, _o.Staminachargetime);
			AddStaminafreetime(builder, _o.Staminafreetime);
			AddStaminaadtime(builder, _o.Staminaadtime);
			AddStaminaadview(builder, _o.Staminaadview);
			AddPassactive(builder, _o.Passactive);
			AddPassreceivelist(builder, _passreceivelist);
			AddPasspremiumreceivelist(builder, _passpremiumreceivelist);
			AddOrganizemanager(builder, _organizemanager);
			AddOrganizecoin(builder, _organizecoin);
			AddEnemyidx(builder, _o.Enemyidx);
			AddEnemys(builder, _enemys);
			AddLevel(builder, _o.Level);
			AddTier(builder, _o.Tier);
			AddFirstguideview(builder, _o.Firstguideview);
			AddScore(builder, _o.Score);
			AddFirstguideview2(builder, _o.Firstguideview2);
			AddUsecoin(builder, _o.Usecoin);
			AddPasspremiumbonusreceived(builder, _o.Passpremiumbonusreceived);
			AddEventidx(builder, _o.Eventidx);
			return EndAuctionData(builder);
		}
	}
}
