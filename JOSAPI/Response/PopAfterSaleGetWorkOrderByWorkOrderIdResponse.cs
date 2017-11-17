using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class PopAfterSaleGetWorkOrderByWorkOrderIdResponse : JdResponse{


         [XmlElement("query_work_order_detail_result")]
public  		string
  queryWorkOrderDetailResult { get; set; }


}
}
