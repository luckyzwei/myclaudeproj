using Treeplla;
using UnityEngine;

public class TutorialRegister : MonoBehaviour
{
	public TutorialIdent index;

	public GameObject Target;

	private void Awake()
	{
		AddData(index);
	}

	public void AddData(TutorialIdent _index)
	{
		index = _index;
		if (Target == null)
			Target = gameObject;

		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.TutorialSystem != null)
		{
			root.TutorialSystem.AddRegister(_index, this);
		}
	}

	private void OnDestroy()
	{
		var root = Singleton<GameRoot>.Instance;
		if (root != null && root.TutorialSystem != null)
		{
			root.TutorialSystem.RemoveRegister(index);
		}
	}
}
