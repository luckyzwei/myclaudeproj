using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Crosstales.BWF.Data
{
	[Serializable]
	[HelpURL("https://www.crosstales.com/media/data/assets/badwordfilter/api/class_crosstales_1_1_b_w_f_1_1_data_1_1_source.html")]
	[CreateAssetMenu(fileName = "New Source", menuName = "Bad Word Filter PRO/Source", order = 1000)]
	public class Source : ScriptableObject
	{
		[FormerlySerializedAs("Name")]
		[SerializeField]
		[Header("Information")]
		[Tooltip("Name of the source.")]
		private string sourceName;

		[FormerlySerializedAs("Culture")]
		[SerializeField]
		[Tooltip("Culture of the source (ISO 639-1).")]
		private string culture;

		[FormerlySerializedAs("Description")]
		[SerializeField]
		[Tooltip("Description for the source (optional).")]
		private string description;

		[FormerlySerializedAs("Icon")]
		[SerializeField]
		[Tooltip("Icon to represent the source (e.g. country flag, optional)")]
		private Sprite icon;

		[FormerlySerializedAs("URL")]
		[SerializeField]
		[Header("Settings")]
		[Tooltip("URL of a text file containing all regular expressions for this source. Add also the protocol-type ('http://', 'file://' etc.).")]
		private string url;

		[FormerlySerializedAs("Resource")]
		[SerializeField]
		[Tooltip("Text file containing all regular expressions for this source.")]
		private TextAsset resource;

		[SerializeField]
		[Tooltip("Indicates if the 'Resource' is used as fallback in case the URL could not be loaded.")]
		private bool isResourceFallback;

		public string SourceName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Culture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite Icon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string URL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextAsset Resource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsResourceFallback
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int RegexCount => 0;

		public string[] Regexes { get; set; }

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
