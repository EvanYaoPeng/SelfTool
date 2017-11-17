using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AfsserviceCustomerDeliveryAddResponse : JdResponse{


         [XmlElement("customerDeliveryResult")]
public  		string
  customerDeliveryResult { get; set; }


}
}
