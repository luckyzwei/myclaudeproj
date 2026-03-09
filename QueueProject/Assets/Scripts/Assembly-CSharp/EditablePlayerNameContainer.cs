using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_InputField))]
public class EditablePlayerNameContainer : MonoBehaviour, IUserContainer
{
	[SerializeField]
	protected TMP_InputField m_nameInputField;

	private string m_initialName;

	public string UserID => null;

	private void OnValidate()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void ValidateInputFieldReference()
	{
	}

	private void UpdateUI()
	{
	}

	private void OnStartEditingNameInputField(string inputText)
	{
	}

	public void OnEditNamePressed()
	{
	}

	protected virtual void OnEditingNameInputField(string inputText)
	{
	}

	public void OnFinishedEditingNameInputField(string inputText)
	{
	}

	protected virtual string FilterName(string rawName)
	{
		return null;
	}

	void IUserContainer.OnPlayerProfileChanged(PublicProfile profile)
	{
	}
}
