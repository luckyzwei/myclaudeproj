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
		_prevAmount = bendingAmount;
	}

	private void OnEnable()
	{
		Shader.EnableKeyword(BENDING_FEATURE);
		if (enablePlanet) Shader.EnableKeyword(PLANET_FEATURE);
		else Shader.DisableKeyword(PLANET_FEATURE);
		UpdateBendingAmount();
		RenderPipelineManager.beginCameraRendering += OnBeginCameraRendering;
		RenderPipelineManager.endCameraRendering += OnEndCameraRendering;
	}

	private void Update()
	{
		if (Mathf.Abs(_prevAmount - bendingAmount) > 0.0001f)
		{
			UpdateBendingAmount();
			_prevAmount = bendingAmount;
		}
	}

	private void OnDisable()
	{
		Shader.DisableKeyword(BENDING_FEATURE);
		Shader.DisableKeyword(PLANET_FEATURE);
		RenderPipelineManager.beginCameraRendering -= OnBeginCameraRendering;
		RenderPipelineManager.endCameraRendering -= OnEndCameraRendering;
	}

	private void UpdateBendingAmount()
	{
		Shader.SetGlobalFloat(BENDING_AMOUNT, bendingAmount);
	}

	private static void OnBeginCameraRendering(ScriptableRenderContext ctx, Camera cam)
	{
		Shader.SetGlobalVector("_WorldSpaceCameraPos_Bending", cam.transform.position);
	}

	private static void OnEndCameraRendering(ScriptableRenderContext ctx, Camera cam)
	{
		// TODO
	}
}
