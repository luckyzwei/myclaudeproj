using System.Collections.Generic;
using BizAcqDef;

public class BizAcqTeamData
{
	public const int TEAM_MAX_COUNT = 5;

	private List<BizAcqCharacterData> characters;

	public TeamType TeamType { get; private set; }

	public IReadOnlyList<BizAcqCharacterData> Characters { get { return null; } }

	public int CurrentIndex { get; private set; }

	public BizAcqCharacterData CurrentCharacter { get { return null; } }

	public BizAcqTeamData(TeamType teamType)
	{
		TeamType = teamType;
	}

	public BizAcqTeamData(TeamType teamType, List<BizAcqCharacterData> characters)
	{
		TeamType = teamType;
		this.characters = characters;
	}

	public bool TryAdd(BizAcqCharacterData character)
	{
		return false;
	}

	public bool Remove(int ceoIdx)
	{
		return false;
	}

	public BizAcqCharacterData Find(int ceoIdx)
	{
		return null;
	}

	public int GetNextCharacterSlotIndex()
	{
		return 0;
	}

	public bool Exists(int ceoIdx)
	{
		return false;
	}

	public bool IsEmpty()
	{
		return false;
	}

	public bool IsFull()
	{
		return false;
	}

	public bool IsAllDead()
	{
		return false;
	}

	public bool SetNextCharacter()
	{
		return false;
	}

	public BizAcqCharacterData FindCharacterByIndex(int index)
	{
		return null;
	}

	public BizAcqCharacterData FindCharacterByCeoIdx(int ceoIdx)
	{
		return null;
	}

	public int GetCharacterSlotIndex(int ceoIdx)
	{
		return 0;
	}

	public BizAcqCharacterData GetNextCharacter()
	{
		return null;
	}

	public bool HasNextCharacter()
	{
		return false;
	}

	public void Reset()
	{
	}

	public (int, int) GetTeamHpInfo()
	{
		return default((int, int));
	}
}
