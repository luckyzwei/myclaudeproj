using System;
using UnityEngine;

public class PrefabReferenceRequiredComponent : PropertyAttribute
{
	public Type RequiredType { get; private set; }

	public PrefabReferenceRequiredComponent(Type requiredType)
	{
	}
}
