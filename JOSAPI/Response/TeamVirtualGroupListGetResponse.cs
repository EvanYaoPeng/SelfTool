using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamVirtualGroupListGetResponse : JdResponse{


         [XmlElement("virtual_group_list_for_jos")]
public  		string
  virtualGroupListForJos { get; set; }


}
}
