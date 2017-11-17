using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class MarketServicePropertyGetResponse : JdResponse{


         [XmlElement("serviceItemResult")]
public  		string
  serviceItemResult { get; set; }


}
}
