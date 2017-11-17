using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class TeamCitylistGetResponse : JdResponse{


         [XmlElement("city_list_for_jos")]
public  		string
  cityListForJos { get; set; }


}
}
