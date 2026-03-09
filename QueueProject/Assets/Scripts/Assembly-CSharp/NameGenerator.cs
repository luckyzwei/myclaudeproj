using KWCore.Utils;
using UnityEngine;

public class NameGenerator : MonoSingleton<NameGenerator>
{
	[SerializeField]
	private NamesScriptable m_names;

	[SerializeField]
	private NameGenerationScriptable m_nameGeneration;

	protected override void Init()
	{
	}

	public string GetName()
	{
		return null;
	}
}
