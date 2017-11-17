using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpRtsIsvRtsQueryResponse : JdResponse{


         [XmlElement("rtsResultList")]
public  		List<string>
  rtsResultList { get; set; }


}
}
