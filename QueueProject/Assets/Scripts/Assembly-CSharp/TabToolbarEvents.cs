using System;

public class TabToolbarEvents
{
	public delegate void EnableNotificationDelegate(int tabIndex, bool sticky);

	public delegate void TabChangedDelegate(int tabIndex, bool immediately);

	public static EnableNotificationDelegate AddNotification;

	public static Action<int> ClearNotification;

	public static TabChangedDelegate TabChange;

	public static Action<int> Swiped;

	public static Action<float> Dragged;

	public static Action SwipeCancelled;

	public static Action<int> LockedTabClicked;

	public static Action<int> TabLocked;

	public static Action<int> TabUnlocked;

	public static Action<bool> TabChangingEnabledChanged;

	public static void SendAddNotification(int tabIndex, bool sticky = false)
	{
	}

	public static void SendClearNotification(int tabIndex)
	{
	}

	public static void SendTabChange(int tabIndex, bool immediately = false)
	{
	}

	public static void SendSwiped(int dir)
	{
	}

	public static void SendDragged(float amount)
	{
	}

	public static void SendSwipeCancelled()
	{
	}

	public static void SendLockedTabClicked(int tabIndex)
	{
	}

	public static void SendTabLocked(int tabIndex)
	{
	}

	public static void SendTabUnlocked(int tabIndex)
	{
	}

	public static void SendTabChangingEnabledChanged(bool value)
	{
	}
}
