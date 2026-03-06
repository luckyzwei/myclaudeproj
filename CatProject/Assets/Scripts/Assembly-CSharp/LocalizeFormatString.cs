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
		InitArgs();
		base.RefreshText();
	}

	public override void SetText(string txt)
	{
		base.SetText(txt);
	}

	private void InitArgs()
	{
		if (CachedArgs == null)
			CachedArgs = new List<string>();
		CachedArgs.Clear();
		if (IsDefineFormatArgs && FormatArgs != null)
		{
			for (int i = 0; i < FormatArgs.Count; i++)
				CachedArgs.Add(FormatArgs[i]);
		}
	}
}
