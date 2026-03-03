using System;
using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct AuctionData : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Stamina => 0;

		public long Staminachargetime => 0L;

		public long Staminafreetime => 0L;

		public long Staminaadtime => 0L;

		public int Staminaadview => 0;

		public bool Passactive => false;

		public int PassreceivelistLength => 0;

		public int PasspremiumreceivelistLength => 0;

		public int OrganizemanagerLength => 0;

		public int OrganizecoinLength => 0;

		public int Enemyidx => 0;

		public int EnemysLength => 0;

		public int Level => 0;

		public int Tier => 0;

		public bool Firstguideview => false;

		public int Score => 0;

		public bool Firstguideview2 => false;

		public int Usecoin => 0;

		public bool Passpremiumbonusreceived => false;

		public int Eventidx => 0;

		public static void ValidateVersion()
		{
		}

		public static AuctionData GetRootAsAuctionData(ByteBuffer _bb)
		{
			return default(AuctionData);
		}

		public static AuctionData GetRootAsAuctionData(ByteBuffer _bb, AuctionData obj)
		{
			return default(AuctionData);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public AuctionData __assign(int _i, ByteBuffer _bb)
		{
			return default(AuctionData);
		}

		public bool MutateStamina(int stamina)
		{
			return false;
		}

		public bool MutateStaminachargetime(long staminachargetime)
		{
			return false;
		}

		public bool MutateStaminafreetime(long staminafreetime)
		{
			return false;
		}

		public bool MutateStaminaadtime(long staminaadtime)
		{
			return false;
		}

		public bool MutateStaminaadview(int staminaadview)
		{
			return false;
		}

		public bool MutatePassactive(bool passactive)
		{
			return false;
		}

		public int Passreceivelist(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetPassreceivelistBytes()
		{
			return null;
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
			return 0;
		}

		public ArraySegment<byte>? GetPasspremiumreceivelistBytes()
		{
			return null;
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
			return null;
		}

		public KeyValue? Organizecoin(int j)
		{
			return null;
		}

		public bool MutateEnemyidx(int enemyidx)
		{
			return false;
		}

		public int Enemys(int j)
		{
			return 0;
		}

		public ArraySegment<byte>? GetEnemysBytes()
		{
			return null;
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
			return false;
		}

		public bool MutateTier(int tier)
		{
			return false;
		}

		public bool MutateFirstguideview(bool firstguideview)
		{
			return false;
		}

		public bool MutateScore(int score)
		{
			return false;
		}

		public bool MutateFirstguideview2(bool firstguideview2)
		{
			return false;
		}

		public bool MutateUsecoin(int usecoin)
		{
			return false;
		}

		public bool MutatePasspremiumbonusreceived(bool passpremiumbonusreceived)
		{
			return false;
		}

		public bool MutateEventidx(int eventidx)
		{
			return false;
		}

		public static Offset<AuctionData> CreateAuctionData(FlatBufferBuilder builder, int stamina = 0, long staminachargetime = 0L, long staminafreetime = 0L, long staminaadtime = 0L, int staminaadview = 0, bool passactive = false, VectorOffset passreceivelistOffset = default(VectorOffset), VectorOffset passpremiumreceivelistOffset = default(VectorOffset), VectorOffset organizemanagerOffset = default(VectorOffset), VectorOffset organizecoinOffset = default(VectorOffset), int enemyidx = -1, VectorOffset enemysOffset = default(VectorOffset), int level = -1, int tier = -1, bool firstguideview = false, int score = 0, bool firstguideview2 = false, int usecoin = 0, bool passpremiumbonusreceived = false, int eventidx = -1)
		{
			return default(Offset<AuctionData>);
		}

		public static void StartAuctionData(FlatBufferBuilder builder)
		{
		}

		public static void AddStamina(FlatBufferBuilder builder, int stamina)
		{
		}

		public static void AddStaminachargetime(FlatBufferBuilder builder, long staminachargetime)
		{
		}

		public static void AddStaminafreetime(FlatBufferBuilder builder, long staminafreetime)
		{
		}

		public static void AddStaminaadtime(FlatBufferBuilder builder, long staminaadtime)
		{
		}

		public static void AddStaminaadview(FlatBufferBuilder builder, int staminaadview)
		{
		}

		public static void AddPassactive(FlatBufferBuilder builder, bool passactive)
		{
		}

		public static void AddPassreceivelist(FlatBufferBuilder builder, VectorOffset passreceivelistOffset)
		{
		}

		public static VectorOffset CreatePassreceivelistVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePassreceivelistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePassreceivelistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePassreceivelistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartPassreceivelistVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddPasspremiumreceivelist(FlatBufferBuilder builder, VectorOffset passpremiumreceivelistOffset)
		{
		}

		public static VectorOffset CreatePasspremiumreceivelistVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePasspremiumreceivelistVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePasspremiumreceivelistVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreatePasspremiumreceivelistVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartPasspremiumreceivelistVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddOrganizemanager(FlatBufferBuilder builder, VectorOffset organizemanagerOffset)
		{
		}

		public static VectorOffset CreateOrganizemanagerVector(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOrganizemanagerVectorBlock(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOrganizemanagerVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValue>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOrganizemanagerVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartOrganizemanagerVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddOrganizecoin(FlatBufferBuilder builder, VectorOffset organizecoinOffset)
		{
		}

		public static VectorOffset CreateOrganizecoinVector(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOrganizecoinVectorBlock(FlatBufferBuilder builder, Offset<KeyValue>[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOrganizecoinVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<KeyValue>> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateOrganizecoinVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartOrganizecoinVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddEnemyidx(FlatBufferBuilder builder, int enemyidx)
		{
		}

		public static void AddEnemys(FlatBufferBuilder builder, VectorOffset enemysOffset)
		{
		}

		public static VectorOffset CreateEnemysVector(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateEnemysVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateEnemysVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			return default(VectorOffset);
		}

		public static VectorOffset CreateEnemysVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			return default(VectorOffset);
		}

		public static void StartEnemysVector(FlatBufferBuilder builder, int numElems)
		{
		}

		public static void AddLevel(FlatBufferBuilder builder, int level)
		{
		}

		public static void AddTier(FlatBufferBuilder builder, int tier)
		{
		}

		public static void AddFirstguideview(FlatBufferBuilder builder, bool firstguideview)
		{
		}

		public static void AddScore(FlatBufferBuilder builder, int score)
		{
		}

		public static void AddFirstguideview2(FlatBufferBuilder builder, bool firstguideview2)
		{
		}

		public static void AddUsecoin(FlatBufferBuilder builder, int usecoin)
		{
		}

		public static void AddPasspremiumbonusreceived(FlatBufferBuilder builder, bool passpremiumbonusreceived)
		{
		}

		public static void AddEventidx(FlatBufferBuilder builder, int eventidx)
		{
		}

		public static Offset<AuctionData> EndAuctionData(FlatBufferBuilder builder)
		{
			return default(Offset<AuctionData>);
		}

		public AuctionDataT UnPack()
		{
			return null;
		}

		public void UnPackTo(AuctionDataT _o)
		{
		}

		public static Offset<AuctionData> Pack(FlatBufferBuilder builder, AuctionDataT _o)
		{
			return default(Offset<AuctionData>);
		}
	}
}
