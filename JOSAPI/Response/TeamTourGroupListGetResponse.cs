using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamTourGroupListGetResponse : JdResponse{


         [XmlElement("tour_group_list_for_jos")]
public  		string
  tourGroupListForJos { get; set; }


}
}
