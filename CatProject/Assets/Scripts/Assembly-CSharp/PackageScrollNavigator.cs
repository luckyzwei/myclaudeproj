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
		if (btn != null) btn.onClick.AddListener(OnClick);
	}

	public void Init(int _idx, Action<int> _clickAction)
	{
		idx = _idx;
		clickAction = _clickAction;
	}

	public void OnClick()
	{
		clickAction?.Invoke(idx);
	}

	public void SetFocus(bool isFocus)
	{
		if (outerImg != null) outerImg.enabled = isFocus;
		if (innerImg != null) innerImg.enabled = isFocus;
	}
}
