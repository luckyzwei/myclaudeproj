using UnityEngine;
using UnityEngine.UI;

public class ContinueButtonFtueAction : BaseFtueAction
{
	public override void Play()
	{
		var popup = GetComponentInParent<PopupQueensInGameAdaptiveFTUE>();
		if (popup != null)
		{
			// 启用 raycasts 让 Continue 按钮可以接收点击
			var cg = popup.GetComponent<CanvasGroup>();
			if (cg != null)
				cg.blocksRaycasts = true;

			// 确保 Continue 按钮可见（Timeline 可能未正确激活它）
			var continueButtons = popup.GetComponentsInChildren<Button>(true);
			for (int i = 0; i < continueButtons.Length; i++)
			{
				if (continueButtons[i].gameObject.name == "Button-Continue")
				{
					continueButtons[i].gameObject.SetActive(true);
					// 本地化按钮文字（prefab 中硬编码为英文 "Got it!"）
					var btnText = continueButtons[i].GetComponentInChildren<Text>(true);
					if (btnText != null)
					{
						string locText = Kwalee.GetLocalisedText("Ftue.GotIt");
						if (!string.IsNullOrEmpty(locText) && locText != "Ftue.GotIt")
							btnText.text = locText;
					}
					break;
				}
			}
		}
		// 不调用 Finished() — 等用户点击按钮
	}

	public override void ContinuePressed()
	{
		// 隐藏 Continue 按钮
		var popup = GetComponentInParent<PopupQueensInGameAdaptiveFTUE>();
		if (popup != null)
		{
			var continueButtons = popup.GetComponentsInChildren<Button>(true);
			for (int i = 0; i < continueButtons.Length; i++)
			{
				if (continueButtons[i].gameObject.name == "Button-Continue")
				{
					continueButtons[i].gameObject.SetActive(false);
					break;
				}
			}
		}
		Finished();
	}
}
