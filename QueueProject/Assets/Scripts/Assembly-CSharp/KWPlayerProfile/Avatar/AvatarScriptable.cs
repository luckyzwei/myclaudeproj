using System.Collections.Generic;
using UnityEngine;

namespace KWPlayerProfile.Avatar
{
	[CreateAssetMenu(fileName = "AvatarScriptable", menuName = "Kwalee/KWPlayerProfile/Create AvatarScriptable")]
	public class AvatarScriptable : ScriptableObject
	{
		public const string PATH = "LocalAvatarScriptable";

		[SerializeField]
		private List<AvatarData> m_avatarDataList;

		[SerializeField]
		private AvatarData m_defaultAvatarData;

		public List<AvatarData> GetAvatarsDataList()
		{
			return null;
		}

		public AvatarData GetDefaultAvatarData()
		{
			return null;
		}
	}
}
