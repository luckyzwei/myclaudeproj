using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KWCore.SaveData
{
	public abstract class BucketBase
	{
		[Serializable]
		private class ListSaveHolder<T>
		{
			public List<T> savedList;
		}

		[Serializable]
		private class TemplateDictionary<K, V>
		{
			[SerializeField]
			public List<K> key;

			[SerializeField]
			public List<V> value;
		}

		private const string SERVER_VERSION = "server_version";

		private const string SAVE_TO_SERVER_DIRTY = "save_to_server_dirty";

		protected Hashtable m_data;

		private bool m_saveToDiskDirty;

		private const string KEY_APP_VERSION = "version";

		private const string KEY_DATA = "data";

		private const string KEY_COMPRESSED = "compressed";

		public bool CloudSaveDirty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string ServerVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private string SaveVersionKey => null;

		private string SaveToServerDirtyKey => null;

		public abstract string GetBucketKey();

		public abstract bool IsStoredInCloud();

		public virtual void RemoveAnyOldKeys(SaveDataManager saveDataManager)
		{
		}

		public virtual void TransferAnyKeysToAnotherBucket(SaveDataManager saveDataManager)
		{
		}

		public bool Contains(string key, string subKey = null)
		{
			return false;
		}

		private string ComposeFullKey(string key, string subKey)
		{
			return null;
		}

		private void SetValue(string key, string subKey, object value)
		{
		}

		private void SetValue(string key, object value)
		{
		}

		private T GetValue<T>(string key, string subKey, T defaultValue, ref bool hasKey)
		{
			return default(T);
		}

		private T GetValue<T>(string key, T defaultValue, ref bool hasKey)
		{
			return default(T);
		}

		public void SaveToDisk(bool force = false)
		{
		}

		public string ToJson()
		{
			return null;
		}

		public void FromJson(string json)
		{
		}

		public void LoadFromDisk()
		{
		}

		protected virtual void ProcessDataFromDisk()
		{
		}

		protected virtual void CompareKeysGreater(Hashtable serverData, string param, string append = "")
		{
		}

		private Hashtable BuildCompressedData()
		{
			return null;
		}

		private Hashtable BuildDecompressedData(Hashtable data)
		{
			return null;
		}

		public List<T> GetList<T>(string key, string subKey = null)
		{
			return null;
		}

		public Dictionary<K, V> GetDictionary<K, V>(string key, string subKey = null)
		{
			return null;
		}

		public float GetFloat(string key, float defaultValue = 0f, string subKey = null)
		{
			return 0f;
		}

		public string GetString(string key, string defaultValue = null, string subKey = null)
		{
			return null;
		}

		public int GetInt(string key, int defaultValue = 0, string subKey = null)
		{
			return 0;
		}

		public long GetLong(string key, long defaultValue = 0L, string subKey = null)
		{
			return 0L;
		}

		public bool GetBool(string key, bool defaultValue = false, string subKey = null)
		{
			return false;
		}

		public void SetBool(string key, bool value, string subKey = null)
		{
		}

		public void SetFloat(string key, float value, string subKey = null)
		{
		}

		public void SetString(string key, string value, string subKey = null)
		{
		}

		public void SetLong(string key, long value, string subKey = null)
		{
		}

		public int IncrementAndSetInt(string key, int increment, string subKey = null)
		{
			return 0;
		}

		public void SetInt(string key, int value, string subKey = null)
		{
		}

		public void SetList<T>(string key, List<T> list, string subKey = null)
		{
		}

		public void SetDictionary<K, V>(string key, Dictionary<K, V> dictionary, string subKey = null)
		{
		}

		public void TransferKeyAndSubkeys(string oldKey, string newKey, BucketBase transferBucket)
		{
		}

		public bool DeleteKey(string key, string subKey)
		{
			return false;
		}

		public void DeleteKeyAndSubkeys(string key)
		{
		}

		public void DeleteAll()
		{
		}
	}
}
