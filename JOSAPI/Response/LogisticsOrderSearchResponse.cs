using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class LogisticsOrderSearchResponse : JdResponse{


         [XmlElement("orders")]
public  		string
  orders { get; set; }


}
}
