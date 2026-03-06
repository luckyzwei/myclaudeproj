using UnityEngine;

public class CharactersAniComponent : MonoBehaviour
{
	[SerializeField]
	private Animator CharacterAniA;

	[SerializeField]
	private Animator CharacterAniB;

	[SerializeField]
	private Animator CharacterAniC;

	[SerializeField]
	private Animator CharacterAniD;

	[SerializeField]
	private Animator CharacterAniE;

	[SerializeField]
	private Animator WoodAni;

	public void DirectionCharA(string aniName)
	{
		if (CharacterAniA != null) CharacterAniA.Play(aniName);
	}

	public void DirectionCharB(string aniName)
	{
		if (CharacterAniB != null) CharacterAniB.Play(aniName);
	}

	public void DirectionCharC(string aniName)
	{
		if (CharacterAniC != null) CharacterAniC.Play(aniName);
	}

	public void DirectionCharD(string aniName)
	{
		if (CharacterAniD != null) CharacterAniD.Play(aniName);
	}

	public void DirectionCharE(string aniName)
	{
		if (CharacterAniE != null) CharacterAniE.Play(aniName);
	}

	public void StartWoodAni(string aniName)
	{
		if (WoodAni != null) WoodAni.Play(aniName);
	}
}
