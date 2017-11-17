using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class LogisticsO2oEndstatusUpdateResponse : JdResponse{


         [XmlElement("OrderResponseStatus")]
public  		string
  OrderResponseStatus { get; set; }


}
}
