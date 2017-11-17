using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpStockQueryStockResponse : JdResponse{


         [XmlElement("querystock_result")]
public  		List<string>
  querystockResult { get; set; }


}
}
