using UnityEngine;
using UnityEngine.UI;

public static class SelectorConditionController
{
	public static GameObject MatchCondition(SelectorCondition selectorCondition, GameObject gameObjectToCheck, bool enabled)
	{
		if (selectorCondition == null || gameObjectToCheck == null) return null;
		switch (selectorCondition.Type)
		{
			case SelectorType.Any:
				return matchConditionForAny((AnyCondition)selectorCondition, gameObjectToCheck, enabled);
			case SelectorType.Name:
				return matchConditionForName((NameCondition)selectorCondition, gameObjectToCheck, enabled);
			case SelectorType.PropertyEquals:
				return matchConditionForProperty((PropertyEqualsCondition)selectorCondition, gameObjectToCheck, enabled);
			case SelectorType.Indexer:
				return matchConditionForIndexer((IndexerCondition)selectorCondition, gameObjectToCheck, enabled);
			case SelectorType.Function:
				return matchConditionForFunction((FunctionCondition)selectorCondition, gameObjectToCheck, enabled);
			default:
				return null;
		}
	}

	private static GameObject matchConditionForAny(AnyCondition anyCondition, GameObject gameObjectToCheck, bool enabled)
	{
		if (anyCondition == null || gameObjectToCheck == null) return null;
		if (!enabled || gameObjectToCheck.activeInHierarchy)
			return gameObjectToCheck;
		return null;
	}

	private static GameObject matchConditionForName(NameCondition nameCondition, GameObject gameObjectToCheck, bool enabled)
	{
		if (nameCondition == null || gameObjectToCheck == null) return null;
		if (gameObjectToCheck.name == nameCondition.Name)
		{
			if (!enabled || gameObjectToCheck.activeInHierarchy)
				return gameObjectToCheck;
		}
		return null;
	}

	private static GameObject matchConditionForProperty(PropertyEqualsCondition propertyEqualsCondition, GameObject gameObjectToCheck, bool enabled)
	{
		if (propertyEqualsCondition == null || gameObjectToCheck == null) return null;
		if (enabled && !gameObjectToCheck.activeInHierarchy) return null;

		string value = null;
		switch (propertyEqualsCondition.Property)
		{
			case PropertyType.name:
				value = gameObjectToCheck.name;
				break;
			case PropertyType.tag:
				value = gameObjectToCheck.tag;
				break;
			case PropertyType.layer:
				value = LayerMask.LayerToName(gameObjectToCheck.layer);
				break;
			case PropertyType.text:
				value = getText(gameObjectToCheck);
				break;
			case PropertyType.id:
				value = gameObjectToCheck.GetInstanceID().ToString();
				break;
		}
		if (value != null && value == propertyEqualsCondition.PropertyValue)
			return gameObjectToCheck;
		return null;
	}

	private static GameObject matchConditionForIndexer(IndexerCondition indexerCondition, GameObject gameObjectToCheck, bool enabled)
	{
		if (indexerCondition == null || gameObjectToCheck == null) return null;
		if (enabled && !gameObjectToCheck.activeInHierarchy) return null;
		if (indexerCondition.CurrentIndexCountDown == 0)
			return gameObjectToCheck;
		indexerCondition.CurrentIndexCountDown--;
		return null;
	}

	private static GameObject matchConditionForFunction(FunctionCondition functionCondition, GameObject gameObjectToCheck, bool enabled)
	{
		if (functionCondition == null || gameObjectToCheck == null) return null;
		if (enabled && !gameObjectToCheck.activeInHierarchy) return null;

		if (functionCondition.Function == FunctionType.contains)
		{
			string value = null;
			switch (functionCondition.Property)
			{
				case PropertyType.name:
					value = gameObjectToCheck.name;
					break;
				case PropertyType.text:
					value = getText(gameObjectToCheck);
					break;
			}
			if (value != null && functionCondition.PropertyValue != null && value.Contains(functionCondition.PropertyValue))
				return gameObjectToCheck;
		}
		return null;
	}

	private static string getText(GameObject objectToCheck)
	{
		if (objectToCheck == null) return null;
		var text = objectToCheck.GetComponent<Text>();
		if (text != null) return text.text;
		return null;
	}
}
