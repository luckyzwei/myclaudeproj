using UnityEngine;

public class DataSheetAnalytics : MonoBehaviour
{
	private const string EVENT_NAME = "_data_sheet";

	public void ParseError(string error, string sheetVersion, string system)
	{
	}

	public void ParseSuccess(string sheetVersion, string system, int duration)
	{
	}
}
