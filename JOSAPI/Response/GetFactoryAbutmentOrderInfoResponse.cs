using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class GetFactoryAbutmentOrderInfoResponse : JdResponse{


         [XmlElement("getfactoryabutmentorderinfo_result")]
public  		List<string>
  getfactoryabutmentorderinfoResult { get; set; }


}
}
