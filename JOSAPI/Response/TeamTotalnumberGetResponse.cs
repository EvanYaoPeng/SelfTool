using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamTotalnumberGetResponse : JdResponse{


         [XmlElement("current_team_count_for_jos")]
public  		string
  currentTeamCountForJos { get; set; }


}
}
