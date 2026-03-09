using Balancy.Models;
using Balancy.Models.Inventory;

namespace KWGameCore
{
	public static class KwaleeItemExtensions
	{
		public static int Count(this KwaleeItem item)
		{
			return 0;
		}

		public static void Add(this KwaleeItem item, int count)
		{
		}

		public static void Remove(this KwaleeItem item, int count)
		{
		}

		public static bool CanAfford(this Currency currency, long cost)
		{
			return false;
		}

		public static bool Purchase(this Currency currency, long cost)
		{
			return false;
		}

		public static void Add(this Currency currency, long value)
		{
		}
	}
}
