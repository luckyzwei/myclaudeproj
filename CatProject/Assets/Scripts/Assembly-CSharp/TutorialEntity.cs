using System.Collections.Generic;
using UnityEngine;

public class TutorialEntity : MonoBehaviour
{
	[SerializeField]
	public List<GameObject> activeList;

	public bool Complete { get; set; }

	public virtual void StartEntity()
	{
		Complete = false;
		if (activeList != null)
		{
			for (int i = 0; i < activeList.Count; i++)
			{
				if (activeList[i] != null)
					activeList[i].SetActive(true);
			}
		}
	}

	protected virtual void Done()
	{
		Complete = true;
		if (activeList != null)
		{
			for (int i = 0; i < activeList.Count; i++)
			{
				if (activeList[i] != null)
					activeList[i].SetActive(false);
			}
		}
	}
}
