using System;

[AttributeUsage(AttributeTargets.Class)]
public class EffectPathAttribute : Attribute
{
	private string path;

	private bool ui;

	private bool worldUI;

	public string Path => null;

	public bool InUI => false;

	public bool InWorldUI => false;

	public EffectPathAttribute(string name, bool _ui = false, bool _worldUI = false)
	{
	}
}
