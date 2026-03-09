using System;
using System.Collections.Generic;
using UnityEngine;

public class RefsHolder
{
	private static Dictionary<Type, MonoBehaviour> m_refs;

	public static void Register<T>(T obj) where T : MonoBehaviour
	{
	}

	public static T Get<T>() where T : MonoBehaviour
	{
		return null;
	}

	public static void SetNull<T>(T obj = null) where T : MonoBehaviour
	{
	}
}
