using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class LogisticsReturnorderQueryResponse : JdResponse{


         [XmlElement("response_return_order")]
public  		string
  responseReturnOrder { get; set; }


}
}
