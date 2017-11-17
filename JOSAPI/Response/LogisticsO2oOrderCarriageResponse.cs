using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class LogisticsO2oOrderCarriageResponse : JdResponse{


         [XmlElement("OrderExport")]
public  		string
  OrderExport { get; set; }


}
}
