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
	}

	public void UpdateCharacter(AdSupplySystem.Status status, Action cb = null)
	{
	}

	public void OnClickVIP()
	{
	}

	private void Update()
	{
	}

	private Direction GetDir(Vector2 curPos, Vector2 nextPos)
	{
		return default(Direction);
	}

	private void SetAni(State state, Direction dir)
	{
	}
}
