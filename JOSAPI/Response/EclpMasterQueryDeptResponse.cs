using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpMasterQueryDeptResponse : JdResponse{


         [XmlElement("querydept_result")]
public  		List<string>
  querydeptResult { get; set; }


}
}
