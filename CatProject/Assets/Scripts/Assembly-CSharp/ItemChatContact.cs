using System;
using UnityEngine;
using UnityEngine.UI;

public class ItemChatContact : MonoBehaviour
{
	[SerializeField]
	private Image Icon;

	[SerializeField]
	private Text Name;

	[SerializeField]
	private Text LastChat;

	[SerializeField]
	private Button Btn;

	[SerializeField]
	private GameNotificationRegister ReddotRegister;

	[SerializeField]
	private GameNotificationRegister ReadRegister;

	public Action<int> SelectCb;

	private int ChatGroup;

	private void Awake()
	{
	}

	public void Set(int group)
	{
	}

	private void OnClickBtn()
	{
	}
}
