using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class GetFactoryAbutmentDeliveryInfoResponse : JdResponse{


         [XmlElement("getfactoryabutmentdeliveryinfo_result")]
public  		List<string>
  getfactoryabutmentdeliveryinfoResult { get; set; }


}
}
