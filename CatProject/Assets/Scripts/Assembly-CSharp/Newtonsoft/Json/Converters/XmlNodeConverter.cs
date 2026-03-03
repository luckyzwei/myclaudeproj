using System;
using System.Collections.Generic;
using System.Xml;

namespace Newtonsoft.Json.Converters
{
	public class XmlNodeConverter : JsonConverter
	{
		private const string TextName = "#text";

		private const string CommentName = "#comment";

		private const string CDataName = "#cdata-section";

		private const string WhitespaceName = "#whitespace";

		private const string SignificantWhitespaceName = "#significant-whitespace";

		private const string DeclarationName = "?xml";

		private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";

		public string DeserializeRootElementName { get; set; }

		public bool WriteArrayAttribute { get; set; }

		public bool OmitRootObject { get; set; }

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		private IXmlNode WrapXml(object value)
		{
			return null;
		}

		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
		}

		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		private bool IsArray(IXmlNode node)
		{
			return false;
		}

		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
		}

		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
		}

		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
		}

		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
		}

		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			return null;
		}

		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
		}

		private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager)
		{
			return null;
		}

		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
		}

		private bool IsNamespaceAttribute(string attributeName, out string prefix)
		{
			prefix = null;
			return false;
		}

		private IEnumerable<IXmlNode> ValueAttributes(IEnumerable<IXmlNode> c)
		{
			return null;
		}

		public override bool CanConvert(Type valueType)
		{
			return false;
		}
	}
}
