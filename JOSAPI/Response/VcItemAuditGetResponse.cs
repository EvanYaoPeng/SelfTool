using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VcItemAuditGetResponse : JdResponse{


         [XmlElement("josProductAuditDto")]
public  		string
  josProductAuditDto { get; set; }


}
}
