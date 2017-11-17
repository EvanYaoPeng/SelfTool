using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VcItemAdAuditGetResponse : JdResponse{


         [XmlElement("applyAuditDto")]
public  		string
  applyAuditDto { get; set; }


}
}
