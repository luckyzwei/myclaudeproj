using UnityEngine;

public class FacilityCatAniComponent : MonoBehaviour
{
	[SerializeField]
	private Animator CharacterAniA;

	[SerializeField]
	private Animator CharacterAniB;

	[SerializeField]
	private Animator WoodAni;

	public void DirectionCharA(string aniName)
	{
		if (CharacterAniA != null)
			CharacterAniA.Play(aniName);
	}

	public void DirectionCharB(string aniName)
	{
		if (CharacterAniB != null)
			CharacterAniB.Play(aniName);
	}

	public void StartWoodAni(string aniName)
	{
		if (WoodAni != null)
			WoodAni.Play(aniName);
	}
}
