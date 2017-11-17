using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class StoreCreateStockOutBillResponse : JdResponse{


         [XmlElement("stockout_result")]
public  		string
  stockoutResult { get; set; }


}
}
