using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Balancy.Models.KWDecorama;
using KWCore.Utils;
using KWGameCore;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DecoramaManager : MonoSingleton<DecoramaManager>
{
	[CompilerGenerated]
	private sealed class _003CRemoveSceneCoroutine_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DecoramaManager _003C_003E4__this;

		private float _003Ctimer_003E5__2;

		private float _003Ctime_003E5__3;

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
		public _003CRemoveSceneCoroutine_003Ed__46(int _003C_003E1__state)
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public const string NOTIFICATION_WIDGET_ID = "Decorama";

	public const string DECORAMA_PROGRESSREWARD_ID = "decorama";

	public const string DECORAMA_CURRENCY_ID = "paint_point";

	private const string DECORAMA_SCENE = "DecoramaScene";

	private const float UNLOAD_DELAY_SEC = 10f;

	[SerializeField]
	private ParticleSystem m_paintableCompleteVFX;

	[SerializeField]
	private DecoramaContainer m_decoramaContainer;

	[SerializeField]
	private Material m_lockedMaterial;

	private Transform m_buildPosTransform;

	private RectTransform m_renderTextureRextTransform;

	private RenderTexture m_decoramaRenderTexture;

	private Scene m_decoramaCachedScene;

	private Scene m_previousScene;

	private bool m_isTryingToLoadScene;

	private Coroutine m_removeSceneCoroutine;

	private Pool<ParticleSystem> m_paintableCompleteVFXPool;

	private DecoramaController m_decoramaController;

	private int m_cachedPaintPoints;

	private List<Decorama> m_orderedDecoramas;

	public DecoramaContainer DecoramaContainer => null;

	public DecoramaController DecoramaController => null;

	public Material LockedMaterial => null;

	public Vector3 DecoramaBuildButtonPosition => default(Vector3);

	public Vector3 DecoramaRenderTexturePos => default(Vector3);

	public int DecoramaCount { get; private set; }

	public Camera DecoramaCamera { get; private set; }

	protected override void Init()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void TryShowDecoramaFlow(Action flowCompleteCallback)
	{
	}

	public void TryAwardPaintPointsExplosion(Vector3 startPos, Transform endPos, Action firstElementReached, Action explosionCompleteCallback)
	{
	}

	private void ShowDecoramaBuildFlow(Action buildFlowCallback)
	{
	}

	public void CacheDecoramaWidgetProperties(Transform buildButton, RectTransform rTTransform)
	{
	}

	public void LoadDecoramaScene(DecoramaState decoramaState)
	{
	}

	private void OnDecoramaSceneLoaded(AsyncOperation asyncOperation, DecoramaState decoramaState)
	{
	}

	public void UnLoadDecoramaScene()
	{
	}

	[IteratorStateMachine(typeof(_003CRemoveSceneCoroutine_003Ed__46))]
	private IEnumerator RemoveSceneCoroutine()
	{
		return null;
	}

	public void ConfigDecoramaController(DecoramaController decoramaController, Camera decoramaCamera)
	{
	}

	private void AdjustRenderTexture(Camera camera)
	{
	}

	public List<Decorama> GetOrderedDecoramas()
	{
		return null;
	}

	public List<DecoramaData> GetOrderedDecoramaSettings()
	{
		return null;
	}

	public DecoramaData GetDecoramaSettings(int index)
	{
		return null;
	}

	public bool AllDecoramasComplete()
	{
		return false;
	}

	public int ActiveDecoramaIndex()
	{
		return 0;
	}

	private void SetupOrderedDecoramas()
	{
	}

	private void OnSmartObjectsInitializedEvent()
	{
	}

	public void SpawnPaintableCompleteVFX(Vector3 position)
	{
	}

	public void AddPaintPoints(int amount)
	{
	}

	public void AllPaintPointsUsed()
	{
	}

	public int GetCachedDecoramaPoints()
	{
		return 0;
	}

	public bool IsDecoramaEnabled()
	{
		return false;
	}
}
