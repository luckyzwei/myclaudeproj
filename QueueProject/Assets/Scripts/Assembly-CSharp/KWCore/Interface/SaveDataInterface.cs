using KWCore.SaveData;
using UnityEngine;

namespace KWCore.Interface
{
	public abstract class SaveDataInterface : MonoBehaviour, SaveDataManager.IDelegate
	{
		public abstract void RegisterProjectBuckets(SaveDataManager saveDataManager);
	}
}
