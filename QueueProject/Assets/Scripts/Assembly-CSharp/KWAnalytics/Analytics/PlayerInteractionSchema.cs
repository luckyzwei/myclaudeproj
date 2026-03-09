using System;

namespace KWAnalytics.Analytics
{
	[Serializable]
	public class PlayerInteractionSchema : ClosedSchema
	{
		public enum InteractionAction
		{
			TOGGLED = 0,
			COLLECT = 1,
			DOUBLE = 2,
			TRIPLE = 3,
			ACCEPT = 4,
			DECLINE = 5,
			CORRECT = 6,
			WRONG = 7,
			CLICK = 8,
			EXIT = 9,
			NONE = 10
		}

		public PlayerInteractionSchema(string systemInteractWith, InteractionAction interactionAction, int value)
		{
		}

		public PlayerInteractionSchema(string systemInteractWith, string interactionAction, int value)
		{
		}
	}
}
