using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class LinksAdapter : Links
	{
		[SerializeField]
		private string appstoreIOSURL;

		[SerializeField]
		private string appstoreAndroidURL;

		[SerializeField]
		private string publishingLink;

		[SerializeField]
		private string publishingBannerURI;

		public override string AppstoreIOSURL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string AppstoreAndroidURL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string PublishingLink
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string PublishingBannerURI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
