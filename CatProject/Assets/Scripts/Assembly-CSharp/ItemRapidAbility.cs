using UnityEngine;
using UnityEngine.UI;

public class ItemRapidAbility : MonoBehaviour
{
	[SerializeField]
	private Text Desc;

	[SerializeField]
	private Text Level;

	[SerializeField]
	private GameObject CurrentObj;

	[SerializeField]
	private GameObject NextObj;

	public void SetAbility(int level, int type, int value)
	{
		if (Level != null) Level.text = "Lv." + level;
	}

	public void SetCurrent(bool value)
	{
		if (CurrentObj != null) CurrentObj.SetActive(value);
	}

	public void SetNext(bool value)
	{
		if (NextObj != null) NextObj.SetActive(value);
	}

	public void SetNewAbility(bool value)
	{
		if (CurrentObj != null) CurrentObj.SetActive(!value);
		if (NextObj != null) NextObj.SetActive(value);
	}
}
