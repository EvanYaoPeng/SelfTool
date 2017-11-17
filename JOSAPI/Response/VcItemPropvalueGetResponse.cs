using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VcItemPropvalueGetResponse : JdResponse{


         [XmlElement("values")]
public  		List<string>
  values { get; set; }


}
}
