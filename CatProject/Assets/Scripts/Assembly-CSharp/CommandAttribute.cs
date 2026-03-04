using System;

public class CommandAttribute : Attribute
{
	private string name;

	public string Name { get { return null; } }

	public CommandAttribute(string name)
	{
		this.name = name;
	}
}
