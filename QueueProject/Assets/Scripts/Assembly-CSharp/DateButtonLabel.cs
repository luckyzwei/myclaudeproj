using UnityEngine.UI;
using UnityEngine;

public class DateButtonLabel : MonoBehaviour
{
	private readonly string[] MONTHS_SHORT;

	[SerializeField]
	private Text m_dateText;

	[SerializeField]
	private Text m_monthText;

	public void ConfigDateLabel(DCDate date)
	{
	}
}
