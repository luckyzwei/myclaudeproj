using System;

[Serializable]
public class ProjectStarterData : ServerData
{
	public ProjectConfigSettings[] projectConfigSettings;

	public DesktopToolSettings desktopToolSettings;

	public EditorToolSettings editorToolSettings;

	public override ServerData CreateFromJSON(string jsonString)
	{
		return null;
	}
}
