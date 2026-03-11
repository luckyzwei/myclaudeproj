using UnityEngine.UI;
using UnityEngine;

public class LoadingWidget : MonoBehaviour
{
	[SerializeField]
	private GameObject m_spinner;

	[SerializeField]
	private Text m_noConnection;

	[SerializeField]
	private float m_rotationSpeed;

	private void Awake()
	{
	}

	public void ShowLoading()
	{
	}

	public void ShowNoConnection()
	{
	}

	public void Hide()
	{
	}

	private void HideAll()
	{
	}
}
