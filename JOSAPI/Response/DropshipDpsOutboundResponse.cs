using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class DropshipDpsOutboundResponse : JdResponse{


         [XmlElement("outBoundResult")]
public  		string
  outBoundResult { get; set; }


}
}
