using System.Collections.Generic;
using UnityEngine;

public class TechnicalRoom : Room
{
	[SerializeField]
	public List<Transform> CharTrans;

	protected override void SetOpened(bool value)
	{
	}
}
