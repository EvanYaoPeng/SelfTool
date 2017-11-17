using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AfsserviceReturnCancelResponse : JdResponse{


         [XmlElement("returnCancelResult")]
public  		string
  returnCancelResult { get; set; }


}
}
