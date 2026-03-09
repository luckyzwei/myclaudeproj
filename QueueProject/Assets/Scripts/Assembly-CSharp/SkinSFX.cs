using System.Collections.Generic;
using Balancy.Models;
using KWGameCore;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinSFX", menuName = "ScriptableObject/SkinSFX", order = 1)]
public class SkinSFX : GenericConfig<SkinSFX>
{
	public List<QueenSFX> m_sfxList;

	public QueenSFX GetSfxById(Balancy.Models.SkinSFX id)
	{
		if (m_sfxList == null) return null;
		foreach (var sfx in m_sfxList)
		{
			if (sfx != null && sfx.id == id)
				return sfx;
		}
		// Return first available if ID not found
		return m_sfxList.Count > 0 ? m_sfxList[0] : null;
	}
}
