using System;
using System.Threading;
using UnityEngine;

namespace KWCore.Utils
{
	internal class WaitForThreadedTask : CustomYieldInstruction
	{
		private bool isRunning;

		public override bool keepWaiting => false;

		public WaitForThreadedTask(Action task, System.Threading.ThreadPriority priority = System.Threading.ThreadPriority.Normal)
		{
		}
	}
}
