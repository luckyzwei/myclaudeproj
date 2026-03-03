using System.Xml;

namespace Newtonsoft.Json.Converters
{
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		private XmlDeclaration _declaration;

		public string Version => null;

		public string Encoding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Standalone
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XmlDeclarationWrapper(XmlDeclaration declaration)
			: base(null)
		{
		}
	}
}
