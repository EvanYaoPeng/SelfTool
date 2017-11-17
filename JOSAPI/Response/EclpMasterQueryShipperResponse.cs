using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpMasterQueryShipperResponse : JdResponse{


         [XmlElement("queryshipper_result")]
public  		List<string>
  queryshipperResult { get; set; }


}
}
