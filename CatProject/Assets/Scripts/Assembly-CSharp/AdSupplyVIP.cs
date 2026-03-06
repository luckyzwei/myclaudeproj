using System;
using System.Collections.Generic;
using UnityEngine;

public class AdSupplyVIP : MonoBehaviour
{
	public enum State
	{
		Move = 0,
		Idle = 1
	}

	private enum Direction
	{
		Front_Left = 0,
		Front_Right = 1,
		Front = 2,
		Back_Left = 3,
		Back_Right = 4,
		Back = 5
	}

	[SerializeField]
	private GameObject CharacterObj;

	[SerializeField]
	private Animator CharAni;

	private AdSupplySystem.AdsupplyType Type;

	private DoTweenScriptComponent ClickTweenSeq;

	private List<InGameAstar.Node> MoveNodes;

	private Queue<InGameAstar.Node> MoveNodeList;

	private InGameAstar.Node CurTargetNode;

	private State state;

	private Vector3 originPos;

	private Action NextAction;

	public void Init(AdSupplySystem.AdsupplyType type, Vector3 pos)
	{
		Type = type;
		originPos = pos;
		MoveNodeList = new Queue<InGameAstar.Node>();
		state = State.Idle;
		if (CharacterObj != null) CharacterObj.SetActive(true);
	}

	public void UpdateCharacter(AdSupplySystem.Status status, Action cb = null)
	{
		if (status == AdSupplySystem.Status.Hide)
		{
			if (CharacterObj != null) CharacterObj.SetActive(false);
		}
		else
		{
			if (CharacterObj != null) CharacterObj.SetActive(true);
		}
		cb?.Invoke();
	}

	public void OnClickVIP()
	{
		NextAction?.Invoke();
	}

	private void Update()
	{
	}

	private Direction GetDir(Vector2 curPos, Vector2 nextPos)
	{
		Vector2 diff = nextPos - curPos;
		if (Mathf.Abs(diff.x) > Mathf.Abs(diff.y))
			return diff.x > 0 ? Direction.Front_Right : Direction.Front_Left;
		return diff.y > 0 ? Direction.Back : Direction.Front;
	}

	private void SetAni(State state, Direction dir)
	{
		if (CharAni == null) return;
		CharAni.SetInteger("State", (int)state);
		CharAni.SetInteger("Dir", (int)dir);
	}
}
