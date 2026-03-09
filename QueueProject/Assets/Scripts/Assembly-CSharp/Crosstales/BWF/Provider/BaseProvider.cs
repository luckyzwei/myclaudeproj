using System.Collections.Generic;
using System.Text.RegularExpressions;
using Crosstales.BWF.Data;
using UnityEngine;

namespace Crosstales.BWF.Provider
{
	[ExecuteInEditMode]
	public abstract class BaseProvider : MonoBehaviour, IProvider
	{
		[Header("Regex Options")]
		[Tooltip("Option1 (default: RegexOptions.IgnoreCase).")]
		public RegexOptions RegexOption1;

		[Tooltip("Option2 (default: RegexOptions.CultureInvariant).")]
		public RegexOptions RegexOption2;

		[Tooltip("Option3 (default: RegexOptions.None).")]
		public RegexOptions RegexOption3;

		[Tooltip("Option4 (default: RegexOptions.None).")]
		public RegexOptions RegexOption4;

		[Tooltip("Option5 (default: RegexOptions.None).")]
		public RegexOptions RegexOption5;

		[Header("Sources")]
		[Tooltip("All sources for this provider.")]
		[ContextMenuItem("Create Source", "createSource")]
		public List<Source> Sources;

		[Header("Load Behaviour")]
		[Tooltip("Clears all existing bad words on 'Load' (default: true).")]
		public bool ClearOnLoad;

		protected readonly List<string> coRoutines;

		protected bool _loading;

		public int RegexCount => 0;

		public bool isReady { get; set; }

		public abstract void Load();

		public abstract void Save();

		public List<string> Verify(Source source)
		{
			return null;
		}

		protected abstract void init();

		private void Awake()
		{
		}

		protected void logNoResourcesAdded()
		{
		}

		protected void createSource()
		{
		}
	}
}
