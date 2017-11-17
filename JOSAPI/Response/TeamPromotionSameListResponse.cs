using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamPromotionSameListResponse : JdResponse{


         [XmlElement("sameTeamList")]
public  		string
  sameTeamList { get; set; }


}
}
