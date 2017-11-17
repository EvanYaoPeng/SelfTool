using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class DropshipDpsDeliveryResponse : JdResponse{


         [XmlElement("deliverResult")]
public  		string
  deliverResult { get; set; }


}
}
