using System;
using System.Numerics;

namespace Treeplla
{
	public class StageMachineAlreadyData : ICloneable
	{
		public int level;

		public int nextlevel;

		public BigInteger ObjectValue;

		public BigInteger UpgradePrice;

		public object Clone()
		{
			return null;
		}
	}
}
