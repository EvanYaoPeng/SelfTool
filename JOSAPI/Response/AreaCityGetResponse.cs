using System;
using System.Xml.Serialization;
using System.Collections.Generic;

			using Jd.Api.Domain;
			namespace Jd.Api.Response
{





public class AreaCityGetResponse : JdResponse{


         [XmlElement("city_areas")]
public  		string
  cityAreas { get; set; }


         [XmlElement("success")]
public  		bool
  success { get; set; }


}
}
