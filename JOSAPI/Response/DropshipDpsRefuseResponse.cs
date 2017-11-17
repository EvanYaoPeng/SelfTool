using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class DropshipDpsRefuseResponse : JdResponse{


         [XmlElement("refuseResult")]
public  		string
  refuseResult { get; set; }


}
}
