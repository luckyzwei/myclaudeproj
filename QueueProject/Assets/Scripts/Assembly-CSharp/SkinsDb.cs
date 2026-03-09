using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinsDb", menuName = "ScriptableObjects/SkinsDb", order = 3)]
public class SkinsDb : ScriptableObject
{
	[Serializable]
	public class SkinData
	{
		public string clientID;

		public Texture2D queenVfxTexture;
	}

	public SkinData[] skinDatas;

	private Dictionary<string, SkinData> m_dict;

	private bool m_isPopulated;

	private void PopulateDictionary()
	{
	}

	public SkinData GetSkinData(string clientID)
	{
		return null;
	}

	public Texture2D GetVFXTexture(string clientID)
	{
		return null;
	}
}
