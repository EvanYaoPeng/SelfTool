using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpMasterGetSellerInfoResponse : JdResponse{


         [XmlElement("getsellerinfo_result")]
public  		string
  getsellerinfoResult { get; set; }


}
}
