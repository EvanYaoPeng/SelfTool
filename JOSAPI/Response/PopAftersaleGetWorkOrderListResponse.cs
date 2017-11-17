using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class PopAftersaleGetWorkOrderListResponse : JdResponse{


         [XmlElement("query_work_order_result")]
public  		string
  queryWorkOrderResult { get; set; }


}
}
