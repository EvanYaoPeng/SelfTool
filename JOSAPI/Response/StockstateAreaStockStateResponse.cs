using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class StockstateAreaStockStateResponse : JdResponse{


         [XmlElement("msgs")]
public  		List<string>
  msgs { get; set; }


}
}
