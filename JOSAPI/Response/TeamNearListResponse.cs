using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamNearListResponse : JdResponse{


         [XmlElement("nearTeamList")]
public  		string
  nearTeamList { get; set; }


}
}
