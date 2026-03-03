using System.Collections;

namespace Newtonsoft.Json.ObservableSupport
{
	public class NotifyCollectionChangedEventArgs
	{
		internal NotifyCollectionChangedAction Action { get; set; }

		internal IList NewItems { get; set; }

		internal int NewStartingIndex { get; set; }

		internal IList OldItems { get; set; }

		internal int OldStartingIndex { get; set; }

		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action)
		{
		}

		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems)
		{
		}

		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem)
		{
		}

		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems)
		{
		}

		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
		{
		}

		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index)
		{
		}

		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem)
		{
		}

		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex)
		{
		}

		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int index, int oldIndex)
		{
		}

		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex)
		{
		}

		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index)
		{
		}
	}
}
