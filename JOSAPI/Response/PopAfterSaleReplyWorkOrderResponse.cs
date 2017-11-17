using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class PopAfterSaleReplyWorkOrderResponse : JdResponse{


         [XmlElement("work_order_response")]
public  		string
  workOrderResponse { get; set; }


}
}
