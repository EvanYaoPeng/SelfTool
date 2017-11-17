using System;
using System.Xml.Serialization;
using System.Collections.Generic;

				namespace Jd.Api.Response
{





public class ProcurementOrderCreateResponse : JdResponse{


         [XmlElement("purchaseOrderCodes")]
public  		List<string>
  purchaseOrderCodes { get; set; }


}
}
