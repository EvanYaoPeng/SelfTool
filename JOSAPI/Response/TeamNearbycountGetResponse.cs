using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamNearbycountGetResponse : JdResponse{


         [XmlElement("nearby_team_count_for_jos")]
public  		string
  nearbyTeamCountForJos { get; set; }


}
}
