using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class EtmsTraceGetResponse : JdResponse{


         [XmlElement("trace_api_dtos")]
public  		List<string>
  traceApiDtos { get; set; }


}
}
