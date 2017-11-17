using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VenderShipaddressQueryResponse : JdResponse{


         [XmlElement("returnAddressResult")]
public  		string
  returnAddressResult { get; set; }


}
}
