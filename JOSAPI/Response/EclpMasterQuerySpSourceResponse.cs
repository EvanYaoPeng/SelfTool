using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpMasterQuerySpSourceResponse : JdResponse{


         [XmlElement("queryspsource_result")]
public  		List<string>
  queryspsourceResult { get; set; }


}
}
