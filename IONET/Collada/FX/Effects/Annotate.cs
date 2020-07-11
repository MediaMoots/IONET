using System;
using System.Xml;
using System.Xml.Serialization;

namespace IONET.Collada.FX.Effects
{
	[Serializable()]
	[XmlType(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="annotate", Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=true)]
	public partial class Annotate
	{
		[XmlAttribute("name")]
		public string Name;
		
		/// <summary>
		/// Need to determine the type and value of the Object(s)
		/// </summary>
		[XmlAnyElement]
		public XmlElement[] Data;		
		
	}
}

