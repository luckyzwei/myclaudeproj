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

		public int F { get { return G + H; } }

		public Node(bool _isObstacle, int _x, int _y, Vector3 _worldPos)
		{
			isObstacle = _isObstacle;
			x = _x;
			y = _y;
			WorldPos = _worldPos;
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

	public Vector2 MapSize { get { return new Vector2(_width, _height); } }

	public Grid GetMapGrid()
	{
		return MapGrid;
	}

	public Tilemap GetTileMap()
	{
		return ObstacleMap;
	}

	public void Init()
	{
		CachingList = new List<PathInfo>();
		OpenList = new List<Node>();
		ClosedList = new List<Node>();
		CreateGrid();
	}

	private void CreateGrid()
	{
		if (MapGrid == null) return;
		WorldBottomLeft = transform.position - Vector3.right * GridWorldSize.x / 2 - Vector3.up * GridWorldSize.y / 2;
		WorldTopRight = transform.position + Vector3.right * GridWorldSize.x / 2 + Vector3.up * GridWorldSize.y / 2;
		_width = Mathf.RoundToInt(GridWorldSize.x);
		_height = Mathf.RoundToInt(GridWorldSize.y);
		NodeArray = new Node[_width, _height];
		for (int x = 0; x < _width; x++)
		{
			for (int y = 0; y < _height; y++)
			{
				Vector3 worldPoint = WorldBottomLeft + Vector3.right * (x + 0.5f) + Vector3.up * (y + 0.5f);
				bool obstacle = false;
				if (ObstacleMap != null)
				{
					Vector3Int cellPos = ObstacleMap.WorldToCell(worldPoint);
					obstacle = ObstacleMap.HasTile(cellPos);
				}
				NodeArray[x, y] = new Node(obstacle, x, y, worldPoint);
			}
		}
	}

	public List<Node> FindPath(Vector3 startPosition, Vector3 endPosition)
	{
		StartNode = WorldToNode(startPosition);
		TargetNode = WorldToNode(endPosition);
		if (StartNode == null || TargetNode == null) return null;
		if (TargetNode.isObstacle) return null;
		OpenList.Clear();
		ClosedList.Clear();
		OpenList.Add(StartNode);
		while (OpenList.Count > 0)
		{
			CurNode = OpenList[0];
			for (int i = 1; i < OpenList.Count; i++)
			{
				if (OpenList[i].F < CurNode.F || (OpenList[i].F == CurNode.F && OpenList[i].H < CurNode.H))
					CurNode = OpenList[i];
			}
			OpenList.Remove(CurNode);
			ClosedList.Add(CurNode);
			if (CurNode == TargetNode)
			{
				List<Node> path = new List<Node>();
				Node node = TargetNode;
				while (node != StartNode)
				{
					path.Add(node);
					node = node.ParentNode;
				}
				path.Add(StartNode);
				path.Reverse();
				return path;
			}
			OpenListAdd(CurNode.x, CurNode.y + 1);
			OpenListAdd(CurNode.x, CurNode.y - 1);
			OpenListAdd(CurNode.x - 1, CurNode.y);
			OpenListAdd(CurNode.x + 1, CurNode.y);
		}
		return null;
	}

	private void OpenListAdd(int checkX, int checkY)
	{
		if (checkX < 0 || checkX >= _width || checkY < 0 || checkY >= _height) return;
		Node checkNode = NodeArray[checkX, checkY];
		if (checkNode.isObstacle || ClosedList.Contains(checkNode)) return;
		int moveCost = CurNode.G + 10;
		if (!OpenList.Contains(checkNode) || moveCost < checkNode.G)
		{
			checkNode.G = moveCost;
			checkNode.H = (Mathf.Abs(checkNode.x - TargetNode.x) + Mathf.Abs(checkNode.y - TargetNode.y)) * 10;
			checkNode.ParentNode = CurNode;
			if (!OpenList.Contains(checkNode))
				OpenList.Add(checkNode);
		}
	}

	public Node WorldToNode(Vector3 worldPosition)
	{
		if (NodeArray == null) return null;
		int x = Mathf.RoundToInt(worldPosition.x - WorldBottomLeft.x - 0.5f);
		int y = Mathf.RoundToInt(worldPosition.y - WorldBottomLeft.y - 0.5f);
		if (x < 0 || x >= _width || y < 0 || y >= _height) return null;
		return NodeArray[x, y];
	}

	public Node GetNode(int x, int y)
	{
		if (NodeArray == null || x < 0 || x >= _width || y < 0 || y >= _height) return null;
		return NodeArray[x, y];
	}

	private void OnDrawGizmos()
	{
		if (NodeArray == null) return;
		for (int x = 0; x < _width; x++)
		{
			for (int y = 0; y < _height; y++)
			{
				Gizmos.color = NodeArray[x, y].isObstacle ? Color.red : Color.green;
				Gizmos.DrawCube(NodeArray[x, y].WorldPos, Vector3.one * 0.5f);
			}
		}
	}

	public GameObject CreatePath(List<Node> Points)
	{
		if (Points == null || Points.Count < 2) return null;
		var go = new GameObject("Path");
		var lineRenderer = go.AddComponent<LineRenderer>();
		lineRenderer.positionCount = Points.Count;
		lineRenderer.startColor = linecolor;
		lineRenderer.endColor = linecolor;
		lineRenderer.startWidth = 0.1f;
		lineRenderer.endWidth = 0.1f;
		for (int i = 0; i < Points.Count; i++)
		{
			lineRenderer.SetPosition(i, Points[i].WorldPos);
		}
		return go;
	}

	private void OnDestroy()
	{
		NodeArray = null;
		if (OpenList != null) OpenList.Clear();
		if (ClosedList != null) ClosedList.Clear();
		if (CachingList != null) CachingList.Clear();
	}
}
