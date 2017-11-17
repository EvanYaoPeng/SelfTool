using System;
using System.Xml.Serialization;
using System.Collections.Generic;

				namespace Jd.Api.Response
{





public class VcCreateReturnOrderResponse : JdResponse{


         [XmlElement("returnOrderIds")]
public  		List<string>
  returnOrderIds { get; set; }


}
}
