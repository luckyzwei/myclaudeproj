using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

/// <summary>
/// Auto play test. Creates a trigger file, then launches Unity.
/// When Unity opens and detects the trigger file, it auto-enters Play Mode.
/// </summary>
[InitializeOnLoad]
public class AutoPlayTest
{
    private static readonly string OutputDir = "I:/client/myclaudeproj/autotest_output";
    private static readonly string TriggerFile = "I:/client/myclaudeproj/autotest_output/TRIGGER";
    private static readonly string LogFile = "I:/client/myclaudeproj/autotest_output/test_log.txt";
    private static readonly string DoneFile = "I:/client/myclaudeproj/autotest_output/DONE";
    private static readonly float TestDuration = 300f; // 5 min for progression test
    private static readonly float ScreenshotInterval = 30f;

    private static List<string> capturedLogs = new List<string>();
    private static bool isRunning = false;

    static AutoPlayTest()
    {
        // Check for trigger file on domain reload
        if (File.Exists(TriggerFile) && !EditorApplication.isPlayingOrWillChangePlaymode)
        {
            Debug.Log("[AutoTest] Trigger file detected! Starting test...");
            File.Delete(TriggerFile);
            // Delay to ensure Unity window is fully ready
            EditorApplication.delayCall += () =>
            {
                EditorApplication.delayCall += () =>
                {
                    // Focus and maximize Game View
                    UnityEditorInternal.InternalEditorUtility.RepaintAllViews();
                    var gameViewType = typeof(EditorWindow).Assembly.GetType("UnityEditor.GameView");
                    var gameView = EditorWindow.GetWindow(gameViewType);
                    if (gameView != null)
                    {
                        gameView.Focus();
                        gameView.maximized = true;
                    }
                    StartTest();
                };
            };
        }
    }

    private static void StartTest()
    {
        if (EditorApplication.isPlaying) return;

        Directory.CreateDirectory(OutputDir);
        // Clean old screenshots
        foreach (var f in Directory.GetFiles(OutputDir, "shot_*.png"))
            File.Delete(f);
        if (File.Exists(LogFile)) File.Delete(LogFile);
        if (File.Exists(DoneFile)) File.Delete(DoneFile);

        SetupLogCapture();
        EditorApplication.playModeStateChanged += OnPlayModeChanged;

        // Ensure Main scene is loaded
        var mainScene = "Assets/Scenes/Main.unity";
        if (SceneManager.GetActiveScene().path != mainScene)
        {
            UnityEditor.SceneManagement.EditorSceneManager.OpenScene(mainScene);
        }

        EditorApplication.isPlaying = true;
    }

    [MenuItem("Tools/Auto Play Test")]
    public static void RunFromMenu()
    {
        StartTest();
    }

    private static void OnPlayModeChanged(PlayModeStateChange state)
    {
        if (state == PlayModeStateChange.EnteredPlayMode && !isRunning)
        {
            isRunning = true;
            var go = new GameObject("AutoTestRunner");
            go.AddComponent<AutoTestRunner>();
            UnityEngine.Object.DontDestroyOnLoad(go);
        }
        else if (state == PlayModeStateChange.ExitingPlayMode)
        {
            isRunning = false;
            EditorApplication.playModeStateChanged -= OnPlayModeChanged;
            SaveLogs();
            // Write done marker
            File.WriteAllText(DoneFile, DateTime.Now.ToString());
        }
    }

    private static void SetupLogCapture()
    {
        capturedLogs.Clear();
        Application.logMessageReceived += OnLogMessage;
    }

    private static void OnLogMessage(string condition, string stackTrace, LogType type)
    {
        string prefix = type == LogType.Error ? "[ERROR]" :
                        type == LogType.Warning ? "[WARN]" :
                        type == LogType.Exception ? "[EXCEPTION]" : "[LOG]";
        string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
        capturedLogs.Add($"{timestamp} {prefix} {condition}");
        if (type == LogType.Exception || type == LogType.Error)
        {
            if (!string.IsNullOrEmpty(stackTrace))
                capturedLogs.Add($"  Stack: {stackTrace.Substring(0, Math.Min(500, stackTrace.Length))}");
        }
    }

