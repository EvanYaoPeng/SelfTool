using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WarePriceGetResponse : JdResponse{


         [XmlElement("price_changes")]
public  		List<string>
  priceChanges { get; set; }


}
}
