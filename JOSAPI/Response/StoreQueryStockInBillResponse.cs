using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class StoreQueryStockInBillResponse : JdResponse{


         [XmlElement("query_stock_in_result")]
public  		string
  queryStockInResult { get; set; }


}
}
