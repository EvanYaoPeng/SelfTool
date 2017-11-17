using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class GetFactoryAbutmentCancelInfoResponse : JdResponse{


         [XmlElement("getfactoryabutmentcancelinfo_result")]
public  		List<string>
  getfactoryabutmentcancelinfoResult { get; set; }


}
}
