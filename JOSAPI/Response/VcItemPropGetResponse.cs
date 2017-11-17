using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VcItemPropGetResponse : JdResponse{


         [XmlElement("props")]
public  		List<string>
  props { get; set; }


}
}
