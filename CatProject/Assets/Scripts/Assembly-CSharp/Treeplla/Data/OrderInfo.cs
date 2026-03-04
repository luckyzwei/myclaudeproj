using Google.FlatBuffers;

namespace Treeplla.Data
{
	public struct OrderInfo : IFlatbufferObject
	{
		private Google.FlatBuffers.Table __p;

		public ByteBuffer ByteBuffer { get { return __p.bb; } }

		public int Rewardtype { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Ordertype { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Orderstate { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Profilepath { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Ordermentionidx { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Refusementionidx { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Treegrade { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Treecount { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Rewardcoin { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Rewardbiz { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Rewardnail { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Rewardpaint { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public int Estimatedvalue { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_23_5_26();
		}

		public static OrderInfo GetRootAsOrderInfo(ByteBuffer _bb)
		{
			return GetRootAsOrderInfo(_bb, new OrderInfo());
		}

		public static OrderInfo GetRootAsOrderInfo(ByteBuffer _bb, OrderInfo obj)
		{
			return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb));
		}

		public void __init(int _i, ByteBuffer _bb)
		{
			__p.bb_pos = _i; __p.bb = _bb;
		}

		public OrderInfo __assign(int _i, ByteBuffer _bb)
		{
			__init(_i, _bb);
			return this;
		}

		public bool MutateRewardtype(int rewardtype)
		{
			int o = __p.__offset(4);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, rewardtype);
				return true;
			}
			return false;
		}

		public bool MutateOrdertype(int ordertype)
		{
			int o = __p.__offset(6);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, ordertype);
				return true;
			}
			return false;
		}

		public bool MutateOrderstate(int orderstate)
		{
			int o = __p.__offset(8);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, orderstate);
				return true;
			}
			return false;
		}

		public bool MutateProfilepath(int profilepath)
		{
			int o = __p.__offset(10);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, profilepath);
				return true;
			}
			return false;
		}

		public bool MutateOrdermentionidx(int ordermentionidx)
		{
			int o = __p.__offset(12);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, ordermentionidx);
				return true;
			}
			return false;
		}

