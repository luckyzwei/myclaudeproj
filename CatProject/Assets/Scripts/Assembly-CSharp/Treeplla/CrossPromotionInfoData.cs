using System;
using UnityEngine;

namespace Treeplla
{
	[Serializable]
	public class CrossPromotionInfoData
	{
		[SerializeField]
		private int _idx;

		[SerializeField]
		private string _name;

		[SerializeField]
		private string _campaign_name;

		[SerializeField]
		private int _active;

		[SerializeField]
		private string _onelink;

		[SerializeField]
		private string _onelink_id;

		[SerializeField]
		private int _genre;

		[SerializeField]
		private int _order;

		[SerializeField]
		private int _pre_register;

		[SerializeField]
		private string _scheme;

		[SerializeField]
		private string _package_id;

		[SerializeField]
		private string _icon;

		[SerializeField]
		private string _img;

		public int idx
		{
		get { return _idx; }
		set { _idx = value; }
	}

		public string name
		{
		get { return _name; }
		set { _name = value; }
	}

		public string campaign_name
		{
		get { return _campaign_name; }
		set { _campaign_name = value; }
	}

		public int active
		{
		get { return _active; }
		set { _active = value; }
	}

		public string onelink
		{
		get { return _onelink; }
		set { _onelink = value; }
	}

		public string onelink_id
		{
		get { return _onelink_id; }
		set { _onelink_id = value; }
	}

		public int genre
		{
		get { return _genre; }
		set { _genre = value; }
	}

		public int order
		{
		get { return _order; }
		set { _order = value; }
	}

		public int pre_register
		{
		get { return _pre_register; }
		set { _pre_register = value; }
	}

		public string scheme
		{
		get { return _scheme; }
		set { _scheme = value; }
	}

		public string package_id
		{
		get { return _package_id; }
		set { _package_id = value; }
	}

		public string icon
		{
		get { return _icon; }
		set { _icon = value; }
	}

		public string img
		{
		get { return _img; }
		set { _img = value; }
	}
	}
}
