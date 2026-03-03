using System;
using UnityEngine;
using UnityEngine.UI;

public class PackageScrollNavigator : MonoBehaviour
{
	[SerializeField]
	private Image outerImg;

	[SerializeField]
	private Image innerImg;

	[SerializeField]
	private Button btn;

	private int idx;

	private Action<int> clickAction;

	private void Awake()
	{
	}

	public void Init(int _idx, Action<int> _clickAction)
	{
	}

	public void OnClick()
	{
	}

	public void SetFocus(bool isFocus)
	{
	}
}
