using System;
using UnityEngine.Purchasing;

namespace Hiro.Unity
{
	public sealed class InitializationFailureException : Exception
	{
		public InitializationFailureReason Reason { get; }

		public InitializationFailureException(InitializationFailureReason reason)
		{
		}
	}
}
