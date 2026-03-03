using System;
using UnityEngine;

public interface IPool<T> where T : MonoBehaviour
{
	void Get(Action<T> onLoad);

	void Return(T obj);
}
