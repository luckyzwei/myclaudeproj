using System.Collections.Generic;
using UnityEngine;

public class LocalizeFormatString : LocalizeString
{
	[SerializeField]
	private bool IsDefineFormatArgs;

	[SerializeField]
	private List<string> FormatArgs;

	private List<string> CachedArgs;

	public override void RefreshText()
	{
	}

	public override void SetText(string txt)
	{
	}

	private void InitArgs()
	{
	}
}
