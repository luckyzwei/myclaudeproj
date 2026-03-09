using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

public class JigsawGenerator : MonoBehaviour
{
	private enum Connector
	{
		Flat = 0,
		KnobOut = 1,
		SocketIn = 2
	}

	private enum JigsawEdge
	{
		Top = 0,
		Bottom = 1,
		Left = 2,
		Right = 3
	}

	[BurstCompile]
	public struct JigsawAtlasGenerationJob : IJobParallelFor
	{
		[ReadOnly]
		public NativeArray<Color32> SourcePixels;

		[ReadOnly]
		public int SourceWidth;

		[ReadOnly]
		public int SourceHeight;

		[ReadOnly]
		public int NumPiecesH;

		[ReadOnly]
		public int NumPiecesV;

		[ReadOnly]
		public int CellWidth;

		[ReadOnly]
		public int CellHeight;

		[ReadOnly]
		public float Padding;

		[ReadOnly]
		public float ActualKnobRadius;

		[ReadOnly]
		public int PieceTexWidth;

		[ReadOnly]
		public int PieceTexHeight;

		[ReadOnly]
		public int AtlasTotalWidth;

		[ReadOnly]
		public int AtlasTotalHeight;

		[ReadOnly]
		public NativeArray<int> HorizontalConnectors;

		[ReadOnly]
		public NativeArray<int> VerticalConnectors;

		[NativeDisableParallelForRestriction]
		public NativeArray<Color32> AtlasPixels;

		public void Execute(int pieceIndex)
		{
		}

		private void DrawKnobOrSocketShapeJob(JigsawEdge edge, bool isKnob, int pieceR, int pieceC, int pieceAtlasBaseX, int pieceAtlasBaseY)
		{
		}

		private Connector InvertConnector(Connector conn)
		{
			return default(Connector);
		}

		private int GetPixelArrayIndexJob(int x_coord, int y_coord, int textureWidth, int textureHeight)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public JigsawGenerator _003C_003E4__this;

		public string fullAtlasDir;

		public string atlasImagePath;

		public string metadataPath;

		public byte[] pngData;

		public string newJson;

		internal void _003CGenerateAtlasCoroutine_003Eb__0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CGenerateAtlasCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JigsawGenerator _003C_003E4__this;

		private _003C_003Ec__DisplayClass23_0 _003C_003E8__1;

		public Action onCompletionCallback;

		private bool _003Csuccess_003E5__2;

		private NativeArray<Color32> _003CsourcePixelsNative_003E5__3;

		private NativeArray<Color32> _003CatlasPixelsNative_003E5__4;

		private float _003CknobFactor_003E5__5;

		private int _003CcalcCellWidth_003E5__6;

		private int _003CcalcCellHeight_003E5__7;

		private float _003CcalcActualKnobRadius_003E5__8;

		private float _003CcalcPadding_003E5__9;

		private int _003CcalcPieceTexWidth_003E5__10;

		private int _003CcalcPieceTexHeight_003E5__11;

		private string _003CsourceImageNameHash_003E5__12;

		private PuzzleAtlasMetadata _003CloadedMeta_003E5__13;

		private List<Rect> _003CpieceRectsFromMeta_003E5__14;

		private int _003CatlasTotalWidth_003E5__15;

		private int _003CatlasTotalHeight_003E5__16;

		private JobHandle _003CjobHandle_003E5__17;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGenerateAtlasCoroutine_003Ed__23(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const int RANDOM_SEED = 17;

	[HideInInspector]
	public bool isGenerating;

	private Texture2D sourceImage;

	private int numPiecesH_current;

	private int numPiecesV_current;

	private Dictionary<string, List<GameObject>> m_spawnedPieces;

	private Texture2D _generatedAtlasTexture;

	private List<Sprite> _generatedPieceSprites;

	private PuzzleAtlasMetadata _lastGeneratedMetadata;

	private NativeArray<int> horizontalConnectors_Native;

	private NativeArray<int> verticalConnectors_Native;

	public event Action OnGenerationStarted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnAtlasGenerationCompletedSuccessfully
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnAtlasGenerationFailed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void GenerateAtlas(Texture2D texture2D, int width, int height, Action onCompletionCallback = null)
	{
	}

	[IteratorStateMachine(typeof(_003CGenerateAtlasCoroutine_003Ed__23))]
	private IEnumerator GenerateAtlasCoroutine(Action onCompletionCallback)
	{
		return null;
	}

	private void Log(string text)
	{
	}

	public List<GameObject> SpawnPieces(RectTransform specificUiParentArea = null, string subkey = "default")
	{
		return null;
	}

	private void SpawnSpriteRendererPieceInternal(Sprite pieceSprite, int r_grid, int c_grid, int cellPixelWidth_content, int cellPixelHeight_content, string subkey)
	{
	}

	private void SpawnUiPieceInternal(Sprite pieceSprite, int r_grid, int c_grid, int cellPixelWidth_content, int cellPixelHeight_content, Transform parentTransform, float applyScaleX, float applyScaleY, string subkey)
	{
	}

	private void SetupConnectorConfiguration()
	{
	}

	private bool GetRandomBool(System.Random rng, int i, int j, bool horizontal)
	{
		return false;
	}

	private string GetTextureHash(Texture2D texture)
	{
		return null;
	}

	private bool ValidateMetadata(PuzzleAtlasMetadata metadata, string currentImageHash, int currentCalcPieceTexWidth, int currentCalcPieceTexHeight)
	{
		return false;
	}
}
