using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class StoreCreateStockInBillResponse : JdResponse{


         [XmlElement("stockin_result")]
public  		string
  stockinResult { get; set; }


}
}
