using System.Collections.Generic;
using UnityEngine;

public class TutorialEntity : MonoBehaviour
{
	[SerializeField]
	public List<GameObject> activeList;

	public bool Complete { get; set; }

	public virtual void StartEntity()
	{
	}

	protected virtual void Done()
	{
	}
}