		public bool MutateRefusementionidx(int refusementionidx)
		{
			int o = __p.__offset(14);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, refusementionidx);
				return true;
			}
			return false;
		}

		public bool MutateTreegrade(int treegrade)
		{
			int o = __p.__offset(16);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, treegrade);
				return true;
			}
			return false;
		}

		public bool MutateTreecount(int treecount)
		{
			int o = __p.__offset(18);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, treecount);
				return true;
			}
			return false;
		}

		public bool MutateRewardcoin(int rewardcoin)
		{
			int o = __p.__offset(20);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, rewardcoin);
				return true;
			}
			return false;
		}

		public bool MutateRewardbiz(int rewardbiz)
		{
			int o = __p.__offset(22);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, rewardbiz);
				return true;
			}
			return false;
		}

		public bool MutateRewardnail(int rewardnail)
		{
			int o = __p.__offset(24);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, rewardnail);
				return true;
			}
			return false;
		}

		public bool MutateRewardpaint(int rewardpaint)
		{
			int o = __p.__offset(26);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, rewardpaint);
				return true;
			}
			return false;
		}

		public bool MutateEstimatedvalue(int estimatedvalue)
		{
			int o = __p.__offset(28);
			if (o != 0)
			{
				__p.bb.PutInt(o + __p.bb_pos, estimatedvalue);
				return true;
			}
			return false;
		}

		public static Offset<OrderInfo> CreateOrderInfo(FlatBufferBuilder builder, int rewardtype = 0, int ordertype = 0, int orderstate = 0, int profilepath = 0, int ordermentionidx = 0, int refusementionidx = 0, int treegrade = 0, int treecount = 0, int rewardcoin = 0, int rewardbiz = 0, int rewardnail = 0, int rewardpaint = 0, int estimatedvalue = 0)
		{
			builder.StartTable(13);
			AddEstimatedvalue(builder, estimatedvalue);
			AddRewardpaint(builder, rewardpaint);
			AddRewardnail(builder, rewardnail);
			AddRewardbiz(builder, rewardbiz);
			AddRewardcoin(builder, rewardcoin);
			AddTreecount(builder, treecount);
			AddTreegrade(builder, treegrade);
			AddRefusementionidx(builder, refusementionidx);
			AddOrdermentionidx(builder, ordermentionidx);
			AddProfilepath(builder, profilepath);
			AddOrderstate(builder, orderstate);
			AddOrdertype(builder, ordertype);
			AddRewardtype(builder, rewardtype);
			return EndOrderInfo(builder);
		}

		public static void StartOrderInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		public static void AddRewardtype(FlatBufferBuilder builder, int rewardtype)
		{
			builder.AddInt(0, rewardtype, 0);
		}

		public static void AddOrdertype(FlatBufferBuilder builder, int ordertype)
		{
			builder.AddInt(1, ordertype, 0);
		}

		public static void AddOrderstate(FlatBufferBuilder builder, int orderstate)
		{
			builder.AddInt(2, orderstate, 0);
		}

		public static void AddProfilepath(FlatBufferBuilder builder, int profilepath)
		{
			builder.AddInt(3, profilepath, 0);
		}

		public static void AddOrdermentionidx(FlatBufferBuilder builder, int ordermentionidx)
		{
			builder.AddInt(4, ordermentionidx, 0);
		}

		public static void AddRefusementionidx(FlatBufferBuilder builder, int refusementionidx)
		{
			builder.AddInt(5, refusementionidx, 0);
		}

		public static void AddTreegrade(FlatBufferBuilder builder, int treegrade)
		{
			builder.AddInt(6, treegrade, 0);
		}

		public static void AddTreecount(FlatBufferBuilder builder, int treecount)
		{
			builder.AddInt(7, treecount, 0);
		}

		public static void AddRewardcoin(FlatBufferBuilder builder, int rewardcoin)
		{
			builder.AddInt(8, rewardcoin, 0);
		}

		public static void AddRewardbiz(FlatBufferBuilder builder, int rewardbiz)
		{
			builder.AddInt(9, rewardbiz, 0);
		}

		public static void AddRewardnail(FlatBufferBuilder builder, int rewardnail)
		{
			builder.AddInt(10, rewardnail, 0);
		}

		public static void AddRewardpaint(FlatBufferBuilder builder, int rewardpaint)
		{
			builder.AddInt(11, rewardpaint, 0);
		}

		public static void AddEstimatedvalue(FlatBufferBuilder builder, int estimatedvalue)
		{
			builder.AddInt(12, estimatedvalue, 0);
		}

		public static Offset<OrderInfo> EndOrderInfo(FlatBufferBuilder builder)
		{
			int o = builder.EndTable();
			return new Offset<OrderInfo>(o);
		}

		public OrderInfoT UnPack()
		{
			var _o = new OrderInfoT();
			UnPackTo(_o);
			return _o;
		}

		public void UnPackTo(OrderInfoT _o)
		{
			_o.Rewardtype = this.Rewardtype;
			_o.Ordertype = this.Ordertype;
			_o.Orderstate = this.Orderstate;
			_o.Profilepath = this.Profilepath;
			_o.Ordermentionidx = this.Ordermentionidx;
			_o.Refusementionidx = this.Refusementionidx;
			_o.Treegrade = this.Treegrade;
			_o.Treecount = this.Treecount;
			_o.Rewardcoin = this.Rewardcoin;
			_o.Rewardbiz = this.Rewardbiz;
			_o.Rewardnail = this.Rewardnail;
			_o.Rewardpaint = this.Rewardpaint;
			_o.Estimatedvalue = this.Estimatedvalue;
		}

		public static Offset<OrderInfo> Pack(FlatBufferBuilder builder, OrderInfoT _o)
		{
			if (_o == null) return default(Offset<OrderInfo>);
			StartOrderInfo(builder);
			AddRewardtype(builder, _o.Rewardtype);
			AddOrdertype(builder, _o.Ordertype);
			AddOrderstate(builder, _o.Orderstate);
			AddProfilepath(builder, _o.Profilepath);
			AddOrdermentionidx(builder, _o.Ordermentionidx);
			AddRefusementionidx(builder, _o.Refusementionidx);
			AddTreegrade(builder, _o.Treegrade);
			AddTreecount(builder, _o.Treecount);
			AddRewardcoin(builder, _o.Rewardcoin);
			AddRewardbiz(builder, _o.Rewardbiz);
			AddRewardnail(builder, _o.Rewardnail);
			AddRewardpaint(builder, _o.Rewardpaint);
			AddEstimatedvalue(builder, _o.Estimatedvalue);
			return EndOrderInfo(builder);
		}
	}
}
