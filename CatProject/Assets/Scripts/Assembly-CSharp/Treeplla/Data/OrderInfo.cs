using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OrderInfo : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer => null;

		public int Rewardtype => 0;

		public int Ordertype => 0;

		public int Orderstate => 0;

		public int Profilepath => 0;

		public int Ordermentionidx => 0;

		public int Refusementionidx => 0;

		public int Treegrade => 0;

		public int Treecount => 0;

		public int Rewardcoin => 0;

		public int Rewardbiz => 0;

		public int Rewardnail => 0;

		public int Rewardpaint => 0;

		public int Estimatedvalue => 0;

		public static void ValidateVersion()
		{
		}

		public static OrderInfo GetRootAsOrderInfo(ByteBuffer _bb)
		{
			return default(OrderInfo);
		}

		public static OrderInfo GetRootAsOrderInfo(ByteBuffer _bb, OrderInfo obj)
		{
			return default(OrderInfo);
		}

		public void __init(int _i, ByteBuffer _bb)
		{
		}

		public OrderInfo __assign(int _i, ByteBuffer _bb)
		{
			return default(OrderInfo);
		}

		public bool MutateRewardtype(int rewardtype)
		{
			return false;
		}

		public bool MutateOrdertype(int ordertype)
		{
			return false;
		}

		public bool MutateOrderstate(int orderstate)
		{
			return false;
		}

		public bool MutateProfilepath(int profilepath)
		{
			return false;
		}

		public bool MutateOrdermentionidx(int ordermentionidx)
		{
			return false;
		}

		public bool MutateRefusementionidx(int refusementionidx)
		{
			return false;
		}

		public bool MutateTreegrade(int treegrade)
		{
			return false;
		}

		public bool MutateTreecount(int treecount)
		{
			return false;
		}

		public bool MutateRewardcoin(int rewardcoin)
		{
			return false;
		}

		public bool MutateRewardbiz(int rewardbiz)
		{
			return false;
		}

		public bool MutateRewardnail(int rewardnail)
		{
			return false;
		}

		public bool MutateRewardpaint(int rewardpaint)
		{
			return false;
		}

		public bool MutateEstimatedvalue(int estimatedvalue)
		{
			return false;
		}

		public static Offset<OrderInfo> CreateOrderInfo(FlatBufferBuilder builder, int rewardtype = 0, int ordertype = 0, int orderstate = 0, int profilepath = 0, int ordermentionidx = 0, int refusementionidx = 0, int treegrade = 0, int treecount = 0, int rewardcoin = 0, int rewardbiz = 0, int rewardnail = 0, int rewardpaint = 0, int estimatedvalue = 0)
		{
			return default(Offset<OrderInfo>);
		}

		public static void StartOrderInfo(FlatBufferBuilder builder)
		{
		}

		public static void AddRewardtype(FlatBufferBuilder builder, int rewardtype)
		{
		}

		public static void AddOrdertype(FlatBufferBuilder builder, int ordertype)
		{
		}

		public static void AddOrderstate(FlatBufferBuilder builder, int orderstate)
		{
		}

		public static void AddProfilepath(FlatBufferBuilder builder, int profilepath)
		{
		}

		public static void AddOrdermentionidx(FlatBufferBuilder builder, int ordermentionidx)
		{
		}

		public static void AddRefusementionidx(FlatBufferBuilder builder, int refusementionidx)
		{
		}

		public static void AddTreegrade(FlatBufferBuilder builder, int treegrade)
		{
		}

		public static void AddTreecount(FlatBufferBuilder builder, int treecount)
		{
		}

		public static void AddRewardcoin(FlatBufferBuilder builder, int rewardcoin)
		{
		}

		public static void AddRewardbiz(FlatBufferBuilder builder, int rewardbiz)
		{
		}

		public static void AddRewardnail(FlatBufferBuilder builder, int rewardnail)
		{
		}

		public static void AddRewardpaint(FlatBufferBuilder builder, int rewardpaint)
		{
		}

		public static void AddEstimatedvalue(FlatBufferBuilder builder, int estimatedvalue)
		{
		}

		public static Offset<OrderInfo> EndOrderInfo(FlatBufferBuilder builder)
		{
			return default(Offset<OrderInfo>);
		}

		public OrderInfoT UnPack()
		{
			return null;
		}

		public void UnPackTo(OrderInfoT _o)
		{
		}

		public static Offset<OrderInfo> Pack(FlatBufferBuilder builder, OrderInfoT _o)
		{
			return default(Offset<OrderInfo>);
		}
	}
}
