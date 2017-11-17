using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class MarketServiceListGetResponse : JdResponse{


         [XmlElement("services_result")]
public  		string
  servicesResult { get; set; }


}
}
