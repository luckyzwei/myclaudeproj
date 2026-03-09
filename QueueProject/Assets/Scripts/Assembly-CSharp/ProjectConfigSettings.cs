using System;

[Serializable]
public class ProjectConfigSettings
{
	public string[] configName;

	public string companyName;

	public string bundleIDAndroid;

	public string bundleIDIOS;

	public string projectDefinitions;

	public bool generateNewKeyStore;
}
