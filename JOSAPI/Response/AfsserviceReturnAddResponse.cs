using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AfsserviceReturnAddResponse : JdResponse{


         [XmlElement("returnAddResult")]
public  		string
  returnAddResult { get; set; }


}
}
