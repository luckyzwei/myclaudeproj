using KWAudio;
using Spine.Unity;
using UnityEngine;

[CreateAssetMenu(fileName = "JigsawPuzzleContainer", menuName = "ScriptableObjects/JigsawPuzzleContainer", order = 2)]
public class JigsawPuzzleContainer : ScriptableObject
{
	public string clientID;

	public Texture2D image;

	public SkeletonDataAsset skeletonDataAsset;

	public AudioClipReference puzzleSfx;
}
