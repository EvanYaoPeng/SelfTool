using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class RestWorkorderReplyResponse : JdResponse{


         [XmlElement("work_order")]
public  		string
  workOrder { get; set; }


}
}
