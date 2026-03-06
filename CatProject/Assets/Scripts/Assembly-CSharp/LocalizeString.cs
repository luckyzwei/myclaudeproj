using System.Collections.Generic;
using UnityEngine;

public class LocalizeString : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	protected string keyLocalize;

	public static List<LocalizeString> Localizelist { get; set; }

	private void Start()
	{
		if (Localizelist == null)
			Localizelist = new List<LocalizeString>();
		Localizelist.Add(this);
		RefreshText();
	}

	public virtual void RefreshText()
	{
		// Virtual base - override in subclass
	}

	public virtual void SetText(string txt)
	{
		// Virtual base - override in subclass
	}
}
