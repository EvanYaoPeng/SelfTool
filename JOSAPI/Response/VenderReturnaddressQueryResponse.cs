using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class VenderReturnaddressQueryResponse : JdResponse{


         [XmlElement("returnAddressResult")]
public  		string
  returnAddressResult { get; set; }


}
}
