using System;
using UnityEngine;

public class EnumArrayAttribute : PropertyAttribute
{
	public readonly Type m_enum;

	public EnumArrayAttribute(Type enumType)
	{
	}
}
