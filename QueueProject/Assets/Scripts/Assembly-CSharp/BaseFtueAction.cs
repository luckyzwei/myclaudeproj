using System;
using UnityEngine;

public class BaseFtueAction : MonoBehaviour
{
	protected QueensGrid m_grid;

	private Action m_finishCallback;

	public void Config(QueensGrid grid, Action finishCallback)
	{
		m_grid = grid;
		m_finishCallback = finishCallback;
	}

	public virtual void Play()
	{
		// Default: finish immediately
		Finished();
	}

	public virtual void Stop()
	{
	}

	protected virtual void Finished()
	{
		// 统一隐藏手 — 不依赖各子类的 m_hand 序列化引用
		var popup = GetComponentInParent<PopupQueensInGameAdaptiveFTUE>();
		UnityEngine.Debug.Log($"[BaseFtueAction] Finished() on '{gameObject.name}' ({GetType().Name}) - popup={(popup != null ? popup.name : "NULL")}");

		if (popup != null)
		{
			var hand = popup.GetComponentInChildren<FtueHandController>(true);
			UnityEngine.Debug.Log($"[BaseFtueAction] Hand found: {(hand != null ? hand.gameObject.name : "NULL")}");
			if (hand != null)
				hand.Hide();
		}
		else
		{
			// 备用方案：直接在场景中查找
			var hand = FindObjectOfType<FtueHandController>();
			UnityEngine.Debug.Log($"[BaseFtueAction] Fallback FindObjectOfType: {(hand != null ? hand.gameObject.name : "NULL")}");
			if (hand != null)
				hand.Hide();
		}

		m_finishCallback?.Invoke();
	}

	public virtual void ContinuePressed()
	{
		Finished();
	}
}
