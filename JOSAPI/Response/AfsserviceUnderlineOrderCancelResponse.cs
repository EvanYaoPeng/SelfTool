using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AfsserviceUnderlineOrderCancelResponse : JdResponse{


         [XmlElement("underLineOrderCancelResult")]
public  		string
  underLineOrderCancelResult { get; set; }


}
}
