using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class LogisticsReturnorderCancelResponse : JdResponse{


         [XmlElement("process_result")]
public  		string
  processResult { get; set; }


}
}
