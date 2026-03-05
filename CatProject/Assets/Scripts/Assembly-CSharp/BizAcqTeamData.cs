using System.Collections.Generic;
using BizAcqDef;

public class BizAcqTeamData
{
	public const int TEAM_MAX_COUNT = 5;

	private List<BizAcqCharacterData> characters;

	public TeamType TeamType { get; private set; }

	public IReadOnlyList<BizAcqCharacterData> Characters { get { return characters; } }

	public int CurrentIndex { get; private set; }

	public BizAcqCharacterData CurrentCharacter
	{
		get
		{
			if (characters == null || CurrentIndex < 0 || CurrentIndex >= characters.Count)
				return null;
			return characters[CurrentIndex];
		}
	}

	public BizAcqTeamData(TeamType teamType)
	{
		TeamType = teamType;
		characters = new List<BizAcqCharacterData>();
		CurrentIndex = 0;
	}

	public BizAcqTeamData(TeamType teamType, List<BizAcqCharacterData> characters)
	{
		TeamType = teamType;
		this.characters = characters ?? new List<BizAcqCharacterData>();
		CurrentIndex = 0;
	}

	public bool TryAdd(BizAcqCharacterData character)
	{
		if (character == null) return false;
		if (characters == null) characters = new List<BizAcqCharacterData>();
		if (characters.Count >= TEAM_MAX_COUNT) return false;
		if (Exists(character.CeoIdx)) return false;
		characters.Add(character);
		return true;
	}

	public bool Remove(int ceoIdx)
	{
		if (characters == null) return false;
		for (int i = 0; i < characters.Count; i++)
		{
			if (characters[i] != null && characters[i].CeoIdx == ceoIdx)
			{
				characters.RemoveAt(i);
				if (CurrentIndex >= characters.Count && characters.Count > 0)
					CurrentIndex = characters.Count - 1;
				return true;
			}
		}
		return false;
	}

	public BizAcqCharacterData Find(int ceoIdx)
	{
		return FindCharacterByCeoIdx(ceoIdx);
	}

	public int GetNextCharacterSlotIndex()
	{
		if (characters == null) return 0;
		return characters.Count;
	}

	public bool Exists(int ceoIdx)
	{
		return FindCharacterByCeoIdx(ceoIdx) != null;
	}

	public bool IsEmpty()
	{
		return characters == null || characters.Count == 0;
	}

	public bool IsFull()
	{
		return characters != null && characters.Count >= TEAM_MAX_COUNT;
	}

	public bool IsAllDead()
	{
		if (characters == null || characters.Count == 0) return true;
		for (int i = 0; i < characters.Count; i++)
		{
			if (characters[i] != null && !characters[i].IsDead())
				return false;
		}
		return true;
	}

	public bool SetNextCharacter()
	{
		if (characters == null) return false;
		for (int i = CurrentIndex + 1; i < characters.Count; i++)
		{
			if (characters[i] != null && !characters[i].IsDead())
			{
				CurrentIndex = i;
				return true;
			}
		}
		return false;
	}

	public BizAcqCharacterData FindCharacterByIndex(int index)
	{
		if (characters == null || index < 0 || index >= characters.Count)
			return null;
		return characters[index];
	}

	public BizAcqCharacterData FindCharacterByCeoIdx(int ceoIdx)
	{
		if (characters == null) return null;
		for (int i = 0; i < characters.Count; i++)
		{
			if (characters[i] != null && characters[i].CeoIdx == ceoIdx)
				return characters[i];
		}
		return null;
	}

	public int GetCharacterSlotIndex(int ceoIdx)
	{
		if (characters == null) return -1;
		for (int i = 0; i < characters.Count; i++)
		{
			if (characters[i] != null && characters[i].CeoIdx == ceoIdx)
				return i;
		}
		return -1;
	}

	public BizAcqCharacterData GetNextCharacter()
	{
		if (characters == null) return null;
		for (int i = CurrentIndex + 1; i < characters.Count; i++)
		{
			if (characters[i] != null && !characters[i].IsDead())
				return characters[i];
		}
		return null;
	}

	public bool HasNextCharacter()
	{
		return GetNextCharacter() != null;
	}

	public void Reset()
	{
		if (characters != null)
		{
			for (int i = 0; i < characters.Count; i++)
			{
				if (characters[i] != null)
					characters[i].Reset();
			}
		}
		CurrentIndex = 0;
	}

	public (int, int) GetTeamHpInfo()
	{
		int totalHp = 0;
		int totalMaxHp = 0;
		if (characters != null)
		{
			for (int i = 0; i < characters.Count; i++)
			{
				if (characters[i] != null)
				{
					totalHp += characters[i].CurrentHp;
					totalMaxHp += characters[i].MaxHp_Origin;
				}
			}
		}
		return (totalHp, totalMaxHp);
	}
}
