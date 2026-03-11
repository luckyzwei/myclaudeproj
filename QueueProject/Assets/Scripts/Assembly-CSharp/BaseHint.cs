using System;
using System.Collections.Generic;
using KWCore.UI;
using UnityEngine;

public abstract class BaseHint : MonoBehaviour
{
	protected const string COLUMN_TEXT_KEY = "Hints.Column";

	protected const string ROW_TEXT_KEY = "Hints.Row";

	protected const string ROWCOL_TAG = "[ROWCOL]";

	[SerializeField]
	protected bool m_isEnabled;

	protected PopupHint m_popupHint;

	protected QueensGrid Grid
	{
		get
		{
			if (QueensGameController.Instance != null)
				return QueensGameController.Instance.Grid;
			return null;
		}
	}

	public bool IsEnabled => m_isEnabled;

	public abstract bool CheckIfPossible(GridState gridState, HintsManager.HintResult result);

	public virtual void AutoDoAction(Action finishCallback)
	{
		finishCallback?.Invoke();
	}

	protected virtual void HintCompleted()
	{
		if (m_popupHint != null)
			m_popupHint.Close();
	}

	protected string GetLocalisedText(string key)
	{
		return Kwalee.GetLocalisedText(key);
	}

	protected PopupHint ShowHintPopupAndHighlightCells(string text, List<QueensGridCell> interactibleCells, List<QueensGridCell> highlightedCells = null)
	{
		// Highlight cells
		if (highlightedCells != null)
		{
			for (int i = 0; i < highlightedCells.Count; i++)
			{
				if (highlightedCells[i] != null)
					highlightedCells[i].Highlight(true);
			}
		}

		// Show hint popup with explanation text
		m_popupHint = KWCore.UI.PopUpBase.ShowPopup<PopupHint>(PopupHint.PREFAB_NAME);
		if (m_popupHint != null)
			m_popupHint.Config(text, interactibleCells, highlightedCells);
		return m_popupHint;
	}

	protected string GetLocalisedColorName(int color)
	{
		string key = "Color.C" + (color + 1);
		string localized = Kwalee.GetLocalisedText(key);
		return string.IsNullOrEmpty(localized) ? "Color " + color : localized;
	}

	protected string GetHighlighterLocalisedColorName(int color)
	{
		string name = GetLocalisedColorName(color);
		Color c = GetColor(color);
		string hex = ColorUtility.ToHtmlStringRGB(c);
		return "<color=#" + hex + ">" + name + "</color>";
	}

	protected string ReplaceRowColTag(string explanation, bool isColumn)
	{
		if (string.IsNullOrEmpty(explanation)) return explanation;
		string replacement = isColumn ?
			GetLocalisedText(COLUMN_TEXT_KEY) ?? "column" :
			GetLocalisedText(ROW_TEXT_KEY) ?? "row";
		return explanation.Replace(ROWCOL_TAG, replacement);
	}

	protected Color GetColor(int colorIndex)
	{
		var cm = CosmeticsManager.Instance;
		if (cm != null)
		{
			var config = cm.GetCurrentColorConfig();
			if (config != null && config.colors != null && colorIndex >= 0 && colorIndex < config.colors.Count)
				return config.colors[colorIndex];
		}
		return Color.white;
	}

	public void SetEnabled(bool active)
	{
		m_isEnabled = active;
	}

	public static bool CanSee(Vector2Int viewer, Vector2Int subject, bool onlyNeighbors = false)
	{
		// Check if viewer can "see" subject (same row, column, or diagonal)
		if (viewer.x == subject.x) return true; // same column
		if (viewer.y == subject.y) return true; // same row
		if (Mathf.Abs(viewer.x - subject.x) == Mathf.Abs(viewer.y - subject.y)) return true; // diagonal

		if (onlyNeighbors)
			return Mathf.Abs(viewer.x - subject.x) <= 1 && Mathf.Abs(viewer.y - subject.y) <= 1;

		return false;
	}
}
