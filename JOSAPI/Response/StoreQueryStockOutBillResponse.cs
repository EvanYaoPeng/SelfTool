using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class StoreQueryStockOutBillResponse : JdResponse{


         [XmlElement("query_stock_out_result")]
public  		string
  queryStockOutResult { get; set; }


}
}
