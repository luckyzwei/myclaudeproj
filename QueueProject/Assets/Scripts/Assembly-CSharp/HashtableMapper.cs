using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class HashtableMapper<T> where T : class, new()
{
	public static T MapHashtableToClass(Hashtable hashtable)
	{
		return null;
	}

	private static void SetConvertValue(object value, FieldInfo field, T targetClass)
	{
	}

	public static List<T> MapHashtableToList(Hashtable data)
	{
		return null;
	}
}
