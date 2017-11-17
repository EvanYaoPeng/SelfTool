using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class LogisticsO2oOrderQueryAfsResponse : JdResponse{


         [XmlElement("Afs_Service_Response")]
public  		string
  afsServiceResponse { get; set; }


}
}
