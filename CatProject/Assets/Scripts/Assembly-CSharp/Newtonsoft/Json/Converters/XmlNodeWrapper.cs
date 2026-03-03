using System.Collections.Generic;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	internal class XmlNodeWrapper : IXmlNode
	{
		private readonly XmlNode _node;

		public object WrappedNode => null;

		public XmlNodeType NodeType => default(XmlNodeType);

		public string Name => null;

		public string LocalName => null;

		public IList<IXmlNode> ChildNodes => null;

		public IList<IXmlNode> Attributes => null;

		public IXmlNode ParentNode => null;

		public string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Prefix => null;

		public string NamespaceURI => null;

		public XmlNodeWrapper(XmlNode node)
		{
		}

		private IXmlNode WrapNode(XmlNode node)
		{
			return null;
		}

		public IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
