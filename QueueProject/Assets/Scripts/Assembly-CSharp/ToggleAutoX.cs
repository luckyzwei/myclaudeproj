using Balancy.Data;
using KWCore.UI;
using UnityEngine;

public class ToggleAutoX : MonoBehaviour
{
	[SerializeField]
	private GameObject m_autoXToggleGroup;

	[SerializeField]
	private UIAnimator m_autoXToggle;

	private const string ANIM_SLIDEON = "SlideOn";

	private const string ANIM_SLIDEOFF = "SlideOff";

	private const string ANIM_ON = "On";

	private const string ANIM_OFF = "Off";

	private static UserPlayerProfileData SaveData => null;

	private void Start()
	{
	}

	public void Configure()
	{
	}

	public void OnAutoXTogglePressed()
	{
	}
}
