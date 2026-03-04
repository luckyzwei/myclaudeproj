using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class InGameAstar : MonoBehaviour
{
	[Serializable]
	public class Node
	{
		public bool isObstacle;

		public Node ParentNode;

		public Vector3 WorldPos;

		public int x;

		public int y;

		public int G;

		public int H;

		public int F { get { return 0; } }

		public Node(bool _isObstacle, int _x, int _y, Vector3 _worldPos)
		{
		}
	}

	[Serializable]
	public class PathInfo
	{
		public Vector2 StartTile;

		public Vector2 EndTile;

		public List<Node> Nodes;
	}

	[SerializeField]
	private Grid MapGrid;

	[SerializeField]
	private Vector3 GridWorldSize;

	[SerializeField]
	private Tilemap ObstacleMap;

	[SerializeField]
	private Color linecolor;

	private Node StartNode;

	private Node TargetNode;

	private Node CurNode;

	private Node[,] NodeArray;

	private List<Node> OpenList;

	private List<Node> ClosedList;

	private List<PathInfo> CachingList;

	private int _width;

	private int _height;

	public Vector3Int startCell;

	public Vector3 WorldBottomLeft { get; private set; }

	public Vector3 WorldTopRight { get; private set; }

	public Vector2 MapSize { get { return default(Vector2); } }

	public Grid GetMapGrid()
	{
		return null;
	}

	public Tilemap GetTileMap()
	{
		return null;
	}

	public void Init()
	{
	}

	private void CreateGrid()
	{
	}

	public List<Node> FindPath(Vector3 startPosition, Vector3 endPosition)
	{
		return null;
	}

	private void OpenListAdd(int checkX, int checkY)
	{
	}

	public Node WorldToNode(Vector3 worldPosition)
	{
		return null;
	}

	public Node GetNode(int x, int y)
	{
		return null;
	}

	private void OnDrawGizmos()
	{
	}

	public GameObject CreatePath(List<Node> Points)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
