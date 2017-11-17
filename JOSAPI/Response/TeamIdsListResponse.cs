using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamIdsListResponse : JdResponse{


         [XmlElement("idsTeamList")]
public  		string
  idsTeamList { get; set; }


}
}
