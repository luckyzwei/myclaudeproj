using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace KWGameCore
{
	[HelpURL("http://wiki.kwalee.local/index.php?title=Mesh_Outline")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class MeshOutline : MonoBehaviour
	{
		public enum Mode
		{
			OutlineAll = 0,
			OutlineVisible = 1,
			OutlineHidden = 2,
			OutlineAndSilhouette = 3,
			SilhouetteOnly = 4
		}

		[Serializable]
		public struct RenderData
		{
			public Renderer renderer;

			public Mesh sharedMesh;
		}

		[Serializable]
		private struct MaterialModeData
		{
			public Material outlineMaskMaterial;

			public Material outlineFillMaterial;
		}

		[SerializeField]
		private Mode m_outlineMode;

		[SerializeField]
		private Color m_outlineColor;

		[SerializeField]
		[Range(0f, 10f)]
		private float m_outlineWidth;

		[Tooltip("Fix issues where the outline is not properly rendered because the mesh has not set the right normals for some vertices.")]
		[SerializeField]
		private bool m_recalculateNormals;

		[SerializeField]
		private RenderData[] m_renderDatas;

		private static readonly int _OutlineColor;

		private static readonly int _OutlineWidth;

		private static readonly int _ZTest;

		private static HashSet<Mesh> s_registeredMeshes;

		private static Dictionary<Mode, MaterialModeData> s_materials;

		private static int s_nextBakedMeshAvailable;

		private static List<Mesh> s_bakedMeshList;

		private Material m_outlineMaskMaterial;

		private Material m_outlineFillMaterial;

		private bool m_updateMaterialsFlag;

		private MaterialPropertyBlock m_propertyBlockFill;

		private MaterialPropertyBlock m_propertyBlockMask;

		private static List<Renderer> s_renderersTempList;

		public Mode OutlineMode
		{
			get
			{
				return default(Mode);
			}
			set
			{
			}
		}

		public Color OutlineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float OutlineWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IsInitialised { get; private set; }

		private void OnValidate()
		{
		}

		private void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDidApplyAnimationProperties()
		{
		}

		private void RenderPipelineManagerOnbeginFrameRendering(ScriptableRenderContext context, Camera[] cameras)
		{
		}

		private void RenderPipelineManagerOnendFrameRendering(ScriptableRenderContext context, Camera[] cameras)
		{
		}

		private void RenderMeshOutline(Camera[] cameras)
		{
		}

		private static Mesh GetTempBakeMesh()
		{
			return null;
		}

		public bool Initialise()
		{
			return false;
		}

		public void PopulateRendererList()
		{
		}

		private void LoadSmoothNormals()
		{
		}

		private List<Vector3> SmoothNormals(Mesh mesh)
		{
			return null;
		}

		private void UpdateMaterialProperties()
		{
		}
	}
}
