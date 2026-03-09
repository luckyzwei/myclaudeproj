using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseHint : MonoBehaviour
{
	protected const string COLUMN_TEXT_KEY = "Hints.Column";

	protected const string ROW_TEXT_KEY = "Hints.Row";

	protected const string ROWCOL_TAG = "[ROWCOL]";

	[SerializeField]
	protected bool m_isEnabled;

	protected PopupHint m_popupHint;

	protected QueensGrid Grid => null;

	public bool IsEnabled => false;

	public abstract bool CheckIfPossible(GridState gridState, HintsManager.HintResult result);

	public virtual void AutoDoAction(Action finishCallback)
	{
	}

	protected virtual void HintCompleted()
	{
	}

	protected string GetLocalisedText(string key)
	{
		return null;
	}

	protected PopupHint ShowHintPopupAndHighlightCells(string text, List<QueensGridCell> interactibleCells, List<QueensGridCell> highlightedCells = null)
	{
		return null;
	}

	protected string GetLocalisedColorName(int color)
	{
		return null;
	}

	protected string GetHighlighterLocalisedColorName(int color)
	{
		return null;
	}

	protected string ReplaceRowColTag(string explanation, bool isColumn)
	{
		return null;
	}

	protected Color GetColor(int colorIndex)
	{
		return default(Color);
	}

	public void SetEnabled(bool active)
	{
	}

	public static bool CanSee(Vector2Int viewer, Vector2Int subject, bool onlyNeighbors = false)
	{
		return false;
	}
}
