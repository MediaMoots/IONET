using System;
using System.Xml;
using System.Xml.Serialization;

namespace IONET.Collada.FX.Texturing
{
	[Serializable()]
	[XmlType(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(ElementName="samplerCUBE", Namespace="http://www.collada.org/2005/11/COLLADASchema", IsNullable=true)]
	public partial class SamplerCUBE : IONET.Collada.FX.Texturing.FX_Sampler_Common
	{

	}
}

