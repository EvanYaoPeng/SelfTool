using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EptOrderDeliveryorderResponse : JdResponse{


         [XmlElement("deliveryorder_result")]
public  		string
  deliveryorderResult { get; set; }


}
}
