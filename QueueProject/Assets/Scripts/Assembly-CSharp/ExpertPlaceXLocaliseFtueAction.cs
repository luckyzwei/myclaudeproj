using UnityEngine.UI;
using UnityEngine;

public class ExpertPlaceXLocaliseFtueAction : BaseFtueAction
{
	[SerializeField]
	private Text m_text;

	[SerializeField]
	private Vector2Int m_cellToCheck;

	[TextLookup(null, true)]
	[SerializeField]
	private string m_originalColourStringKey;

	[TextLookup(null, true)]
	[SerializeField]
	private string m_colourChangedStringKey;

	public override void Play()
	{
		if (m_grid != null && m_text != null)
		{
			var cell = m_grid.GetCell(m_cellToCheck.x, m_cellToCheck.y);
			if (cell != null)
			{
				string colorName = GetHighlighterLocalisedColorName(cell.Colour);
				if (!string.IsNullOrEmpty(colorName))
					m_text.text = string.Format(m_text.text, colorName);
			}
		}
		Finished();
	}

	protected string GetHighlighterLocalisedColorName(int colour)
	{
		// Return localized color name based on grid color index
		return colour.ToString();
	}
}
