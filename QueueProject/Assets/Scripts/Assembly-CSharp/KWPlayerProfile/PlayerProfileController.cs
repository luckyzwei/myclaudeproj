using KPFCore;
using UnityEngine;

namespace KWPlayerProfile
{
	[CreateAssetMenu(fileName = "PlayerProfileController", menuName = "KPF/Controllers/Create PlayerProfile Controller")]
	public class PlayerProfileController : ControllerBase
	{
		private PlayerProfileService m_playerProfileService;

		protected override void InitialiseLocal()
		{
		}

		protected override void ShowView(IUIEvent evt)
		{
		}
	}
}
