using UnityEngine;

public class TextLookupAttribute : PropertyAttribute
{
	public string filter;

	public bool useSubmenus;

	public TextLookupAttribute(string filter = "", bool useSubmenus = true)
	{
	}
}
