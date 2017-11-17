using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class OrderVenderRemarkQueryByOrderIdResponse : JdResponse{


         [XmlElement("venderRemarkQueryResult")]
public  		string
  venderRemarkQueryResult { get; set; }


}
}
