using System;
using UnityEngine;

namespace KWGameSettings
{
	[Serializable]
	public class AdsMediatorIronsourceAdapter : AdMediatorIronsource
	{
		[SerializeField]
		private AdsIronsourceAPSSettingsAdapter aps;

		[SerializeField]
		private string appKeyIos;

		[SerializeField]
		private string appKeyAndroid;

		[SerializeField]
		private string appKeyChina;

		public override AdsIronsourceAPSSettings APS
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string AppKeyIos
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string AppKeyAndroid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string AppKeyChina
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
