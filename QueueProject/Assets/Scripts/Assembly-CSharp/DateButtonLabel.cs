using TMPro;
using UnityEngine;

public class DateButtonLabel : MonoBehaviour
{
	private readonly string[] MONTHS_SHORT;

	[SerializeField]
	private TextMeshProUGUI m_dateText;

	[SerializeField]
	private TextMeshProUGUI m_monthText;

	public void ConfigDateLabel(DCDate date)
	{
	}
}
