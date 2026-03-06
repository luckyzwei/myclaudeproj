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
		targetImg = GetComponent<Image>();
		if (targetImg != null)
		{
			mat = new Material(targetImg.material);
			targetImg.material = mat;
		}
	}

	private void Update()
	{
		if (mat == null) return;
		Vector2 offset = mat.mainTextureOffset;
		float delta = moveSpeed * Time.deltaTime;
		switch (direction)
		{
			case moveDir.LeftTop_To_RightBottom:
				offset += new Vector2(delta, -delta);
				break;
			case moveDir.RightTop_To_LeftBottom:
				offset += new Vector2(-delta, -delta);
				break;
			case moveDir.LeftBottom_To_RightTop:
				offset += new Vector2(delta, delta);
				break;
			case moveDir.RightBottom_To_LeftlTop:
				offset += new Vector2(-delta, delta);
				break;
		}
		mat.mainTextureOffset = offset;
	}

	private void OnDisable()
	{
		if (mat != null) mat.mainTextureOffset = Vector2.zero;
	}

	private void OnDestroy()
	{
		if (mat != null) Destroy(mat);
	}
}
