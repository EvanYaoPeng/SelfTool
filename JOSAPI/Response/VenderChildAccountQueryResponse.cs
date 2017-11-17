using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VenderChildAccountQueryResponse : JdResponse{


         [XmlElement("child_account_result")]
public  		string
  childAccountResult { get; set; }


}
}
