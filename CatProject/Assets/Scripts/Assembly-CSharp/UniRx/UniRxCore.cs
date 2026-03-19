// Minimal UniRx source implementation to replace broken DLL.
// Implements only the types actually used by the CatProject codebase.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace UniRx
{
	// ======== Unit ========
	public struct Unit : IEquatable<Unit>
	{
		public static readonly Unit Default = new Unit();
		public bool Equals(Unit other) => true;
		public override bool Equals(object obj) => obj is Unit;
		public override int GetHashCode() => 0;
		public override string ToString() => "()";
	}

	// ======== IReactiveProperty<T> ========
	public interface IReactiveProperty<T> : IObservable<T>
	{
		T Value { get; set; }
		bool HasValue { get; }
	}

	// ======== IReadOnlyReactiveProperty<T> ========
	public interface IReadOnlyReactiveProperty<T> : IObservable<T>
	{
		T Value { get; }
		bool HasValue { get; }
	}

	// ======== ReactiveProperty<T> ========
	public class ReactiveProperty<T> : IReactiveProperty<T>, IDisposable
	{
		private T _value;
		private bool _hasValue;
		private List<IObserver<T>> _observers;

		public ReactiveProperty()
		{
			_value = default(T);
			_hasValue = true;
			_observers = new List<IObserver<T>>();
		}

		public ReactiveProperty(T initialValue)
		{
			_value = initialValue;
			_hasValue = true;
			_observers = new List<IObserver<T>>();
		}

		public T Value
		{
			get => _value;
			set
			{
				_value = value;
				_hasValue = true;
				NotifyObservers(value);
			}
		}

		public bool HasValue => _hasValue;

		private void NotifyObservers(T val)
		{
			if (_observers == null) return;
			// Iterate copy to avoid modification during enumeration
			var copy = new List<IObserver<T>>(_observers);
			for (int i = 0; i < copy.Count; i++)
			{
				try { copy[i].OnNext(val); }
				catch (Exception) { }
			}
		}

		public IDisposable Subscribe(IObserver<T> observer)
		{
			if (_observers == null) _observers = new List<IObserver<T>>();
			_observers.Add(observer);
			// Send current value immediately
			if (_hasValue) observer.OnNext(_value);
			return new Subscription(this, observer);
		}

		private class Subscription : IDisposable
		{
			private ReactiveProperty<T> _parent;
			private IObserver<T> _observer;
			public Subscription(ReactiveProperty<T> parent, IObserver<T> observer)
			{
				_parent = parent;
				_observer = observer;
			}
			public void Dispose()
			{
				_parent?._observers?.Remove(_observer);
				_parent = null;
				_observer = null;
			}
		}

		public void Dispose()
		{
			if (_observers != null)
			{
				for (int i = 0; i < _observers.Count; i++)
				{
					try { _observers[i].OnCompleted(); } catch { }
				}
				_observers.Clear();
			}
		}

		public override string ToString() => _value != null ? _value.ToString() : "(null)";
	}

	// ======== Subject<T> ========
	public class Subject<T> : IObservable<T>, IObserver<T>, IDisposable
	{
		private List<IObserver<T>> _observers = new List<IObserver<T>>();
		private bool _isDisposed;

		public void OnNext(T value)
		{
			if (_isDisposed) return;
			var copy = new List<IObserver<T>>(_observers);
			for (int i = 0; i < copy.Count; i++)
			{
				try { copy[i].OnNext(value); } catch { }
			}
		}

		public void OnError(Exception error)
		{
			if (_isDisposed) return;
			var copy = new List<IObserver<T>>(_observers);
			for (int i = 0; i < copy.Count; i++)
			{
				try { copy[i].OnError(error); } catch { }
			}
		}

		public void OnCompleted()
		{
			if (_isDisposed) return;
			var copy = new List<IObserver<T>>(_observers);
			for (int i = 0; i < copy.Count; i++)
			{
				try { copy[i].OnCompleted(); } catch { }
			}
		}

		public IDisposable Subscribe(IObserver<T> observer)
		{
			if (_isDisposed) return Disposable.Empty;
			_observers.Add(observer);
			return new SubjectSubscription(this, observer);
		}

		private class SubjectSubscription : IDisposable
		{
			private Subject<T> _parent;
			private IObserver<T> _observer;
			public SubjectSubscription(Subject<T> parent, IObserver<T> observer) { _parent = parent; _observer = observer; }
			public void Dispose() { _parent?._observers?.Remove(_observer); }
		}

		public void Dispose()
		{
			_isDisposed = true;
			_observers.Clear();
		}
	}

	// ======== IReactiveCollection<T> ========
	public interface IReactiveCollection<T> : IList<T>
	{
	}

	// ======== ReactiveCollection<T> ========
	public class ReactiveCollection<T> : IReactiveCollection<T>
	{
		private List<T> _list = new List<T>();

		public ReactiveCollection() { }
		public ReactiveCollection(IEnumerable<T> collection) { _list = new List<T>(collection); }

		public T this[int index]
		{
			get => _list[index];
			set => _list[index] = value;
		}

		public int Count => _list.Count;
		public bool IsReadOnly => false;
		public void Add(T item) => _list.Add(item);
		public void Clear() => _list.Clear();
		public bool Contains(T item) => _list.Contains(item);
		public void CopyTo(T[] array, int arrayIndex) => _list.CopyTo(array, arrayIndex);
		public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();
		public int IndexOf(T item) => _list.IndexOf(item);
		public void Insert(int index, T item) => _list.Insert(index, item);
		public bool Remove(T item) => _list.Remove(item);
		public void RemoveAt(int index) => _list.RemoveAt(index);
		IEnumerator IEnumerable.GetEnumerator() => _list.GetEnumerator();
	}

	// ======== CompositeDisposable ========
	public class CompositeDisposable : ICollection<IDisposable>, IDisposable
	{
		private List<IDisposable> _disposables = new List<IDisposable>();
		private bool _isDisposed;

		public int Count => _disposables.Count;
		public bool IsReadOnly => false;

		public void Add(IDisposable item)
		{
			if (_isDisposed) { item?.Dispose(); return; }
			if (item != null) _disposables.Add(item);
		}

		public void Clear()
		{
			var copy = new List<IDisposable>(_disposables);
			_disposables.Clear();
			for (int i = 0; i < copy.Count; i++)
			{
				try { copy[i]?.Dispose(); } catch { }
			}
		}

		public bool Contains(IDisposable item) => _disposables.Contains(item);
		public void CopyTo(IDisposable[] array, int arrayIndex) => _disposables.CopyTo(array, arrayIndex);
		public IEnumerator<IDisposable> GetEnumerator() => _disposables.GetEnumerator();
		public bool Remove(IDisposable item)
		{
			bool removed = _disposables.Remove(item);
			if (removed) item?.Dispose();
			return removed;
		}
		IEnumerator IEnumerable.GetEnumerator() => _disposables.GetEnumerator();

		public void Dispose()
		{
			if (_isDisposed) return;
			_isDisposed = true;
			Clear();
		}
	}

	// ======== Disposable ========
	public static class Disposable
	{
		public static readonly IDisposable Empty = new EmptyDisposable();
		private class EmptyDisposable : IDisposable { public void Dispose() { } }

		public static IDisposable Create(Action disposeAction)
		{
			return new ActionDisposable(disposeAction);
		}

		private class ActionDisposable : IDisposable
		{
			private Action _action;
			public ActionDisposable(Action action) { _action = action; }
			public void Dispose() { _action?.Invoke(); _action = null; }
		}
	}

	// ======== Observable Extensions ========
	public static class ObservableExtensions
	{
		public static IDisposable Subscribe<T>(this IObservable<T> source, Action<T> onNext)
		{
			return source.Subscribe(new ActionObserver<T>(onNext, null, null));
		}

		public static IDisposable Subscribe<T>(this IObservable<T> source, Action<T> onNext, Action<Exception> onError)
		{
			return source.Subscribe(new ActionObserver<T>(onNext, onError, null));
		}

		public static IDisposable Subscribe<T>(this IObservable<T> source, Action<T> onNext, Action onCompleted)
		{
			return source.Subscribe(new ActionObserver<T>(onNext, null, onCompleted));
		}

		private class ActionObserver<T> : IObserver<T>
		{
			private Action<T> _onNext;
			private Action<Exception> _onError;
			private Action _onCompleted;
			public ActionObserver(Action<T> onNext, Action<Exception> onError, Action onCompleted)
			{
				_onNext = onNext;
				_onError = onError;
				_onCompleted = onCompleted;
			}
			public void OnNext(T value) => _onNext?.Invoke(value);
			public void OnError(Exception error) => _onError?.Invoke(error);
			public void OnCompleted() => _onCompleted?.Invoke();
		}
	}

	// ======== DisposableExtensions (AddTo) ========
	public static class DisposableExtensions
	{
		public static T AddTo<T>(this T disposable, CompositeDisposable composite) where T : IDisposable
		{
			if (composite != null) composite.Add(disposable);
			return disposable;
		}

		public static T AddTo<T>(this T disposable, UnityEngine.Component component) where T : IDisposable
		{
			// In full UniRx this hooks into Unity lifecycle; simplified version just returns
			return disposable;
		}
	}
}