    public static void SaveLogs()
    {
        Application.logMessageReceived -= OnLogMessage;
        try
        {
            File.WriteAllLines(LogFile, capturedLogs);
        }
        catch (Exception) { }
    }

    public static string GetOutputDir() => OutputDir;
    public static float GetTestDuration() => TestDuration;
    public static float GetScreenshotInterval() => ScreenshotInterval;
}

public class AutoTestRunner : MonoBehaviour
{
    private float elapsed = 0f;
    private float nextScreenshot = 0f;
    private int screenshotIdx = 0;
    private float nextSceneCheck = 0f;
    private string lastScene = "";

    void Start()
    {
        Debug.Log($"[AutoTest] ===== TEST STARTED =====");
        Debug.Log($"[AutoTest] Active scene: {SceneManager.GetActiveScene().name}");
        LogSceneInfo();
        nextScreenshot = 1f;
        nextSceneCheck = 0.5f;
        lastScene = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
        elapsed += Time.unscaledDeltaTime;

        if (elapsed >= nextSceneCheck)
        {
            string cur = SceneManager.GetActiveScene().name;
            if (cur != lastScene)
            {
                Debug.Log($"[AutoTest] Scene changed: {lastScene} -> {cur} (t={elapsed:F1}s)");
                lastScene = cur;
                LogSceneInfo();
            }
            nextSceneCheck += 0.5f;
        }

        if (elapsed >= nextScreenshot)
        {
            StartCoroutine(CaptureScreenshot());
            nextScreenshot += AutoPlayTest.GetScreenshotInterval();
        }

        if (elapsed >= AutoPlayTest.GetTestDuration())
        {
            Debug.Log($"[AutoTest] ===== TEST COMPLETE ({elapsed:F1}s) =====");
            LogFinalState();
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }
    }

    void LogSceneInfo()
    {
        var roots = SceneManager.GetActiveScene().GetRootGameObjects();
        Debug.Log($"[AutoTest] Scene '{SceneManager.GetActiveScene().name}' has {roots.Length} root objects:");
        foreach (var obj in roots)
        {
            var comps = obj.GetComponents<MonoBehaviour>();
            string cs = "";
            foreach (var c in comps) { if (c != null) cs += c.GetType().Name + ","; }
            Debug.Log($"  {obj.name} active={obj.activeSelf} [{cs}]");
        }
    }

    void LogFinalState()
    {
        var gameRoot = FindObjectOfType<GameRoot>();
        if (gameRoot != null)
        {
            Debug.Log($"[AutoTest] GameRoot OK, scene={gameRoot.gameObject.scene.name}");
            Debug.Log($"  UserData={gameRoot.UserData != null} InGameSystem={gameRoot.InGameSystem != null}");
            Debug.Log($"  SceneSystem={gameRoot.SceneSystem != null} DaySystem={gameRoot.DaySystem != null}");
            Debug.Log($"  CompanySystem={gameRoot.CompanySystem != null} LoadComplete={GameRoot.LoadComplete}");
            if (gameRoot.UserData != null)
                Debug.Log($"  mainData={gameRoot.UserData.mainData != null} Level={gameRoot.UserData.Level?.Value}");
        }
        else
        {
            Debug.Log("[AutoTest] GameRoot NOT FOUND!");
            var all = Resources.FindObjectsOfTypeAll<GameRoot>();
            Debug.Log($"[AutoTest] FindAll<GameRoot>={all.Length}");
        }
    }

    IEnumerator CaptureScreenshot()
    {
        yield return new WaitForEndOfFrame();
        screenshotIdx++;
        string path = $"{AutoPlayTest.GetOutputDir()}/shot_{screenshotIdx:D3}.png";
        try { ScreenCapture.CaptureScreenshot(path); }
        catch (Exception e) { Debug.Log($"[AutoTest] Screenshot failed: {e.Message}"); }
    }
}
