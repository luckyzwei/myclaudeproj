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
			this.character = null;
			this.isCritical = false;
			this.mood = default(EmployeeMoodSystem.Mood);
		}
	}

	[SerializeField]
	private AssetReference FxBurningGoodPref;

	[SerializeField]
	private AssetReference FxBurningVeryGoodPref;

	private Dictionary<int, CompositeDisposable> barrowBurningDisposables;

	private void BarrowBurning(Transform character, EmployeeMoodSystem.Mood mood)
	{
	}

	private void ReturnBurnings(Transform character)
	{
	}

	public CompositeDisposable Subscribe(IObservable<BurningArgs> observable)
	{
		return null;
	}
}
