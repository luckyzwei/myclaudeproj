using System.Xml;

namespace Newtonsoft.Json.Converters
{
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
	{
		private XmlElement _element;

		public XmlElementWrapper(XmlElement element)
			: base(null)
		{
		}

		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		public string GetPrefixOfNamespace(string namespaceURI)
		{
			return null;
		}
	}
}
