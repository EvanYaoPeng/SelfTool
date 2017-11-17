using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EclpCheckstockQueryCheckStockLossesResponse : JdResponse{


         [XmlElement("checkstocklossesList")]
public  		List<string>
  checkstocklossesList { get; set; }


}
}
