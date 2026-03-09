using UnityEngine;
using UnityEngine.Serialization;

namespace KWCore.Loading
{
	public class LoadingInterface : MonoBehaviour
	{
		[Tooltip("The scene to load after loading has finished. Leave empty to not load a scene.")]
		[FormerlySerializedAs("m_mainSceneName")]
		public string sceneToLoad;

		[Tooltip("The loading screen to show while the SDK and scene are loading. Leave empty if you use a custom loading system.")]
		public GameObject loadingScreenPrefab;

		[Tooltip("The splash screen prefab to show on boot. Leave empty to not show a splash screen.")]
		public GameObject splashScreenPrefab;

		[FormerlySerializedAs("m_splashLength")]
		public float splashScreenDurationSeconds;

		[Tooltip("The maximum time to wait for all objects to get unregistered on first boot. This is ignored if an object has the waitTillUnregistered flag set.")]
		public float maxLoadTimeFirstBootSeconds;

		[Tooltip("If true the loading screen will keep showing until a Gameplay Kwalee Canvas registers (Is Gameplay Canvas option on Kwalee Canvas). This is useful if an on-boot popup relies on that canvas.")]
		[FormerlySerializedAs("m_waitForCanvasOverride")]
		public bool waitForGameplayCanvas;
	}
}
