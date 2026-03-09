using System;
using UnityEngine.Purchasing;
using UnityEngine.Purchasing.Extension;

namespace Hiro.Unity
{
	public sealed class PurchaseFailureException : Exception
	{
		public PurchaseFailureReason Reason { get; }

		public PurchaseFailureException(PurchaseFailureReason reason)
		{
		}

		public PurchaseFailureException(PurchaseFailureDescription description)
		{
		}
	}
}
