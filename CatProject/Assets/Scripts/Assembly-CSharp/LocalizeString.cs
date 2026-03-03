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
	}

	public virtual void RefreshText()
	{
	}

	public virtual void SetText(string txt)
	{
	}
}
