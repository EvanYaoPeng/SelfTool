using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AfsserviceCancelResponse : JdResponse{


         [XmlElement("afsServiceCancelResult")]
public  		string
  afsServiceCancelResult { get; set; }


}
}
