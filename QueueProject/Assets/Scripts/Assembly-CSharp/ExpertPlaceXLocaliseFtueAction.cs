using TMPro;
using UnityEngine;

public class ExpertPlaceXLocaliseFtueAction : BaseFtueAction
{
	[SerializeField]
	private TextMeshProUGUI m_text;

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
	}

	protected string GetHighlighterLocalisedColorName(int colour)
	{
		return null;
	}
}
