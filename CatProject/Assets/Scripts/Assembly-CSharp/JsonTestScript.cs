using UnityEngine;

public class JsonTestScript
{
	private TextMesh _text;

	private const string BAD_RESULT_MESSAGE = "Incorrect Deserialized Result";

	public JsonTestScript(TextMesh text)
	{
	}

	public void SerializeVector3()
	{
	}

	public void GenericListSerialization()
	{
	}

	public void PolymorphicSerialization()
	{
	}

	public void DictionarySerialization()
	{
	}

	public void DictionaryObjectValueSerialization()
	{
	}

	public void DictionaryObjectKeySerialization()
	{
	}

	private void DisplaySuccess(string testName)
	{
	}

	private void DisplayFail(string testName, string reason)
	{
	}

	private void LogStart(string testName)
	{
	}

	private void LogEnd(int testNum)
	{
	}

	private void Log(object message)
	{
	}

	private void LogSerialized(string message)
	{
	}

	private void LogResult(string shouldEqual, object actual)
	{
	}
}
