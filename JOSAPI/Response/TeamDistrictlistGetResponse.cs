using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamDistrictlistGetResponse : JdResponse{


         [XmlElement("district_list_for_jos")]
public  		string
  districtListForJos { get; set; }


}
}
