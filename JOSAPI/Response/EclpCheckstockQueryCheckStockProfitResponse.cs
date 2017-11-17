using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpCheckstockQueryCheckStockProfitResponse : JdResponse{


         [XmlElement("checkstockProfitList")]
public  		List<string>
  checkstockProfitList { get; set; }


}
}
