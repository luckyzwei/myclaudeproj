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
		if (m_isPopulated) return;
		m_isPopulated = true;
		m_dict = new Dictionary<string, SkinData>();
		if (skinDatas != null)
		{
			for (int i = 0; i < skinDatas.Length; i++)
			{
				if (skinDatas[i] != null && !string.IsNullOrEmpty(skinDatas[i].clientID))
					m_dict[skinDatas[i].clientID] = skinDatas[i];
			}
		}
	}

	public SkinData GetSkinData(string clientID)
	{
		PopulateDictionary();
		if (m_dict != null && m_dict.ContainsKey(clientID))
			return m_dict[clientID];
		return null;
	}

	public Texture2D GetVFXTexture(string clientID)
	{
		var data = GetSkinData(clientID);
		return data?.queenVfxTexture;
	}
}
