using System;
using System.Collections.Generic;
using KWAudio;
using Spine.Unity;
using UnityEngine;

[CreateAssetMenu(fileName = "JigsawPuzzlesDb", menuName = "ScriptableObjects/JigsawPuzzlesDb", order = 2)]
public class JigsawPuzzlesDb : ScriptableObject
{
	[Serializable]
	public struct JigsawPuzzleData
	{
		public string clientID;

		public Texture2D image;

		public SkeletonDataAsset skeletonDataAsset;

		public AudioClipReference puzzleSfx;
	}

	[Serializable]
	public struct EventPosterData
	{
		public string clientID;

		public Sprite image;

		public Sprite eventFinishedImage;

		public Sprite eventTitle;
	}

	[Serializable]
	public struct JigsawBackgroundImage
	{
		public Vector2Int size;

		public Sprite image;
	}

	public JigsawPuzzleContainer[] puzzles;

	public JigsawBackgroundImage[] bgImages;

	public EventPosterData[] eventPosters;

	private Dictionary<string, JigsawPuzzleContainer> m_puzzlesDict;

	private Dictionary<string, EventPosterData> m_postersDict;

	private bool m_isPopulated;

	private void PopulateDictionary()
	{
	}

	public Texture2D GetPuzzleImage(string clientID)
	{
		return null;
	}

	public SkeletonDataAsset GetSpineSkeleton(string clientId)
	{
		return null;
	}

	public EventPosterData GetEventPoster(string clientID)
	{
		return default(EventPosterData);
	}

	public Sprite GetBgImage(Vector2Int size)
	{
		return null;
	}

	public JigsawPuzzleContainer GetJigsawPuzzleData(string clientID)
	{
		return null;
	}
}
