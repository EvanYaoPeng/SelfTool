using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class WareReadFindOpReasonResponse : JdResponse{


         [XmlElement("opReason")]
public  		string
  opReason { get; set; }


}
}
