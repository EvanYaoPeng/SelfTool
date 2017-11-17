using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class IncrementCustomerPermitResponse : JdResponse{


         [XmlElement("appCustomer")]
public  		string
  appCustomer { get; set; }


}
}
