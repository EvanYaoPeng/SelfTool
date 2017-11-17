using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class StockReadFindSkuStockResponse : JdResponse{


         [XmlElement("skuStocks")]
public  		List<string>
  skuStocks { get; set; }


}
}
