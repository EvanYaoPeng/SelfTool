using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamPromotionHotListResponse : JdResponse{


         [XmlElement("hoteTeamList")]
public  		string
  hoteTeamList { get; set; }


}
}
