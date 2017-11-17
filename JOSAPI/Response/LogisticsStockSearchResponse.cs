using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class LogisticsStockSearchResponse : JdResponse{


         [XmlElement("stock")]
public  		string
  stock { get; set; }


}
}
