using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AfsserviceAuditRejectResponse : JdResponse{


         [XmlElement("afsServiceAuditRejectResult")]
public  		string
  afsServiceAuditRejectResult { get; set; }


}
}
