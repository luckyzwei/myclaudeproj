using UnityEngine;
using UnityEngine.Rendering;

[ExecuteAlways]
public class BendingManager : MonoBehaviour
{
	private const string BENDING_FEATURE = "ENABLE_BENDING";

	private const string PLANET_FEATURE = "ENABLE_BENDING_PLANET";

	private static readonly int BENDING_AMOUNT;

	[SerializeField]
	private bool enablePlanet;

	[SerializeField]
	[Range(0.005f, 0.1f)]
	private float bendingAmount;

	private float _prevAmount;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdateBendingAmount()
	{
	}

	private static void OnBeginCameraRendering(ScriptableRenderContext ctx, Camera cam)
	{
	}

	private static void OnEndCameraRendering(ScriptableRenderContext ctx, Camera cam)
	{
	}
}
