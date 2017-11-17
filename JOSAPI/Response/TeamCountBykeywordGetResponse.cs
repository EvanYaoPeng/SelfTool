using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamCountBykeywordGetResponse : JdResponse{


         [XmlElement("team_count_byKeyWord_for_jos")]
public  		string
  teamCountByKeyWordForJos { get; set; }


}
}
