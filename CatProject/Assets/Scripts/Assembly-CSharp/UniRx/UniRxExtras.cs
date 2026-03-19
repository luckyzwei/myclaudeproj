using System;
using System.Collections.Generic;

namespace UniRx
{
	// ======== Pair<T> ========
	public struct Pair<T>
	{
		public T Previous;
		public T Current;
		public Pair(T previous, T current) { Previous = previous; Current = current; }
		public override string ToString() => $"({Previous}, {Current})";
	}

	// ======== AsyncSubject<T> ========
	public class AsyncSubject<T> : IObservable<T>, IObserver<T>, IDisposable
	{
		private T _value;
		private bool _hasValue;
		private bool _isCompleted;
		private bool _isDisposed;
		private Exception _error;
		private List<IObserver<T>> _observers = new List<IObserver<T>>();

		public T Value => _value;
		public bool HasValue => _hasValue;
		public bool IsCompleted => _isCompleted;

		public void OnNext(T value)
		{
			if (_isDisposed || _isCompleted) return;
			_value = value;
			_hasValue = true;
		}

		public void OnError(Exception error)
		{
			if (_isDisposed || _isCompleted) return;
			_error = error;
			_isCompleted = true;
			var copy = new List<IObserver<T>>(_observers);
			foreach (var obs in copy) { try { obs.OnError(error); } catch { } }
			_observers.Clear();
		}

		public void OnCompleted()
		{
			if (_isDisposed || _isCompleted) return;
			_isCompleted = true;
			var copy = new List<IObserver<T>>(_observers);
			foreach (var obs in copy)
			{
				try
				{
					if (_hasValue) obs.OnNext(_value);
					obs.OnCompleted();
				}
				catch { }
			}
			_observers.Clear();
		}

		public IDisposable Subscribe(IObserver<T> observer)
		{
			if (_isCompleted)
			{
				if (_error != null) observer.OnError(_error);
				else
				{
					if (_hasValue) observer.OnNext(_value);
					observer.OnCompleted();
				}
				return Disposable.Empty;
			}
			_observers.Add(observer);
			return Disposable.Create(() => _observers.Remove(observer));
		}

		public void Dispose()
		{
			_isDisposed = true;
			_observers.Clear();
		}
	}

	// ======== ReactiveCollection Extensions ========
	public static class ReactiveCollectionExtensions
	{
		public static IObservable<CollectionAddEvent<T>> ObserveAdd<T>(this IReactiveCollection<T> collection)
		{
			// Simplified: returns an observable that never fires (collection change tracking not implemented)
			return Observable.Empty<CollectionAddEvent<T>>();
		}
	}

	public struct CollectionAddEvent<T>
	{
		public int Index;
		public T Value;
		public CollectionAddEvent(int index, T value) { Index = index; Value = value; }
	}

	// ======== Observable ========
	public static class Observable
	{
		public static IObservable<T> Return<T>(T value)
		{
			return new ReturnObservable<T>(value);
		}

		public static IObservable<T> Empty<T>()
		{
			return new EmptyObservable<T>();
		}

		private class ReturnObservable<T> : IObservable<T>
		{
			private T _value;
			public ReturnObservable(T value) { _value = value; }
			public IDisposable Subscribe(IObserver<T> observer)
			{
				observer.OnNext(_value);
				observer.OnCompleted();
				return Disposable.Empty;
			}
		}

		private class EmptyObservable<T> : IObservable<T>
		{
			public IDisposable Subscribe(IObserver<T> observer)
			{
				observer.OnCompleted();
				return Disposable.Empty;
			}
		}

		public static IObservable<long> Timer(TimeSpan dueTime)
		{
			// Simplified: immediately fires with 0
			return Return(0L);
		}

		public static IObservable<long> Timer(TimeSpan dueTime, TimeSpan period)
		{
			return Return(0L);
		}

		public static IObservable<long> EveryUpdate()
		{
			// Simplified: returns empty (frame-based updates not implemented in minimal UniRx)
			return Empty<long>();
		}
	}
}
