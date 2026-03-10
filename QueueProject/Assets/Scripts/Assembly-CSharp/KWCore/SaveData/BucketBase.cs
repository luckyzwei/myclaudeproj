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
				return GetBool(SaveToServerDirtyKey);
			}
			set
			{
				SetBool(SaveToServerDirtyKey, value);
			}
		}

		public string ServerVersion
		{
			get
			{
				return GetString(SaveVersionKey);
			}
			set
			{
				SetString(SaveVersionKey, value);
			}
		}

		private string SaveVersionKey => GetBucketKey() + "_" + SERVER_VERSION;

		private string SaveToServerDirtyKey => GetBucketKey() + "_" + SAVE_TO_SERVER_DIRTY;

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
			if (m_data == null) return false;
			string fullKey = ComposeFullKey(key, subKey);
			return m_data.ContainsKey(fullKey);
		}

		private string ComposeFullKey(string key, string subKey)
		{
			if (string.IsNullOrEmpty(subKey))
				return key;
			return key + "_" + subKey;
		}

		private void SetValue(string key, string subKey, object value)
		{
			SetValue(ComposeFullKey(key, subKey), value);
		}

		private void SetValue(string key, object value)
		{
			if (m_data == null) m_data = new Hashtable();
			m_data[key] = value;
			m_saveToDiskDirty = true;
		}

		private T GetValue<T>(string key, string subKey, T defaultValue, ref bool hasKey)
		{
			return GetValue(ComposeFullKey(key, subKey), defaultValue, ref hasKey);
		}

		private T GetValue<T>(string key, T defaultValue, ref bool hasKey)
		{
			if (m_data == null || !m_data.ContainsKey(key))
			{
				hasKey = false;
				return defaultValue;
			}
			hasKey = true;
			try
			{
				object val = m_data[key];
				if (val is T typedVal)
					return typedVal;
				return (T)Convert.ChangeType(val, typeof(T));
			}
			catch
			{
				return defaultValue;
			}
		}

		public void SaveToDisk(bool force = false)
		{
			if (!force && !m_saveToDiskDirty) return;
			string key = GetBucketKey();
			string json = ToJson();
			PlayerPrefs.SetString(key, json);
			PlayerPrefs.Save();
			m_saveToDiskDirty = false;
		}

		public string ToJson()
		{
			if (m_data == null) return "{}";
			return KWCore.Utils.JsonSerializer.JsonEncode(m_data);
		}

		public void FromJson(string json)
		{
			if (string.IsNullOrEmpty(json))
			{
				m_data = new Hashtable();
				return;
			}
			try
			{
				var parsed = KWCore.Utils.JsonSerializer.JsonDecode(json) as Hashtable;
				if (parsed != null)
				{
					m_data = parsed;
				}
				else
				{
					m_data = new Hashtable();
				}
			}
			catch
			{
				m_data = new Hashtable();
			}
		}

		public void LoadFromDisk()
		{
			string key = GetBucketKey();
			if (PlayerPrefs.HasKey(key))
			{
				string json = PlayerPrefs.GetString(key);
				FromJson(json);
			}
			else
			{
				m_data = new Hashtable();
			}
			ProcessDataFromDisk();
		}

		protected virtual void ProcessDataFromDisk()
		{
		}

		protected virtual void CompareKeysGreater(Hashtable serverData, string param, string append = "")
		{
		}

		private Hashtable BuildCompressedData()
		{
			return m_data;
		}

		private Hashtable BuildDecompressedData(Hashtable data)
		{
			return data;
		}

		public List<T> GetList<T>(string key, string subKey = null)
		{
			bool hasKey = false;
			string fullKey = ComposeFullKey(key, subKey);
			if (m_data == null || !m_data.ContainsKey(fullKey)) return null;
			object val = m_data[fullKey];
			if (val is List<T> typed) return typed;
			if (val is string json)
			{
				try
				{
					var holder = JsonUtility.FromJson<ListSaveHolder<T>>(json);
					return holder?.savedList;
				}
				catch { return null; }
			}
			return null;
		}

		public Dictionary<K, V> GetDictionary<K, V>(string key, string subKey = null)
		{
			bool hasKey = false;
			string fullKey = ComposeFullKey(key, subKey);
			if (m_data == null || !m_data.ContainsKey(fullKey)) return null;
			object val = m_data[fullKey];
			if (val is Dictionary<K, V> typed) return typed;
			if (val is string json)
			{
				try
				{
					var td = JsonUtility.FromJson<TemplateDictionary<K, V>>(json);
					if (td != null && td.key != null && td.value != null)
					{
						var dict = new Dictionary<K, V>();
						for (int i = 0; i < td.key.Count && i < td.value.Count; i++)
							dict[td.key[i]] = td.value[i];
						return dict;
					}
				}
				catch { }
			}
			return null;
		}

		public float GetFloat(string key, float defaultValue = 0f, string subKey = null)
		{
			bool hasKey = false;
			return GetValue(key, subKey, defaultValue, ref hasKey);
		}

		public string GetString(string key, string defaultValue = null, string subKey = null)
		{
			bool hasKey = false;
			return GetValue(key, subKey, defaultValue, ref hasKey);
		}

		public int GetInt(string key, int defaultValue = 0, string subKey = null)
		{
			bool hasKey = false;
			return GetValue(key, subKey, defaultValue, ref hasKey);
		}

		public long GetLong(string key, long defaultValue = 0L, string subKey = null)
		{
			bool hasKey = false;
			return GetValue(key, subKey, defaultValue, ref hasKey);
		}

		public bool GetBool(string key, bool defaultValue = false, string subKey = null)
		{
			bool hasKey = false;
			return GetValue(key, subKey, defaultValue, ref hasKey);
		}

		public void SetBool(string key, bool value, string subKey = null)
		{
			SetValue(key, subKey, value);
		}

		public void SetFloat(string key, float value, string subKey = null)
		{
			SetValue(key, subKey, value);
		}

		public void SetString(string key, string value, string subKey = null)
		{
			SetValue(key, subKey, value);
		}

		public void SetLong(string key, long value, string subKey = null)
		{
			SetValue(key, subKey, value);
		}

		public int IncrementAndSetInt(string key, int increment, string subKey = null)
		{
			int current = GetInt(key, 0, subKey);
			current += increment;
			SetInt(key, current, subKey);
			return current;
		}

		public void SetInt(string key, int value, string subKey = null)
		{
			SetValue(key, subKey, value);
		}

		public void SetList<T>(string key, List<T> list, string subKey = null)
		{
			SetValue(key, subKey, list);
		}

		public void SetDictionary<K, V>(string key, Dictionary<K, V> dictionary, string subKey = null)
		{
			SetValue(key, subKey, dictionary);
		}

		public void TransferKeyAndSubkeys(string oldKey, string newKey, BucketBase transferBucket)
		{
			if (m_data == null) return;
			var keysToTransfer = new List<string>();
			foreach (DictionaryEntry entry in m_data)
			{
				string k = entry.Key as string;
				if (k != null && k.StartsWith(oldKey))
					keysToTransfer.Add(k);
			}
			foreach (var k in keysToTransfer)
			{
				string newFullKey = newKey + k.Substring(oldKey.Length);
				if (transferBucket.m_data == null) transferBucket.m_data = new Hashtable();
				transferBucket.m_data[newFullKey] = m_data[k];
				m_data.Remove(k);
			}
			m_saveToDiskDirty = true;
		}

		public bool DeleteKey(string key, string subKey)
		{
			string fullKey = ComposeFullKey(key, subKey);
			if (m_data != null && m_data.ContainsKey(fullKey))
			{
				m_data.Remove(fullKey);
				m_saveToDiskDirty = true;
				return true;
			}
			return false;
		}

		public void DeleteKeyAndSubkeys(string key)
		{
			if (m_data == null) return;
			var keysToRemove = new List<string>();
			foreach (DictionaryEntry entry in m_data)
			{
				string k = entry.Key as string;
				if (k != null && k.StartsWith(key))
					keysToRemove.Add(k);
			}
			foreach (var k in keysToRemove)
				m_data.Remove(k);
			m_saveToDiskDirty = true;
		}

		public void DeleteAll()
		{
			m_data = new Hashtable();
			m_saveToDiskDirty = true;
		}
	}
}
