using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamSubGroupListGetResponse : JdResponse{


         [XmlElement("sub_group_list_for_jos")]
public  		string
  subGroupListForJos { get; set; }


}
}
