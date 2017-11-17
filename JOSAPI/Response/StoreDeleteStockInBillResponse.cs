using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class StoreDeleteStockInBillResponse : JdResponse{


         [XmlElement("stock_in_delete_result")]
public  		string
  stockInDeleteResult { get; set; }


}
}
