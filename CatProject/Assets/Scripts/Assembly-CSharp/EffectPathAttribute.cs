using System;

[AttributeUsage(AttributeTargets.Class)]
public class EffectPathAttribute : Attribute
{
	private string path;

	private bool ui;

	private bool worldUI;

	public string Path { get { return null; } }

	public bool InUI { get { return false; } }

	public bool InWorldUI { get { return false; } }

	public EffectPathAttribute(string name, bool _ui = false, bool _worldUI = false)
	{
		path = name;
		ui = _ui;
		worldUI = _worldUI;
	}
}
