using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AreaCountyGetResponse : JdResponse{


         [XmlElement("county_areas")]
public  		string
  countyAreas { get; set; }


         [XmlElement("success")]
public  		bool
  success { get; set; }


}
}
