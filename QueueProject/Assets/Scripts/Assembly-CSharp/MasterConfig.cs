using KPFCore;
using UnityEngine;

[CreateAssetMenu(fileName = "MasterConfig", menuName = "KPF/Configs/Create Master Config")]
public class MasterConfig : ConfigBase
{
	[SerializeField]
	private ServerEnvironment m_serverEnvironment;
}
