using System.Runtime.CompilerServices;

public class DecoramaEvents
{
	public delegate void BoolDelegate(bool boolean);

	public delegate void BasicDelegate();

	public delegate void DecoramaBuildUpdatedDelegate(bool pointerDown);

	public delegate void DecoramaUpdatedDelegate(Decorama visibleDecorama);

	public delegate void DecoramaStateDelegate(DecoramaState decoramaState);

	public delegate void DecoramaCompletedDelegate(int index, string decoramaID);

	public static event DecoramaBuildUpdatedDelegate DecoramaBuildEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event BoolDelegate DecoramaQueuePreviewEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event DecoramaUpdatedDelegate DecoramaUpdatedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event DecoramaStateDelegate DecoramaSceneLoadedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event DecoramaStateDelegate DecoramaUIStateChangedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event DecoramaCompletedDelegate DecoramaCompletedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static void SendDecoramaBuildEvent(bool pointerDown)
	{
	}

	public static void SendDecoramaQueuePreviewEvent(bool leftPreview)
	{
	}

	public static void SendDecoramaUpdatedEvent(Decorama visibleDecorama)
	{
	}

	public static void SendDecoramaSceneLoadedEvent(DecoramaState decoramaState)
	{
	}

	public static void SendDecoramaUIStateChangedEvent(DecoramaState decoramaState)
	{
	}

	public static void SendDecoramaCompletedEvent(int index, string decoramaID)
	{
	}
}
