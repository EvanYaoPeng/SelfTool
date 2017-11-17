using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamSearchResponse : JdResponse{


         [XmlElement("current_team_list_for_jos")]
public  		string
  currentTeamListForJos { get; set; }


}
}
