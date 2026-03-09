using KPFCore;
using UnityEngine;

[CreateAssetMenu(fileName = "LocalProfileBackgroundConfig", menuName = "KPF/Configs/Create Local Profile Background Config")]
public class ProfileBackgroundConfig : ScriptableObject, IConfig
{
	public enum Service
	{
		BALANCY = 0,
		NAKAMA = 1,
		LOCAL = 2
	}

	public Service service;

	public string defaultBackgroundId;

	[Tooltip("Refresh backgrounds interval in Seconds")]
	public int refreshInterval;
}
