using UnityEngine;
using UnityEngine.UI;

public class TileComponent : MonoBehaviour
{
	private enum moveDir
	{
		LeftTop_To_RightBottom = 0,
		RightTop_To_LeftBottom = 1,
		LeftBottom_To_RightTop = 2,
		RightBottom_To_LeftlTop = 3
	}

	[SerializeField]
	private float moveSpeed;

	[SerializeField]
	private moveDir direction;

	private Material mat;

	private Image targetImg;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
