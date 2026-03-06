using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class PoolingCharacterEffect : MonoBehaviour
{
	public class BurningComponent : MonoBehaviour
	{
	}

	public struct BurningArgs
	{
		public Transform character;

		public bool isCritical;

		public EmployeeMoodSystem.Mood mood;

		public BurningArgs(Transform character, bool isCritical, EmployeeMoodSystem.Mood mood = EmployeeMoodSystem.Mood.Bad)
		{
			this.character = character;
			this.isCritical = isCritical;
			this.mood = mood;
		}
	}

	[SerializeField]
	private AssetReference FxBurningGoodPref;

	[SerializeField]
	private AssetReference FxBurningVeryGoodPref;

	private Dictionary<int, CompositeDisposable> barrowBurningDisposables;

	private void BarrowBurning(Transform character, EmployeeMoodSystem.Mood mood)
	{
		if (character == null) return;
		// Load and attach burning effect to character
	}

	private void ReturnBurnings(Transform character)
	{
		if (character == null) return;
		int id = character.GetInstanceID();
		if (barrowBurningDisposables != null && barrowBurningDisposables.TryGetValue(id, out var d))
		{
			d?.Dispose();
			barrowBurningDisposables.Remove(id);
		}
	}

	public CompositeDisposable Subscribe(IObservable<BurningArgs> observable)
	{
		return null;
	}
}
