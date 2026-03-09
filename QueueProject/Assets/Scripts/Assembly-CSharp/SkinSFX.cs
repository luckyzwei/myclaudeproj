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
		return null;
	}
}
