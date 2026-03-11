using UnityEngine.UI;
using UnityEngine;

public class RemainingGemsInQueenEventWidget : MonoBehaviour
{
	[SerializeField]
	private GameObject m_parentGameObject;

	[SerializeField]
	private Text m_text;

	[SerializeField]
	private string m_formatKey;

	private void Start()
	{
	}

	private int GetGemsUntilNextReward()
	{
		return 0;
	}
}
