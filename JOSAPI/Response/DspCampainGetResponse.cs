using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class DspCampainGetResponse : JdResponse{


         [XmlElement("findcampaignbyid_result")]
public  		string
  findcampaignbyidResult { get; set; }


}
}
