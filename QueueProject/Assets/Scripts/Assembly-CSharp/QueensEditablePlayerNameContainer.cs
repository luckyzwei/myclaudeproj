using UnityEngine;

public class QueensEditablePlayerNameContainer : EditablePlayerNameContainer
{
	[SerializeField]
	private Vector3 m_offset;

	protected override void OnEditingNameInputField(string inputText)
	{
	}
}
