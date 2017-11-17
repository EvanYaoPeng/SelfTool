using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class DspKcCampainStatusUpdateResponse : JdResponse{


         [XmlElement("updatestatus_result")]
public  		string
  updatestatusResult { get; set; }


}
}
