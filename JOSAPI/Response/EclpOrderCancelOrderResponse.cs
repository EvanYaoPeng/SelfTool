using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpOrderCancelOrderResponse : JdResponse{


         [XmlElement("cancelorder_result")]
public  		string
  cancelorderResult { get; set; }


}
}
